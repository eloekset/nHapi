namespace ModelGenerator
{
    using System;
    using System.Configuration;

    using NHapi.SourceGeneration;
    using NHapi.SourceGeneration.Generators;

    using ConfigurationSettings = NHapi.SourceGeneration.ConfigurationSettings;

    public class ModelBuilder
    {
        public ModelBuilder()
        {
            BasePath = @"C:\GitHub\nHapi\src";
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            MessageTypeToBuild = MessageType.All;
            Version = "2.5";
        }

        public enum MessageType
        {
            All,
            Message,
            Segment,
            DataType,
            EventMapping,
        }

        public string BasePath { get; set; }

        public string Version { get; set; }

        public string ConnectionString { get; set; }

        public MessageType MessageTypeToBuild { get; set; }

        public void Execute()
        {
            if (!string.IsNullOrEmpty(ConnectionString))
            {
                ConfigurationSettings.ConnectionString = ConnectionString;
            }

            Console.WriteLine("Using Database:{0}", NormativeDatabase.Instance.Connection.ConnectionString);
            Console.WriteLine("Base Path:{0}", BasePath);

            switch (MessageTypeToBuild)
            {
                case MessageType.All:
                    SourceGenerator.MakeAll(BasePath, Version);
                    break;
                case MessageType.EventMapping:
                    SourceGenerator.MakeEventMapping(BasePath, Version);
                    break;
                case MessageType.Segment:
                    SegmentGenerator.MakeAll(BasePath, Version);
                    break;
                case MessageType.Message:
                    MessageGenerator.MakeAll(BasePath, Version);
                    break;
                case MessageType.DataType:
                    DataTypeGenerator.MakeAll(BasePath, Version);
                    break;
            }
        }
    }
}