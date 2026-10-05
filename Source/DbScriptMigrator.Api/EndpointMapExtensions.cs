namespace DbScriptMigrator.Api;

public static class EndpointMapExtensions
{
    extension(IEndpointRouteBuilder routeBuilder)
    {
        public IEndpointRouteBuilder MapEndpoint<TEndpoint>() where TEndpoint : IEndpoint
        {
            TEndpoint.Map(routeBuilder);
            return routeBuilder;
        }
        public IEndpointRouteBuilder MapEndpointGroup<TEndpointGroup>() where TEndpointGroup : IEndpointGroup
        {
            TEndpointGroup.Map(routeBuilder);
            return routeBuilder;
        }
    }
}