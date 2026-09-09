using ChilliCream.Nitro.App;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .ModifyServerOptions(options => options.Tool.ServeMode = ServeMode.Embedded)
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = true)
    .AddQueryContext()
    .AddPagingArguments()
    .AddFiltering()
    .AddSorting()
    .AddInMemorySubscriptions()
    .AddHotChocolateTypes()
    ;

var app = builder.Build();

app.MapGraphQL();
app.Run();
