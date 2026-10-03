using System.Text.Json.Serialization;

namespace DbScriptMigrator.SharedModels.GetMigrations;

public record GetMigrationsResponse(
    [property: JsonPropertyName("migrations")] IEnumerable<MigrationDto> Migrations);
