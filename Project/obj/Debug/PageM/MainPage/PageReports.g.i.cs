﻿#pragma checksum "..\..\..\..\PageM\MainPage\PageReports.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB50F14159DA1611137447F9FB199EFCCD323EB3794430042C02E76860A714BE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Project.PageM.MainPage;
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


namespace Project.PageM.MainPage {
    
    
    /// <summary>
    /// PageReports
    /// </summary>
    public partial class PageReports : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid materialStockDataGrid;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid materialStockDataGrid1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt1;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search1;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid materialMovementDataGrid;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt2;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\PageM\MainPage\PageReports.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button search2;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/pagem/mainpage/pagereports.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageM\MainPage\PageReports.xaml"
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
            this.materialStockDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.materialStockDataGrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            
            #line 32 "..\..\..\..\PageM\MainPage\PageReports.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrintStockReport);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.search = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\PageM\MainPage\PageReports.xaml"
            this.search.Click += new System.Windows.RoutedEventHandler(this.search_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txt1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.search1 = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\PageM\MainPage\PageReports.xaml"
            this.search1.Click += new System.Windows.RoutedEventHandler(this.search1_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.materialMovementDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            
            #line 60 "..\..\..\..\PageM\MainPage\PageReports.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.PrintMovementReport);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txt2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.search2 = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\PageM\MainPage\PageReports.xaml"
            this.search2.Click += new System.Windows.RoutedEventHandler(this.search2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

