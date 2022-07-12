using Owin;

namespace VirtualPathUtility.AspNet4
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.Run(async (context) =>
			{
				context.Response.ContentType = "text/html";
				await context.Response.WriteAsync(VirtualPathUtility.Tests.VirtualPathUtilityTests.Results());
			});
		}
	}
}
