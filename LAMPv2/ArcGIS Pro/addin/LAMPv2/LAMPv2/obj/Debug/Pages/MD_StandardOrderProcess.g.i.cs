﻿#pragma checksum "..\..\..\Pages\MD_StandardOrderProcess.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1585D17037D8CFA9DB030AF5F35237BFA2BED68E443709D928DAD28CB551DB6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ArcGIS.Desktop.Metadata.Editor;
using ArcGIS.Desktop.Metadata.Editor.Controls;
using ArcGIS.Desktop.Metadata.Editor.Pages;
using ArcGIS.Desktop.Metadata.Editor.Validation;
using LAMPv2;
using LAMPv2.Pages;
using LAMPv2.Properties;
using LAMPv2.Utils;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LAMPv2.Pages {
    
    
    internal partial class MTK_MD_StandardOrderProcess : ArcGIS.Desktop.Metadata.Editor.Pages.EditorPage, System.Windows.Markup.IComponentConnector {
        
        
        #line 95 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MD_StandardOrderProcess_feesCurrency;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MD_StandardOrderProcess_fees;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AvailPeriod;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MD_StandardOrderProcess_orderingInstructions;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MD_StandardOrderProcess_turnaround;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LAMPv2;component/pages/md_standardorderprocess.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
            ((LAMPv2.Pages.MTK_MD_StandardOrderProcess)(target)).Loaded += new System.Windows.RoutedEventHandler(this.FillXml);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MD_StandardOrderProcess_feesCurrency = ((System.Windows.Controls.ComboBox)(target));
            
            #line 89 "..\..\..\Pages\MD_StandardOrderProcess.xaml"
            this.MD_StandardOrderProcess_feesCurrency.Loaded += new System.Windows.RoutedEventHandler(this.PostProcessComboBoxValues);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MD_StandardOrderProcess_fees = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AvailPeriod = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.MD_StandardOrderProcess_orderingInstructions = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.MD_StandardOrderProcess_turnaround = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

