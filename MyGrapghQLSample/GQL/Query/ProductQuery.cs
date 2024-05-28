using GraphQL.Types;
using MyGrapghQLSample.GQL.Types;
using MyGrapghQLSample.Services;

namespace MyGrapghQLSample.GQL.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(IProductService productService)
        {
            Field<ListGraphType<ProductType>>(Name = "products", resolve: x => productService.GetProducts());
        }
    }
}
