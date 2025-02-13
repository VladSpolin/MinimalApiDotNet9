using Azure;
using MinimalApiDotNet9.Models;
using MinimalApiDotNet9.Services.Interfaces;

namespace MinimalApiDotNet9.Endpoints
{
    public static class ProductEndpoints
    {
        public static RouteGroupBuilder MapProductEndpoints(this RouteGroupBuilder group)
        {
            group.MapGet("/", async (IProductService productService) =>
                await productService.GetProductsAsync());

            group.MapGet("/{id:int}", async (IProductService productService, int id) =>
            {
                var product = await productService.GetProductByIdAsync(id);
                if (product is null) return Results.BadRequest("Product is not found");
                return Results.Ok(product);
            });

            group.MapPost("/", async (IProductService productService, Product product) =>
            {
                var productResponse = await productService.CreateUpdateProductAsync(product);
                return Results.Ok(productResponse);
            });

            group.MapDelete("/{id:int}", async (IProductService productService, int id) =>
            {
                await productService.DeleteProductAsync(id);
                return Results.Ok();
            });

            return group;
        }
    }
}
