//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Web {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class VirtualPathUtilityErrors {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal VirtualPathUtilityErrors() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtualPathUtility.Library.net6._0.VirtualPathUtilityErrors", typeof(VirtualPathUtilityErrors).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use a leading .. to exit above the top directory..
        /// </summary>
        internal static string Cannot_exit_up_top_directory {
            get {
                return ResourceManager.GetString("Cannot_exit_up_top_directory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Empty path has no directory..
        /// </summary>
        internal static string Empty_path_has_no_directory {
            get {
                return ResourceManager.GetString("Empty_path_has_no_directory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid virtual path..
        /// </summary>
        internal static string Invalid_vpath {
            get {
                return ResourceManager.GetString("Invalid_vpath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The virtual path &apos;{0}&apos; is not rooted..
        /// </summary>
        internal static string Path_must_be_rooted {
            get {
                return ResourceManager.GetString("Path_must_be_rooted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is a physical path, but a virtual path was expected..
        /// </summary>
        internal static string Physical_path_not_allowed {
            get {
                return ResourceManager.GetString("Physical_path_not_allowed", resourceCulture);
            }
        }
    }
}
