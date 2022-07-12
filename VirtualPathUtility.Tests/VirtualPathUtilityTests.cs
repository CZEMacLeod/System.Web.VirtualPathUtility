using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPathUtility.Tests
{
	public class VirtualPathUtilityTests
	{

		private static Dictionary<string, string> ToAbsolute = new()
		{
			{"/","/" },
			{"~/",System.Web.HttpRuntime.AppDomainAppVirtualPath},
			{"hello","ArgumentException" }
		};

		public static string Results()
		{
			var sb = new StringBuilder();

			sb.AppendLine("<html>");
			sb.AppendLine("<body>");

			sb.AppendLine("<table><caption>ToAbsolute</caption>");
			sb.AppendLine("<thead><tr><th>virtualPath</th><th>Return</th><th>Expected<th><th>Status</th></tr></thead>");
			sb.AppendLine("<tbody>");

			foreach (var item in ToAbsolute)
			{
				AddToAbsoluteResult(sb, item);
			}

			sb.AppendLine("</tbody>");
			sb.AppendLine("</table>");
			sb.AppendLine("</body>");
			sb.AppendLine("</html>");

			return sb.ToString();

		}

		private static void AddToAbsoluteResult(StringBuilder sb, KeyValuePair<string, string> item)
		{
			sb.AppendLine("<tr>");
			string result;
			try
			{
				result = System.Web.VirtualPathUtility.ToAbsolute(item.Key);
			}
			catch (ArgumentException)
			{
				result = typeof(ArgumentException).Name;
			}
			sb.AppendLine($"<td>{item.Key}</td><td>{result}</td><td>{item.Value}</td>");
			if (result == item.Value)
			{
				sb.AppendLine($"<td style=\"color: green\">Pass</td>");
			}
			else
			{
				sb.AppendLine($"<td style=\"color: red\">Fail</td>");
			}
			sb.AppendLine("</tr>");
		}
	}
}
