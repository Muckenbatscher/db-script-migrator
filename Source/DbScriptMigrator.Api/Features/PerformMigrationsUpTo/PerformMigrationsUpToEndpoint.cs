using DbScriptMigrator.SharedModels;
using DbScriptMigrator.SharedModels.PerformMigrationsUpTo;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DbScriptMigrator.Api.Features.PerformMigrationsUpTo;

public class PerformMigrationsUpToEndpoint : IEndpoint
{
    public static void Map(IEndpointRouteBuilder app)
    {
        app.MapPost("/up-to/{id:guid}", Handle);
    }

    private static async Task<Results<Ok<PerformMigrationsUpToResponse>, NotFound>> Handle(
        Guid id, CancellationToken token)
    {
        var migrations = GetRandomMigrationDtos();
        return TypedResults.Ok(new PerformMigrationsUpToResponse(migrations));
    }

    private static IEnumerable<MigrationDto> GetRandomMigrationDtos()
    {
        var random = new Random();
        var count = random.Next(3, 10);
        return Enumerable.Range(0, count)
            .Select(_ => GetRandomMigrationDto(random));
    }
    private static MigrationDto GetRandomMigrationDto(Random random)
    {
        var id = Guid.NewGuid();
        var name = $"Migration {random.Next(1, 100)}";
        var scripts = new List<string> { "Script1.sql", "Script2.sql" };
        var isApplied = random.Next(0, 2) == 0;
        DateTime? appliedDate = isApplied
            ? DateTime.UtcNow.AddDays(-random.Next(1, 30))
            : null;
        return new MigrationDto(id, name, [], isApplied, appliedDate);
    }
}
