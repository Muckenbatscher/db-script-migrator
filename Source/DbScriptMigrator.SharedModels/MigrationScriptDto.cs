using System.Text.Json.Serialization;

namespace DbScriptMigrator.SharedModels;

public record MigrationScriptDto(
    [property: JsonPropertyName("command")] string Command);
