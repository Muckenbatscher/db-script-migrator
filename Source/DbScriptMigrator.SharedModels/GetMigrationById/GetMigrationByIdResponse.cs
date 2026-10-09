using System.Text.Json.Serialization;

namespace DbScriptMigrator.SharedModels.GetMigrationById;

public record GetMigrationByIdResponse(
    [property: JsonPropertyName("migration")] MigrationDto Migration);
