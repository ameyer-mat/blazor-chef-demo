namespace FunctionChefApi
#nowarn "20"
open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.OpenApi.Models


module Program =
    let exitCode = 0

    [<EntryPoint>]
    let main args =

        let builder = WebApplication.CreateBuilder(args)

        builder.Services.AddControllers()
        builder.Services.AddSwaggerGen(fun c -> c.SwaggerDoc("v1", OpenApiInfo(Title = "FunctionChefApi", Version = "v1")))

        let app = builder.Build()

        app.UseHttpsRedirection()

        app.UseAuthorization()

        app.UseSwagger();
        app.UseSwaggerUI();

        app.MapControllers()

        app.Run()

        exitCode
