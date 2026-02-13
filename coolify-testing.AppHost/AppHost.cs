var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.coolify_testing>("coolify-testing");

builder.Build().Run();
