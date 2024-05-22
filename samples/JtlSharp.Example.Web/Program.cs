using JtlSharp;
using JtlSharp.Example.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors();

var app = builder.Build();


app
    .UseCors(a => a.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod().Build())
    .UseRouting()
    .UseEndpoints(endpoints =>
    {
        endpoints.UseJtl<SampleJtlService>("Test1234");
    });

app.Run();
