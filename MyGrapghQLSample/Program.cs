using GraphQL.Server;
using MyGrapghQLSample.GQL.Query;
using MyGrapghQLSample.GQL.Schemas;
using MyGrapghQLSample.GQL.Types;
using MyGrapghQLSample.Services;

namespace MyGrapghQLSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IProductService, ProductService>();

            builder.Services.AddScoped<ProductType>();
            builder.Services.AddScoped<ProductQuery>();
            builder.Services.AddScoped<ProductSchema>();


            builder.Services.AddGraphQL().AddSystemTextJson();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.UseGraphQLGraphiQL("/ui/graphql");
            app.UseGraphQL<ProductSchema>();
            app.Run();
        }
    }
}