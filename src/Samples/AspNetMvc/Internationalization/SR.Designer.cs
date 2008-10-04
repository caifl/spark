﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Internationalization {
    using System;
    
    
    /// <summary>
    /// A strongly-typed resource class, for looking up localized strings, formatting them, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilderEx class via the ResXFileCodeGeneratorEx custom tool.
    // To add or remove a member, edit your .ResX file then rerun the ResXFileCodeGeneratorEx custom tool or rebuild your VS.NET project.
    // Copyright (c) Dmytro Kryvko 2006-2008 (http://dmytro.kryvko.googlepages.com/)
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("DMKSoftware.CodeGenerators.Tools.StronglyTypedResourceBuilderEx", "2.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public class SR {
        
        private static global::System.Resources.ResourceManager _resourceManager;
        
        private static object _internalSyncObject;
        
        private static global::System.Globalization.CultureInfo _resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        /// Thread safe lock object used by this class.
        /// </summary>
        public static object InternalSyncObject {
            get {
                if (object.ReferenceEquals(_internalSyncObject, null)) {
                    global::System.Threading.Interlocked.CompareExchange(ref _internalSyncObject, new object(), null);
                }
                return _internalSyncObject;
            }
        }
        
        /// <summary>
        /// Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(_resourceManager, null)) {
                    global::System.Threading.Monitor.Enter(InternalSyncObject);
                    try {
                        if (object.ReferenceEquals(_resourceManager, null)) {
                            global::System.Threading.Interlocked.Exchange(ref _resourceManager, new global::System.Resources.ResourceManager("Internationalization.SR", typeof(SR).Assembly));
                        }
                    }
                    finally {
                        global::System.Threading.Monitor.Exit(InternalSyncObject);
                    }
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        /// Overrides the current thread's CurrentUICulture property for all
        /// resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return _resourceCulture;
            }
            set {
                _resourceCulture = value;
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'English'.
        /// </summary>
        public static string English {
            get {
                return ResourceManager.GetString("English", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Français'.
        /// </summary>
        public static string French {
            get {
                return ResourceManager.GetString("French", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Internationalization'.
        /// </summary>
        public static string Internationalization {
            get {
                return ResourceManager.GetString("Internationalization", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Please select your language. Currently &lt;b&gt;{0}&lt;/b&gt;.'.
        /// </summary>
        public static string PleaseSelectYourLanguage {
            get {
                return ResourceManager.GetString("PleaseSelectYourLanguage", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Português'.
        /// </summary>
        public static string Portuguese {
            get {
                return ResourceManager.GetString("Portuguese", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Español'.
        /// </summary>
        public static string Spanish {
            get {
                return ResourceManager.GetString("Spanish", _resourceCulture);
            }
        }
        
        /// <summary>
        /// Looks up a localized string similar to 'Welcome, {0}!'.
        /// </summary>
        public static string WelcomeUser {
            get {
                return ResourceManager.GetString("WelcomeUser", _resourceCulture);
            }
        }
        
        /// <summary>
        /// The stub formatting method returning the English property value.
        /// </summary>
        /// <returns>The English property value.</returns>
        public static string EnglishFormat() {
            return English;
        }
        
        /// <summary>
        /// The stub formatting method returning the French property value.
        /// </summary>
        /// <returns>The French property value.</returns>
        public static string FrenchFormat() {
            return French;
        }
        
        /// <summary>
        /// The stub formatting method returning the Internationalization property value.
        /// </summary>
        /// <returns>The Internationalization property value.</returns>
        public static string InternationalizationFormat() {
            return Internationalization;
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Please select your language. Currently &lt;b&gt;{0}&lt;/b&gt;.'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string PleaseSelectYourLanguageFormat(object arg0) {
            return string.Format(_resourceCulture, PleaseSelectYourLanguage, arg0);
        }
        
        /// <summary>
        /// The stub formatting method returning the Portuguese property value.
        /// </summary>
        /// <returns>The Portuguese property value.</returns>
        public static string PortugueseFormat() {
            return Portuguese;
        }
        
        /// <summary>
        /// The stub formatting method returning the Spanish property value.
        /// </summary>
        /// <returns>The Spanish property value.</returns>
        public static string SpanishFormat() {
            return Spanish;
        }
        
        /// <summary>
        /// Formats a localized string similar to 'Welcome, {0}!'.
        /// </summary>
        /// <param name="arg0">An object (0) to format.</param>
        /// <returns>A copy of format string in which the format items have been replaced by the String equivalent of the corresponding instances of Object in arguments.</returns>
        public static string WelcomeUserFormat(object arg0) {
            return string.Format(_resourceCulture, WelcomeUser, arg0);
        }
    }
}