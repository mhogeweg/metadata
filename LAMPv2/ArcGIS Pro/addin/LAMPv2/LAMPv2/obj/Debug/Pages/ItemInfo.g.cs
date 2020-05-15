﻿#pragma checksum "..\..\..\Pages\ItemInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BE671471A5D6734A1CEBCF52B134E8DD3C9346B3A9663DC30161BEBFE1F5F755"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ArcGIS.Desktop.Framework;
using ArcGIS.Desktop.Metadata.Editor;
using ArcGIS.Desktop.Metadata.Editor.Controls;
using ArcGIS.Desktop.Metadata.Editor.Pages;
using ArcGIS.Desktop.Metadata.Editor.Validation;
using ArcGIS.Desktop.Metadata.Pages.Converters;
using LAMPv2.Pages;
using LAMPv2.Properties;
using System;
using System.Collections;
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
    
    
    internal partial class MTK_ItemInfo : ArcGIS.Desktop.Metadata.Editor.Pages.EditorPage, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\Pages\ItemInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LAMPv2.Pages.MTK_ItemInfo ItemInfoPage;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\..\Pages\ItemInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ThumbnailImage;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Pages\ItemInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ItemInfoPage_ThumbnailDelete;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\..\Pages\ItemInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ItemInfoPage_ThumbnailUpdate;
        
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
            System.Uri resourceLocater = new System.Uri("/LAMPv2;component/pages/iteminfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ItemInfo.xaml"
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
            this.ItemInfoPage = ((LAMPv2.Pages.MTK_ItemInfo)(target));
            
            #line 27 "..\..\..\Pages\ItemInfo.xaml"
            this.ItemInfoPage.Loaded += new System.Windows.RoutedEventHandler(this.FillXml);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ThumbnailImage = ((System.Windows.Controls.Image)(target));
            
            #line 202 "..\..\..\Pages\ItemInfo.xaml"
            this.ThumbnailImage.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.UpdateThumbnail);
            
            #line default
            #line hidden
            
            #line 202 "..\..\..\Pages\ItemInfo.xaml"
            this.ThumbnailImage.Loaded += new System.Windows.RoutedEventHandler(this.LoadedThumbnailImage);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ItemInfoPage_ThumbnailDelete = ((System.Windows.Controls.Button)(target));
            
            #line 205 "..\..\..\Pages\ItemInfo.xaml"
            this.ItemInfoPage_ThumbnailDelete.Click += new System.Windows.RoutedEventHandler(this.DeleteThumbnail);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ItemInfoPage_ThumbnailUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 212 "..\..\..\Pages\ItemInfo.xaml"
            this.ItemInfoPage_ThumbnailUpdate.Click += new System.Windows.RoutedEventHandler(this.UpdateThumbnail);
            
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
            case 5:
            
            #line 335 "..\..\..\Pages\ItemInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddRecordByTagToLocal);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 414 "..\..\..\Pages\ItemInfo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddRecordByTagToLocal);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

