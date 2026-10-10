using DbScriptMigrator.Api.Features.PerformAllMigrations;
using DbScriptMigrator.Api.Features.PerformMigrationsUpTo;

namespace DbScriptMigrator.Api.Routing;

public class PerformEndpointGroup : IEndpointGroup
{
    public static void Map(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/perform")
            .WithTags("Performing");
        group.MapEndpoint<PerformMigrationsUpToEndpoint>();
        group.MapEndpoint<PerformAllMigrationsEndpoint>();
    }
}