namespace pointer_poc_minimal_api.Endpoints.Pointer
{
    public static class MapPointerEndpointsExtensions
    {
        public static IEndpointRouteBuilder MapPointerEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGetPointerAddressesEndpoint();

            return app;
        }
    }
}