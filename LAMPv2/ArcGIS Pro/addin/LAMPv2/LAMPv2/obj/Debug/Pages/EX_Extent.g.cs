﻿#pragma checksum "..\..\..\Pages\EX_Extent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A6754984DFB21DA29C27492C041A2FF241AB77CD4B2DEB9CA3CDC53D9DEAE805"
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
    
    
    internal partial class MTK_EX_Extent : ArcGIS.Desktop.Metadata.Editor.Pages.EditorPage, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LAMPv2.Pages.MTK_EX_Extent exExtent;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EX_Extent_description;
        
        #line default
        #line hidden
        
        
        #line 334 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ex_Extent_BoundingBoxAdd;
        
        #line default
        #line hidden
        
        
        #line 343 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ex_Extent_GeographicDescriptionAdd;
        
        #line default
        #line hidden
        
        
        #line 353 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EX_Extent_TemporalPeriodAdd;
        
        #line default
        #line hidden
        
        
        #line 360 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EX_Extent_TemporalInstantAdd;
        
        #line default
        #line hidden
        
        
        #line 370 "..\..\..\Pages\EX_Extent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EX_Extent_VerticalExtentAdd;
        
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
            System.Uri resourceLocater = new System.Uri("/LAMPv2;component/pages/ex_extent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\EX_Extent.xaml"
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
            this.exExtent = ((LAMPv2.Pages.MTK_EX_Extent)(target));
            
            #line 27 "..\..\..\Pages\EX_Extent.xaml"
            this.exExtent.Loaded += new System.Windows.RoutedEventHandler(this.FillXml);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EX_Extent_description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Ex_Extent_BoundingBoxAdd = ((System.Windows.Controls.Button)(target));
            
            #line 333 "..\..\..\Pages\EX_Extent.xaml"
            this.Ex_Extent_BoundingBoxAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTag);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Ex_Extent_GeographicDescriptionAdd = ((System.Windows.Controls.Button)(target));
            
            #line 342 "..\..\..\Pages\EX_Extent.xaml"
            this.Ex_Extent_GeographicDescriptionAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTag);
            
            #line default
            #line hidden
            return;
            case 10:
            this.EX_Extent_TemporalPeriodAdd = ((System.Windows.Controls.Button)(target));
            
            #line 352 "..\..\..\Pages\EX_Extent.xaml"
            this.EX_Extent_TemporalPeriodAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTag);
            
            #line default
            #line hidden
            return;
            case 11:
            this.EX_Extent_TemporalInstantAdd = ((System.Windows.Controls.Button)(target));
            
            #line 359 "..\..\..\Pages\EX_Extent.xaml"
            this.EX_Extent_TemporalInstantAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTag);
            
            #line default
            #line hidden
            return;
            case 12:
            this.EX_Extent_VerticalExtentAdd = ((System.Windows.Controls.Button)(target));
            
            #line 369 "..\..\..\Pages\EX_Extent.xaml"
            this.EX_Extent_VerticalExtentAdd.Click += new System.Windows.RoutedEventHandler(this.AddRecordByTag);
            
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
            
            #line 175 "..\..\..\Pages\EX_Extent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 207 "..\..\..\Pages\EX_Extent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 240 "..\..\..\Pages\EX_Extent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 273 "..\..\..\Pages\EX_Extent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 318 "..\..\..\Pages\EX_Extent.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteItem);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

