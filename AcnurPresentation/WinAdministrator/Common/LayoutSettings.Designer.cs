﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinAdministrator.Common
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class LayoutSettings : global::System.Configuration.ApplicationSettingsBase
    {

        private static LayoutSettings defaultInstance = ((LayoutSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LayoutSettings())));

        public static LayoutSettings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogicalLayout
        {
            get
            {
                return ((string)(this["LogicalLayout"]));
            }
            set
            {
                this["LogicalLayout"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ViewsLayout
        {
            get
            {
                return ((string)(this["ViewsLayout"]));
            }
            set
            {
                this["ViewsLayout"] = value;
            }
        }
    }
}
