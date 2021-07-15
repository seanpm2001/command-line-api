﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.CommandLine.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.CommandLine.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Cannot parse argument &apos;{0}&apos; as expected type {1}..
        /// </summary>
        internal static string ArgumentConversionCannotParse {
            get {
                return ResourceManager.GetString("ArgumentConversionCannotParse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse argument &apos;{0}&apos; for command &apos;{1}&apos; as expected type {2}..
        /// </summary>
        internal static string ArgumentConversionCannotParseForCommand {
            get {
                return ResourceManager.GetString("ArgumentConversionCannotParseForCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot parse argument &apos;{0}&apos; for option &apos;{1}&apos; as expected type {2}..
        /// </summary>
        internal static string ArgumentConversionCannotParseForOption {
            get {
                return ResourceManager.GetString("ArgumentConversionCannotParseForOption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; expects no more than {1} arguments, but {2} were provided..
        /// </summary>
        internal static string CommandExpectsFewerArguments {
            get {
                return ResourceManager.GetString("CommandExpectsFewerArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; expects a single argument but {1} were provided..
        /// </summary>
        internal static string CommandExpectsOneArgument {
            get {
                return ResourceManager.GetString("CommandExpectsOneArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No argument was provided for Command &apos;{0}&apos;..
        /// </summary>
        internal static string CommandNoArgumentProvided {
            get {
                return ResourceManager.GetString("CommandNoArgumentProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required argument missing for command: {0}.
        /// </summary>
        internal static string CommandRequiredArgumentMissing {
            get {
                return ResourceManager.GetString("CommandRequiredArgumentMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attach your debugger to process {0} ({1})..
        /// </summary>
        internal static string DebugDirectiveAttachToProcess {
            get {
                return ResourceManager.GetString("DebugDirectiveAttachToProcess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debug directive specified, but no process names are listed as allowed for debug.
        ///Add your process name to the &apos;{0}&apos; environment variable.
        ///The value of the variable should be the name of the processes, separated by a semi-colon &apos;;&apos;, for example &apos;{0}={1}&apos;.
        /// </summary>
        internal static string DebugDirectiveExecutableNotSpecified {
            get {
                return ResourceManager.GetString("DebugDirectiveExecutableNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process name &apos;{0}&apos; is not included in the list of debuggable process names in the {1} environment variable (&apos;{2}&apos;).
        /// </summary>
        internal static string DebugDirectiveProcessNotIncludedInEnvironmentVariable {
            get {
                return ResourceManager.GetString("DebugDirectiveProcessNotIncludedInEnvironmentVariable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory does not exist: {0}.
        /// </summary>
        internal static string DirectoryDoesNotExist {
            get {
                return ResourceManager.GetString("DirectoryDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception during registration:
        ///{0}.
        /// </summary>
        internal static string DotnetSuggestExceptionOccurred {
            get {
                return ResourceManager.GetString("DotnetSuggestExceptionOccurred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} exited with code {1}
        ///OUT:
        ///{2}
        ///ERR:
        ///{3}.
        /// </summary>
        internal static string DotnetSuggestExitMessage {
            get {
                return ResourceManager.GetString("DotnetSuggestExitMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error reading response file &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string ErrorReadingResponseFile {
            get {
                return ResourceManager.GetString("ErrorReadingResponseFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled exception: .
        /// </summary>
        internal static string ExceptionHandlerHeader {
            get {
                return ResourceManager.GetString("ExceptionHandlerHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File does not exist: {0}.
        /// </summary>
        internal static string FileDoesNotExist {
            get {
                return ResourceManager.GetString("FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File or directory does not exist: {0}.
        /// </summary>
        internal static string FileOrDirectoryDoesNotExist {
            get {
                return ResourceManager.GetString("FileOrDirectoryDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments passed to the application that is being run..
        /// </summary>
        internal static string HelpAdditionalArgumentsDescription {
            get {
                return ResourceManager.GetString("HelpAdditionalArgumentsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Additional Arguments:.
        /// </summary>
        internal static string HelpAdditionalArgumentsTitle {
            get {
                return ResourceManager.GetString("HelpAdditionalArgumentsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to default.
        /// </summary>
        internal static string HelpArgumentDefaultValueTitle {
            get {
                return ResourceManager.GetString("HelpArgumentDefaultValueTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Arguments:.
        /// </summary>
        internal static string HelpArgumentsTitle {
            get {
                return ResourceManager.GetString("HelpArgumentsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commands:.
        /// </summary>
        internal static string HelpCommandsTitle {
            get {
                return ResourceManager.GetString("HelpCommandsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show help and usage information.
        /// </summary>
        internal static string HelpOptionDescription {
            get {
                return ResourceManager.GetString("HelpOptionDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (REQUIRED).
        /// </summary>
        internal static string HelpOptionsRequired {
            get {
                return ResourceManager.GetString("HelpOptionsRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Options:.
        /// </summary>
        internal static string HelpOptionsTitle {
            get {
                return ResourceManager.GetString("HelpOptionsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [[--] &lt;additional arguments&gt;...]].
        /// </summary>
        internal static string HelpUsageAdditionalArguments {
            get {
                return ResourceManager.GetString("HelpUsageAdditionalArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [command].
        /// </summary>
        internal static string HelpUsageCommandTitle {
            get {
                return ResourceManager.GetString("HelpUsageCommandTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [options].
        /// </summary>
        internal static string HelpUsageOptionsTitle {
            get {
                return ResourceManager.GetString("HelpUsageOptionsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usage:.
        /// </summary>
        internal static string HelpUsageTile {
            get {
                return ResourceManager.GetString("HelpUsageTile", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Description:.
        /// </summary>
        internal static string HelpDescriptionTitle {
            get {
                return ResourceManager.GetString("HelpDescriptionTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Character not allowed in a file name: {0}.
        /// </summary>
        internal static string InvalidCharactersInFileName {
            get {
                return ResourceManager.GetString("InvalidCharactersInFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Character not allowed in a path: {0}.
        /// </summary>
        internal static string InvalidCharactersInPath {
            get {
                return ResourceManager.GetString("InvalidCharactersInPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option &apos;{0}&apos; expects no more than {1} arguments, but {2} were provided..
        /// </summary>
        internal static string OptionExpectsFewerArguments {
            get {
                return ResourceManager.GetString("OptionExpectsFewerArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Option &apos;{0}&apos; expects a single argument but {1} were provided..
        /// </summary>
        internal static string OptionExpectsOneArgument {
            get {
                return ResourceManager.GetString("OptionExpectsOneArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No argument was provided for Option &apos;{0}&apos;..
        /// </summary>
        internal static string OptionNoArgumentProvided {
            get {
                return ResourceManager.GetString("OptionNoArgumentProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required argument missing for option: {0}.
        /// </summary>
        internal static string OptionRequiredArgumentMissing {
            get {
                return ResourceManager.GetString("OptionRequiredArgumentMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Required command was not provided..
        /// </summary>
        internal static string RequiredCommandWasNotProvided {
            get {
                return ResourceManager.GetString("RequiredCommandWasNotProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response file not found &apos;{0}&apos;.
        /// </summary>
        internal static string ResponseFileNotFound {
            get {
                return ResourceManager.GetString("ResponseFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; was not matched. Did you mean one of the following?.
        /// </summary>
        internal static string SuggestionsTokenNotMatched {
            get {
                return ResourceManager.GetString("SuggestionsTokenNotMatched", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument &apos;{0}&apos; not recognized. Must be one of:{1}.
        /// </summary>
        internal static string UnrecognizedArgument {
            get {
                return ResourceManager.GetString("UnrecognizedArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unrecognized command or argument &apos;{0}&apos;.
        /// </summary>
        internal static string UnrecognizedCommandOrArgument {
            get {
                return ResourceManager.GetString("UnrecognizedCommandOrArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} option cannot be combined with other arguments..
        /// </summary>
        internal static string VersionOptionCannotBeCombinedWithOtherArguments {
            get {
                return ResourceManager.GetString("VersionOptionCannotBeCombinedWithOtherArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show version information.
        /// </summary>
        internal static string VersionOptionDescription {
            get {
                return ResourceManager.GetString("VersionOptionDescription", resourceCulture);
            }
        }
    }
}
