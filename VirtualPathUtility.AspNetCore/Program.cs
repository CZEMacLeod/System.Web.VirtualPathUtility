using System.Web;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.MapGet("/", async (context) => {
	context.Response.ContentType = "text/html";
	await context.Response.WriteAsync(VirtualPathUtility.Tests.VirtualPathUtilityTests.Results());
	}
);

app.Run();
