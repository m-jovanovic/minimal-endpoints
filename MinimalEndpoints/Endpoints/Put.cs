using MinimalEndpoints.Abstractions;

namespace MinimalEndpoints.Endpoints;

public class Put : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("put", () => "Put endpoint");
    }
}