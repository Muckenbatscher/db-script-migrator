using DbScriptMigrator.SharedModels;
using DbScriptMigrator.SharedModels.GetMigrationById;
using DbScriptMigrator.SharedModels.GetMigrations;
using DbScriptMigrator.SharedModels.PerformAllMigrations;
using DbScriptMigrator.SharedModels.PerformMigrationsUpTo;
using System.Text.Json.Serialization;

namespace DbScriptMigrator.Api;

[JsonSerializable(typeof(GetMigrationByIdResponse))]
[JsonSerializable(typeof(GetMigrationsResponse))]
[JsonSerializable(typeof(PerformAllMigrationsResponse))]
[JsonSerializable(typeof(PerformMigrationsUpToResponse))]
[JsonSerializable(typeof(MigrationDto))]
[JsonSerializable(typeof(MigrationScriptDto))]
internal partial class AppJsonSerializerContext : JsonSerializerContext;