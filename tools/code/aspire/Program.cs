using Aspire.Hosting;
using Projects;

internal static class Program
{
    private static void Main(string[] args)
    {
        var builder = DistributedApplication.CreateBuilder(args);

        builder.AddProject<integration_tests>("integration-tests");
               //.WithEnvironment("CSCHECK_SEED", "0000KOIPe036");

        builder.Build().Run();
    }
}