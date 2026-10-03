using DbScriptMigrator.SharedModels;
using DbScriptMigrator.SharedModels.GetMigrationById;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DbScriptMigrator.Api.Features.GetMigrationById;

public class GetMigrationByIdEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapGet("/migrations/{id:guid}", Handle);
    }

    private static async Task<Results<Ok<GetMigrationByIdResponse>, NotFound>> Handle(Guid id, CancellationToken token)
    {
        // Simulate fetching migration by ID from a data source
        var migration = new MigrationDto(id, "Sample Migration", [], false, null);
        if (migration is null)
        {
            return TypedResults.NotFound();
        }
        return TypedResults.Ok(new GetMigrationByIdResponse(migration));
    }
}
