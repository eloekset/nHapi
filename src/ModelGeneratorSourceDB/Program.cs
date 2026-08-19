namespace ModelGeneratorSourceDB
{
    using System.Reflection.Emit;

    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Args.Configuration.Configure<SourceDB>().CreateAndBind(args);
            command.Execute();
        }
    }
}
