﻿#pragma checksum "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "81638AE7AC9B47B003663C7C2BEC3EE2131B454CE3767828212E052A432BD7BE"
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
    /// PageOfferOrder
    /// </summary>
    public partial class PageOfferOrder : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnumber;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomer;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbManager;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCost;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save;
        
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
            System.Uri resourceLocater = new System.Uri("/Project;component/pagem/mainpage/pageofferorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
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
            this.txtnumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
            this.txtnumber.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtnumber_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cmbCustomer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cmbManager = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Save = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\PageM\MainPage\PageOfferOrder.xaml"
            this.Save.Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

