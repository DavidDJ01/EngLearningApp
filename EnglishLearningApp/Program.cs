using EnglishLearningApp;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;


var builderWeb = WebHost.CreateDefaultBuilder(args)
           .UseUrls("http://localhost:4000") // Cổng mong muốn
           .UseStartup<StartUp>();



var webHost = builderWeb.Build();



webHost.Run();



/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddTransient<IStartup, StartUp>();






var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{



  *//*  app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();*//*
}



*/





/*builderWeb.Build().Run();*/

/*app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();*/
