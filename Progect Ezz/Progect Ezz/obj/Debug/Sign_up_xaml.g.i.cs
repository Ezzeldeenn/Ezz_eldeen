﻿#pragma checksum "..\..\Sign_up_xaml.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F9F8ECF2976F466E32755C9F41ADAA0CE55F4360E5D20093B4F0884186F1FCC5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progect_Ezz;
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


namespace Progect_Ezz {
    
    
    /// <summary>
    /// Sign_up_xaml
    /// </summary>
    public partial class Sign_up_xaml : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox compo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sign_up;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox F_name;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox L_name;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mobile;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox address;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox password;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Sign_up_xaml.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button sign_up_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/Progect Ezz;component/sign_up_xaml.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sign_up_xaml.xaml"
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
            this.compo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.sign_up = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Sign_up_xaml.xaml"
            this.sign_up.Click += new System.Windows.RoutedEventHandler(this.sign_up_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.F_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.L_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.mobile = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.address = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.password = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\Sign_up_xaml.xaml"
            this.password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.password_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.sign_up_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\Sign_up_xaml.xaml"
            this.sign_up_Copy.Click += new System.Windows.RoutedEventHandler(this.sign_up_Copy_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

