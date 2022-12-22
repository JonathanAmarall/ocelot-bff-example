using JayShop.Bff.Catalog.Aggregators;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;


var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

builder.Services.AddOcelot(builder.Configuration)
 .AddSingletonDefinedAggregator<FakeDefinedAggregator>();

//builder.Services.AddSwaggerForOcelot(builder.Configuration,
//  (o) =>
//  {
//      o.GenerateDocsForAggregates = true;
//  });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

//app.UseSwaggerForOcelotUI(opt =>
//{
//    opt.PathToSwaggerGenerator = "/swagger/docs";
//})
app.UseOcelot()
.Wait();

app.Run();

