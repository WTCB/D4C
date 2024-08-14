using Carter;
using D4C_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace D4C_API
{
    public class ProductModule : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var versionSet = app.NewApiVersionSet()
                .HasApiVersion(new Asp.Versioning.ApiVersion(1.0))
                .HasApiVersion(new Asp.Versioning.ApiVersion(2.0))
                .HasApiVersion(new Asp.Versioning.ApiVersion(3.0))
                .ReportApiVersions()
                .Build();

            app
                .MapGet("/v{version:apiVersion}/products", (ProductService service) => service.GetAllV1())
                .Produces<IEnumerable<Models.V1.Object>>()
                .WithApiVersionSet(versionSet)
                .MapToApiVersion(1.0)
                .HasDeprecatedApiVersion(1.0)
                .WithOpenApi();
            app
                .MapGet("/v{version:apiVersion}/product/{id?}", (string? id, [FromQuery] string? uri, [FromQuery(Name = "select")] string? selectedProperties, ProductService service) => service.GetV1(id, uri, selectedProperties) is { } product ? Results.Ok(product) : Results.NotFound())
                .Produces<Models.V1.Object>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithApiVersionSet(versionSet)
                .MapToApiVersion(1.0)
                .HasDeprecatedApiVersion(1.0)
                .WithOpenApi(generatedOperation =>
                {
                    var selectParameter = generatedOperation.Parameters[2];
                    selectParameter.Description = "This parameter allows you to determine which properties the API returns, Leave empty to return all the properties. Go to https://search-test.bsdd.buildingsmart.org/uri/bw/D4C-LCA/0.1 for entire list of supported properties";

                    var uriParamter = generatedOperation.Parameters[1];
                    uriParamter.Description = "URI of the product, e.g. https://some-link-to-knauf.be/viewer/acdb59b2-f983-404a-80dc-53475fdaba93/Knauf_MP_75_Plaster";

                    var idParamter = generatedOperation.Parameters[0];
                    idParamter.Description = "ID of the product, e.g. acdb59b2-f983-404a-80dc-53475fdaba93";

                    return generatedOperation;
                });


            app
                .MapGet("/v{version:apiVersion}/products", (ProductService service) => service.GetAllV2())
                .Produces<IEnumerable<Models.V1.Object>>()
                .WithApiVersionSet(versionSet)
                .MapToApiVersion(2.0)
                .HasDeprecatedApiVersion(2.0)
                .WithOpenApi();
            app
                .MapGet("/v{version:apiVersion}/product/{id?}", (string? id, [FromQuery] string? uri, [FromQuery(Name = "select")] string? selectedProperties, ProductService service) => service.GetV2(id, uri, selectedProperties) is { } product ? Results.Ok(product) : Results.NotFound())
                .Produces<Models.V1.Object>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithApiVersionSet(versionSet)
                .MapToApiVersion(2.0)
                .HasDeprecatedApiVersion(2.0)
                .WithOpenApi(generatedOperation =>
                {
                    var selectParameter = generatedOperation.Parameters[2];
                    selectParameter.Description = "This parameter allows you to determine which properties the API returns, Leave empty to return all the properties. Go to https://search-test.bsdd.buildingsmart.org/uri/bw/D4C-LCA/0.1 for entire list of supported properties";

                    var uriParamter = generatedOperation.Parameters[1];
                    uriParamter.Description = "URI of the product, e.g. https://some-link-to-knauf.be/viewer/acdb59b2-f983-404a-80dc-53475fdaba93/Knauf_MP_75_Plaster";

                    var idParamter = generatedOperation.Parameters[0];
                    idParamter.Description = "ID of the product, e.g. acdb59b2-f983-404a-80dc-53475fdaba93";

                    return generatedOperation;
                });


            app
                .MapGet("/v{version:apiVersion}/products", (ProductService service) => service.GetAllV3())
                .Produces<IEnumerable<Models.V1.Object>>()
                .WithApiVersionSet(versionSet)
                .MapToApiVersion(3.0)
                .WithOpenApi();
            app
                .MapGet("/v{version:apiVersion}/product/{id?}", (string? id, [FromQuery] string? uri, [FromQuery(Name = "select")] string? selectedProperties, ProductService service) => service.GetV3(id, uri, selectedProperties) is { } product ? Results.Ok(product) : Results.NotFound())
                .Produces<Models.V1.Object>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound)
                .WithApiVersionSet(versionSet)
                .MapToApiVersion(3.0)
                .WithOpenApi(generatedOperation =>
                {
                    var selectParameter = generatedOperation.Parameters[2];
                    selectParameter.Description = "This parameter allows you to determine which properties the API returns, Leave empty to return all the properties. Go to https://search-test.bsdd.buildingsmart.org/uri/bw/D4C-LCA/0.1 for entire list of supported properties";

                    var uriParamter = generatedOperation.Parameters[1];
                    uriParamter.Description = "URI of the product, e.g. https://some-link-to-knauf.be/viewer/acdb59b2-f983-404a-80dc-53475fdaba93/Knauf_MP_75_Plaster";

                    var idParamter = generatedOperation.Parameters[0];
                    idParamter.Description = "ID of the product, e.g. acdb59b2-f983-404a-80dc-53475fdaba93";

                    return generatedOperation;
                });
        }
    }
}
