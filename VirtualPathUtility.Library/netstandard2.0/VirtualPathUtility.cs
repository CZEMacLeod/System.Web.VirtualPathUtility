namespace System.Web;

#if NETSTANDARD2_0
public static class VirtualPathUtility
{
	private const string PlatformError = "Only supported when running on ASP.NET Core or System.Web";
	/// <summary>Appends the literal slash mark (/) to the end of the virtual path, if one does not already exist.</summary>
	/// <returns>The modified virtual path.</returns>
	/// <param name="virtualPath">The virtual path to append the slash mark to.</param>
	public static string AppendTrailingSlash(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Combines a base path and a relative path.</summary>
	/// <returns>The combined <paramref name="basePath" /> and <paramref name="relativePath" />.</returns>
	/// <param name="basePath">The base path.</param>
	/// <param name="relativePath">The relative path.</param>
	/// <exception cref="T:System.Web.HttpException">
	///   <paramref name="relativePath" /> is a physical path.-or-<paramref name="relativePath" /> includes one or more colons.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="relativePath" /> is null or an empty string.-or-<paramref name="basePath" /> is null or an empty string.</exception>
	public static string Combine(string basePath, string relativePath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Returns the directory portion of a virtual path.</summary>
	/// <returns>The directory referenced in the virtual path. </returns>
	/// <param name="virtualPath">The virtual path.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="virtualPath" /> is not rooted. - or -<paramref name="virtualPath" /> is null or an empty string.</exception>
	public static string GetDirectory(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Retrieves the extension of the file that is referenced in the virtual path.</summary>
	/// <returns>The file name extension string literal, including the period (.), null, or an empty string ("").</returns>
	/// <param name="virtualPath">The virtual path.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="virtualPath" /> contains one or more characters that are not valid, as defined in <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
	public static string GetExtension(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Retrieves the file name of the file that is referenced in the virtual path.</summary>
	/// <returns>The file name literal after the last directory character in <paramref name="virtualPath" />; otherwise, the last directory name, if the last character of <paramref name="virtualPath" /> is a directory or volume separator character.</returns>
	/// <param name="virtualPath">The virtual path. </param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="virtualPath" /> contains one or more characters that are not valid, as defined in <see cref="F:System.IO.Path.InvalidPathChars" />. </exception>
	public static string GetFileName(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Returns a Boolean value indicating whether the specified virtual path is absolute; that is, it starts with a literal slash mark (/).</summary>
	/// <returns>true if <paramref name="virtualPath" /> is an absolute path and is not null or an empty string (""); otherwise, false.</returns>
	/// <param name="virtualPath">The virtual path to check. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="virtualPath" /> is null.</exception>
	public static bool IsAbsolute(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Returns a Boolean value indicating whether the specified virtual path is relative to the application.</summary>
	/// <returns>true if <paramref name="virtualPath" /> is relative to the application; otherwise, false.</returns>
	/// <param name="virtualPath">The virtual path to check. </param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="virtualPath" /> is null.</exception>
	public static bool IsAppRelative(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Returns the relative virtual path from one virtual path containing the root operator (the tilde [~]) to another.</summary>
	/// <returns>The relative virtual path from <paramref name="fromPath" /> to <paramref name="toPath" />.</returns>
	/// <param name="fromPath">The starting virtual path to return the relative virtual path from.</param>
	/// <param name="toPath">The ending virtual path to return the relative virtual path to.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="fromPath" /> is not rooted.- or -<paramref name="toPath" /> is not rooted.</exception>
	public static string MakeRelative(string fromPath, string toPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Removes a trailing slash mark (/) from a virtual path.</summary>
	/// <returns>A virtual path without a trailing slash mark, if the virtual path is not already the root directory ("/"); otherwise, null.</returns>
	/// <param name="virtualPath">The virtual path to remove any trailing slash mark from. </param>
	public static string RemoveTrailingSlash(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Converts a virtual path to an application absolute path.</summary>
	/// <returns>The absolute path representation of the specified virtual path. </returns>
	/// <param name="virtualPath">The virtual path to convert to an application-relative path. </param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="virtualPath" /> is not rooted. </exception>
	/// <exception cref="T:System.Web.HttpException">A leading double period (..) is used to exit above the top directory.</exception>
	public static string ToAbsolute(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Converts a virtual path to an application absolute path using the specified application path.</summary>
	/// <returns>The absolute virtual path representation of <paramref name="virtualPath" />.</returns>
	/// <param name="virtualPath">The virtual path to convert to an application-relative path.</param>
	/// <param name="applicationPath">The application path to use to convert <paramref name="virtualPath" /> to a relative path.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="applicationPath" /> is not rooted.</exception>
	/// <exception cref="T:System.Web.HttpException">A leading double period (..) is used in the application path to exit above the top directory.</exception>
	public static string ToAbsolute(string virtualPath, string applicationPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Converts a virtual path to an application-relative path using the application virtual path that is in the <see cref="P:System.Web.HttpRuntime.AppDomainAppVirtualPath" /> property. </summary>
	/// <returns>The application-relative path representation of <paramref name="virtualPath" />.</returns>
	/// <param name="virtualPath">The virtual path to convert to an application-relative path. </param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="virtualPath" /> is null. </exception>
	public static string ToAppRelative(string virtualPath) => throw new System.PlatformNotSupportedException(PlatformError);

	/// <summary>Converts a virtual path to an application-relative path using a specified application path.</summary>
	/// <returns>The application-relative path representation of <paramref name="virtualPath" />.</returns>
	/// <param name="virtualPath">The virtual path to convert to an application-relative path. </param>
	/// <param name="applicationPath">The application path to use to convert <paramref name="virtualPath" /> to a relative path. </param>
	public static string ToAppRelative(string virtualPath, string applicationPath) => throw new System.PlatformNotSupportedException(PlatformError);
}
#endif
