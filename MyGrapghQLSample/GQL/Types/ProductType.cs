using GraphQL.Types;
using MyGrapghQLSample.Models;

namespace MyGrapghQLSample.GQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(x => x.Id, type: typeof(IntGraphType));
            Field(x => x.Name, type: typeof(StringGraphType));
            Field(x => x.Quantity, type: typeof(IntGraphType));
        }
    }
}
