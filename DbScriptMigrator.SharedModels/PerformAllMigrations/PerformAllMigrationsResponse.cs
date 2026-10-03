using System.Text.Json.Serialization;

namespace DbScriptMigrator.SharedModels.PerformAllMigrations;

public record PerformAllMigrationsResponse(
    [property: JsonPropertyName("performed_migrations")] IEnumerable<MigrationDto> PerformedMigrations);
