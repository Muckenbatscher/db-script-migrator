using DbScriptMigrator.Api.Features.GetMigrationById;

namespace DbScriptMigrator.Api.Routing;

public class MigrationsEndpointGroup : IEndpointGroup
{
    public static void Map(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/migrations");
        group.MapEndpoint<GetMigrationByIdEndpoint>();
    }
}
