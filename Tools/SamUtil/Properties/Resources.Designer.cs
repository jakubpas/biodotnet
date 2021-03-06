//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SamUtil.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SamUtil.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SAMUtils are a re-implemenation of SAM Tools as referenced here: 
        ///
        ///Li H.*, Handsaker B.*, Wysoker A., Fennell T., Ruan J., Homer N., Marth G., Abecasis G., Durbin R. and 1000 Genome Project Data Processing Subgroup (2009) The Sequence alignment/map (SAM) format and SAMtools. Bioinformatics, 25, 2078-9. [PMID: 19505943].
        /// </summary>
        internal static string AttributionText {
            get {
                return ResourceManager.GetString("AttributionText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .bai.
        /// </summary>
        internal static string BAM_INDEXFILEEXTENSION {
            get {
                return ResourceManager.GetString("BAM_INDEXFILEEXTENSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:   SAMUtils.exe Chimera [options] in.bam MeanValue StdDeviationValue
        ///Description: Process Chimeric regions in the parsed file..
        /// </summary>
        internal static string ChimericRegionsHelp {
            get {
                return ResourceManager.GetString("ChimericRegionsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:    SAMUtils.exe CoverageProfile [options] in.bam
        ///Description: Gets coverage Profile..
        /// </summary>
        internal static string DNACoverageHelp {
            get {
                return ResourceManager.GetString("DNACoverageHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:   SAMUtils.exe NucleotideDistribution[options] in.bam 
        ///Description: DNA Possible Occurence Help.
        /// </summary>
        internal static string DNAPossibleOccurenceHelp {
            get {
                return ResourceManager.GetString("DNAPossibleOccurenceHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Input File is empty..
        /// </summary>
        internal static string EmptyFile {
            get {
                return ResourceManager.GetString("EmptyFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Header Absent, Please reference list file.
        /// </summary>
        internal static string HeaderAbsent {
            get {
                return ResourceManager.GetString("HeaderAbsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Header Missing.
        /// </summary>
        internal static string HeaderMissing {
            get {
                return ResourceManager.GetString("HeaderMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:  SAMUtils.exe import [options] in.sam|in.bam
        ///Description:  Import converts SAM &lt;=&gt; BAM file formats.
        ///
        ///Options:
        ///-o:OutFile Output file name, by default .bam|.sam is concatenated to input filename
        ///-r:FILE  File path of TAB delimited file.(in.ref_list).
        /// </summary>
        internal static string ImportHelp {
            get {
                return ResourceManager.GetString("ImportHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect Header file format.
        /// </summary>
        internal static string IncorrectHeaderFile {
            get {
                return ResourceManager.GetString("IncorrectHeaderFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:	SAMUtils.exe index [options] in.bam
        ///Description: Generates Index file for given BAM file.
        ///
        ///Options:
        ///-o:OutFile Output file name, by default .bai is concatenated to input filename.
        /// </summary>
        internal static string IndexHelp {
            get {
                return ResourceManager.GetString("IndexHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid BAM file..
        /// </summary>
        internal static string InvalidBAMFile {
            get {
                return ResourceManager.GetString("InvalidBAMFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid SAM File..
        /// </summary>
        internal static string InvalidSAMFile {
            get {
                return ResourceManager.GetString("InvalidSAMFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:    SAMUtils.exe LengthAnomaly [options] in.bam MeanValue StdDeviationValue
        ///Description: Process chromosomes for length anamoly.
        /// </summary>
        internal static string LengthAnomalyHelp {
            get {
                return ResourceManager.GetString("LengthAnomalyHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:      SAMUtils.exe Merge [options] in1.bam in2.bam [..]
        ///Description: Helps in merging. 
        ///
        ///Options:
        ///-n          sort by read names
        ///-o:OutFile Output file name  (out.bam)
        ///-h:FILE     copy the header in FILE(SAM/BAM format) to out.bam [in1.bam]
        ///
        ///Note: Samtool merge does not reconstruct the @RG dictionary in the header.
        ///      Users must provide the correct header with -h.
        /// </summary>
        internal static string MergeHelp {
            get {
                return ResourceManager.GetString("MergeHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage: SAMUtils.exe orphan [options] in.bam MeanValue StdDeviationValue
        ///Description: Process Chromosomes with orphan regions..
        /// </summary>
        internal static string OrphanRegionsHelp {
            get {
                return ResourceManager.GetString("OrphanRegionsHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reference File not in correct format.
        /// </summary>
        internal static string ReferenceFile {
            get {
                return ResourceManager.GetString("ReferenceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:	   SAMUtils.exe command [options]
        ///Description: Utility to convert SAM to BAM and vice versa.
        ///
        ///Command:   Import  SAM &lt;=&gt; BAM conversion
        ///           Sort    Sort alignment file
        ///           Index   Index alignment
        ///           Merge   Merge sorted alignments
        ///           View    View output on console.
        /// </summary>
        internal static string SAMUtilHelp {
            get {
                return ResourceManager.GetString("SAMUtilHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sam Utility - Sample for .NET Bio.
        /// </summary>
        internal static string SamUtilSplashScreen {
            get {
                return ResourceManager.GetString("SamUtilSplashScreen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:     SAMUtils.exe sort [options] in.bam
        ///Description: It sort reads by name.
        ///Options:
        ///-n         sort by read names
        ///-o:OutFile Output file name, by default .sort is concatenated to input filename.
        /// </summary>
        internal static string SortHelp {
            get {
                return ResourceManager.GetString("SortHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Output is successfully written to the file: {0}.
        /// </summary>
        internal static string SuccessMessageWithOutputFileName {
            get {
                return ResourceManager.GetString("SuccessMessageWithOutputFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:    SAMUtils.exe view [options] in.bam|in.sam
        ///
        ///Description:  This command assumes the file on the command line is
        ///          in the BAM format and it prints the alignments in SAM.
        ///
        ///Options:
        ///
        ///-b       Output BAM
        ///-h       Print header for the SAM output
        ///-H       Print header only (no alignments)
        ///-S       Input is SAM format
        ///-u       Uncompressed BAM output
        ///-x       Output flag in HEX
        ///-X       Output flag in string
        ///-o:FILE  Output file name
        ///-f:INT   Required flag
        ///-F:INT   Filtering flag
        ///- [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ViewHelp {
            get {
                return ResourceManager.GetString("ViewHelp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write BAM output.
        /// </summary>
        internal static string WriteBAM {
            get {
                return ResourceManager.GetString("WriteBAM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot write SAM output.
        /// </summary>
        internal static string WriteSAM {
            get {
                return ResourceManager.GetString("WriteSAM", resourceCulture);
            }
        }
    }
}
