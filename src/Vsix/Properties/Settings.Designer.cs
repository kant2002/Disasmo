﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disasmo.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PathToCoreCLR_V6 {
            get {
                return ((string)(this["PathToCoreCLR_V6"]));
            }
            set {
                this["PathToCoreCLR_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool JitDumpInsteadOfDisasm_V6 {
            get {
                return ((bool)(this["JitDumpInsteadOfDisasm_V6"]));
            }
            set {
                this["JitDumpInsteadOfDisasm_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowAsmComments_V6 {
            get {
                return ((bool)(this["ShowAsmComments_V6"]));
            }
            set {
                this["ShowAsmComments_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("DOTNET_TC_QuickJitForLoops=1;;DOTNET_JitDiffableDasm=1;;DOTNET_ReadyToRun=0;;DOTN" +
            "ET_ZapDisable=1;;DOTNET_TieredPGO=1;;DOTNET_JitDumpVerboseTrees=1")]
        public string CustomEnvVars3_V7 {
            get {
                return ((string)(this["CustomEnvVars3_V7"]));
            }
            set {
                this["CustomEnvVars3_V7"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AllowDisasmInvocations_V6 {
            get {
                return ((bool)(this["AllowDisasmInvocations_V6"]));
            }
            set {
                this["AllowDisasmInvocations_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseDotnetBuildForReload_V6 {
            get {
                return ((bool)(this["UseDotnetBuildForReload_V6"]));
            }
            set {
                this["UseDotnetBuildForReload_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RunAppMode_V6 {
            get {
                return ((bool)(this["RunAppMode_V6"]));
            }
            set {
                this["RunAppMode_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseNoRestoreFlag_V6 {
            get {
                return ((bool)(this["UseNoRestoreFlag_V6"]));
            }
            set {
                this["UseNoRestoreFlag_V6"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseCustomRuntime {
            get {
                return ((bool)(this["UseCustomRuntime"]));
            }
            set {
                this["UseCustomRuntime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseTieredJit {
            get {
                return ((bool)(this["UseTieredJit"]));
            }
            set {
                this["UseTieredJit"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\Graphviz\\bin\\dot.exe")]
        public string GraphvisDotPath {
            get {
                return ((string)(this["GraphvisDotPath"]));
            }
            set {
                this["GraphvisDotPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OPT-CHK")]
        public string FgPhase {
            get {
                return ((string)(this["FgPhase"]));
            }
            set {
                this["FgPhase"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FgEnable {
            get {
                return ((bool)(this["FgEnable"]));
            }
            set {
                this["FgEnable"] = value;
            }
        }
    }
}
