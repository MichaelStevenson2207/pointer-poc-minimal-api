using pointer_poc_minimal_api.Endpoints.Pointer;

namespace pointer_poc_minimal_api.Endpoints
{
    public static class EndpointExtensions
    {
        public static IEndpointRouteBuilder MapApiEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapPointerEndpoints();

            return app;
        }
    }
}