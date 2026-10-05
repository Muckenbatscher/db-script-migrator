namespace DbScriptMigrator.Api;

public interface IEndpointGroup
{
    static abstract void Map(IEndpointRouteBuilder app);
}
