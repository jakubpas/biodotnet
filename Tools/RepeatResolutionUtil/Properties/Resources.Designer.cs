//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepeatResolutionUtil.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RepeatResolutionUtil.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to {0} is already open. To open a new file please close the current file and try again..
        /// </summary>
        internal static string FileAlreadyOpen {
            get {
                return ResourceManager.GetString("FileAlreadyOpen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bad input in file [{0}].
        /// </summary>
        internal static string INVALID_INPUT_FILE {
            get {
                return ResourceManager.GetString("INVALID_INPUT_FILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot locate sequence [{0}] in query file [{1}].
        /// </summary>
        internal static string INVALID_QUERY_FILE {
            get {
                return ResourceManager.GetString("INVALID_QUERY_FILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not recognize one or more symbol in the sequence: {0}.
        /// </summary>
        internal static string InvalidSymbolInString {
            get {
                return ResourceManager.GetString("InvalidSymbolInString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DeltaAlignmentParser.
        /// </summary>
        internal static string Parser_Name {
            get {
                return ResourceManager.GetString("Parser_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RepeatResolution Utility - Sample for .NET Bio.
        /// </summary>
        internal static string RepeatResolutionSplashScreen {
            get {
                return ResourceManager.GetString("RepeatResolutionSplashScreen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:	   RepeatResolutionUtil.exe [options] &lt;input delta alignment file&gt; &lt;input query file&gt;
        ///
        ///RepeatResolution: Resolves ambiguity with placements of repeated sequences. Requires mate-pair information to resolve ambiguity.
        ///
        ///Options:
        ///
        ///-o:&lt;file&gt; Output file..
        /// </summary>
        internal static string RepeatResolutionUtilHelp {
            get {
                return ResourceManager.GetString("RepeatResolutionUtilHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sequence {0} contains more than 2GB data.
        /// </summary>
        internal static string SequenceDataGreaterthan2GB {
            get {
                return ResourceManager.GetString("SequenceDataGreaterthan2GB", resourceCulture);
            }
        }
    }
}
