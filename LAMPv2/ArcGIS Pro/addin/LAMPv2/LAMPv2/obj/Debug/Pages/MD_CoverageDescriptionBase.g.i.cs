﻿#pragma checksum "..\..\..\Pages\MD_CoverageDescriptionBase.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9F9D728E87CD563C4093073F882B829EDF24293D134B8A2C855EBC5627D9BD9"
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
using ArcGIS.Desktop.Metadata.Editor.Pages;
using ArcGIS.Desktop.Metadata.Editor.Validation;
using ArcGIS.Desktop.Metadata.Pages.Converters;
using LAMPv2.Pages;
using LAMPv2.Properties;
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
    
    
    internal partial class MTK_MD_CoverageDescriptionBase : ArcGIS.Desktop.Metadata.Editor.Pages.EditorPage, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 113 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MD_CoverageDescription_attributeDescription;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox MD_CoverageDescription_contentType;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MD_CoverageDescription_RangeDimensionAdd;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MD_CoverageDescription_BandAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/LAMPv2;component/pages/md_coveragedescriptionbase.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.MD_CoverageDescription_attributeDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.MD_CoverageDescription_contentType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 117 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
            this.MD_CoverageDescription_contentType.Loaded += new System.Windows.RoutedEventHandler(this.PostProcessComboBoxValues);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MD_CoverageDescription_RangeDimensionAdd = ((System.Windows.Controls.Button)(target));
            
            #line 191 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
            this.MD_CoverageDescription_RangeDimensionAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTagToLocal);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MD_CoverageDescription_BandAdd = ((System.Windows.Controls.Button)(target));
            
            #line 200 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
            this.MD_CoverageDescription_BandAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTagToLocal);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 146 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 176 "..\..\..\Pages\MD_CoverageDescriptionBase.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
