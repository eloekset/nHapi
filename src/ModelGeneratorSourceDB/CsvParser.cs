namespace ModelGeneratorSourceDB
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class CsvParser
    {
        /// <summary>
        /// Parses a delimited CSV file into a list of dictionaries keyed by column header.
        /// </summary>
        public List<Dictionary<string, object>> ParseCsvFile(string filePath, char delimiter = ';')
        {
            var records = new List<Dictionary<string, object>>();
            var lines = ReadLines(filePath);
            if (lines.Count == 0) return records;

            var headers = SplitLine(lines[0], delimiter).Select(UnquoteAndTrim).ToArray();
            for (int i = 1; i < lines.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                var values = SplitLine(lines[i], delimiter);
                var record = new Dictionary<string, object>();
                for (int j = 0; j < headers.Length; j++)
                {
                    var rawValue = j < values.Count ? values[j] : null;
                    record[headers[j]] = UnquoteAndTrim(rawValue);
                }
                records.Add(record);
            }
            return records;
        }

        /// <summary>
        /// Parses a delimited CSV file into a list of strongly typed model objects.
        /// Properties are mapped to CSV columns using the explicit header-to-property
        /// mapping registered for the type in <see cref="CsvColumnMappings"/>.
        /// </summary>
        public List<T> ParseCsvFile<T>(string filePath, char delimiter = ';')
            where T : new()
        {
            var results = new List<T>();
            var lines = ReadLines(filePath);
            if (lines.Count == 0) return results;

            var headers = SplitLine(lines[0], delimiter).Select(UnquoteAndTrim).ToArray();
            var propertyMap = BuildPropertyMap<T>(headers);

            for (int i = 1; i < lines.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                var values = SplitLine(lines[i], delimiter);
                var instance = new T();
                foreach (var (columnIndex, property) in propertyMap)
                {
                    if (columnIndex >= values.Count) continue;

                    var rawValue = UnquoteAndTrim(values[columnIndex]);
                    SetPropertyValue(instance, property, rawValue);
                }
                results.Add(instance);
            }
            return results;
        }

        private static List<(int ColumnIndex, PropertyInfo Property)> BuildPropertyMap<T>(string[] headers)
        {
            var map = new List<(int, PropertyInfo)>();

            if (!CsvColumnMappings.ByType.TryGetValue(typeof(T), out var headerToPropertyName))
            {
                throw new InvalidOperationException($"No CSV column mapping registered for type '{typeof(T).Name}'. Add one to {nameof(CsvColumnMappings)}.");
            }

            var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var (headerName, propertyName) in headerToPropertyName)
            {
                var columnIndex = Array.FindIndex(headers, h => string.Equals(h, headerName, StringComparison.OrdinalIgnoreCase));
                if (columnIndex < 0)
                {
                    continue;
                }

                var property = properties.FirstOrDefault(p => p.Name == propertyName);
                if (property == null)
                {
                    throw new InvalidOperationException($"Property '{propertyName}' mapped from CSV header '{headerName}' was not found on type '{typeof(T).Name}'.");
                }

                map.Add((columnIndex, property));
            }
            return map;
        }

        private static void SetPropertyValue(object instance, PropertyInfo property, string rawValue)
        {
            var targetType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

            if (string.IsNullOrEmpty(rawValue))
            {
                if (Nullable.GetUnderlyingType(property.PropertyType) != null || property.PropertyType == typeof(string))
                {
                    property.SetValue(instance, null);
                }
                return;
            }

            object convertedValue;
            if (targetType == typeof(string))
            {
                convertedValue = rawValue;
            }
            else if (targetType == typeof(int))
            {
                convertedValue = int.TryParse(rawValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var intValue)
                    ? intValue
                    : (object)null;
            }
            else if (targetType == typeof(bool))
            {
                convertedValue = ParseBool(rawValue);
            }
            else if (targetType == typeof(DateTime))
            {
                convertedValue = DateTime.TryParse(rawValue, CultureInfo.InvariantCulture, DateTimeStyles.None, out var dateValue)
                    ? dateValue
                    : (object)null;
            }
            else
            {
                convertedValue = Convert.ChangeType(rawValue, targetType, CultureInfo.InvariantCulture);
            }

            if (convertedValue != null)
            {
                property.SetValue(instance, convertedValue);
            }
        }

        private static bool ParseBool(string rawValue)
        {
            return rawValue switch
            {
                "1" => true,
                "0" => false,
                _ => bool.TryParse(rawValue, out var result) && result,
            };
        }

        private static List<string> ReadLines(string filePath)
        {
            return File.ReadAllLines(filePath, Encoding.Latin1).ToList();
        }

        /// <summary>
        /// Splits a single CSV line on the given delimiter while honoring double-quoted
        /// fields (which may contain the delimiter or escaped "" quote characters).
        /// </summary>
        private static List<string> SplitLine(string line, char delimiter)
        {
            var fields = new List<string>();
            var currentField = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (inQuotes)
                {
                    if (c == '"')
                    {
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        {
                            currentField.Append('"');
                            i++;
                        }
                        else
                        {
                            inQuotes = false;
                        }
                    }
                    else
                    {
                        currentField.Append(c);
                    }
                }
                else
                {
                    if (c == '"')
                    {
                        inQuotes = true;
                    }
                    else if (c == delimiter)
                    {
                        fields.Add(currentField.ToString());
                        currentField.Clear();
                    }
                    else
                    {
                        currentField.Append(c);
                    }
                }
            }
            fields.Add(currentField.ToString());
            return fields;
        }

        private static string UnquoteAndTrim(string value)
        {
            return value?.Trim();
        }
    }
}
