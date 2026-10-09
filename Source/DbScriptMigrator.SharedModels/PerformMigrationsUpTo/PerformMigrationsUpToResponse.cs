using System.Text.Json.Serialization;

namespace DbScriptMigrator.SharedModels.PerformMigrationsUpTo;

public record PerformMigrationsUpToResponse(
    [property: JsonPropertyName("performed_migrations")] IEnumerable<MigrationDto> PerformedMigrations);
