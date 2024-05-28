using GraphQL.Types;
using MyGrapghQLSample.GQL.Query;

namespace MyGrapghQLSample.GQL.Schemas
{
    public class ProductSchema : Schema
    {
        public ProductSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<ProductQuery>();
        }
    }
}
