using MicroserviceTemplate;

var builder = Host
        .CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());

builder.Build().Run();
