﻿#pragma checksum "..\..\administradorCuentas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72A6786EE4996E798902AB2D00B65281142EA936"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace IDE_AR {
    
    
    /// <summary>
    /// administradorCuentas
    /// </summary>
    public partial class administradorCuentas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 49 "..\..\administradorCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReduce;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\administradorCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\administradorCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarUsuario;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\administradorCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstUsuario;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\administradorCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ModificarUsuario;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\administradorCuentas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EliminarUsuario;
        
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
            System.Uri resourceLocater = new System.Uri("/IDE-AR;component/administradorcuentas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\administradorCuentas.xaml"
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
            
            #line 9 "..\..\administradorCuentas.xaml"
            ((IDE_AR.administradorCuentas)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnReduce = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\administradorCuentas.xaml"
            this.btnReduce.Click += new System.Windows.RoutedEventHandler(this.btnReduce_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\administradorCuentas.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.btnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAgregarUsuario = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\administradorCuentas.xaml"
            this.btnAgregarUsuario.Click += new System.Windows.RoutedEventHandler(this.btnAgregarUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstUsuario = ((System.Windows.Controls.ListView)(target));
            
            #line 71 "..\..\administradorCuentas.xaml"
            this.lstUsuario.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.list1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ModificarUsuario = ((System.Windows.Controls.MenuItem)(target));
            
            #line 76 "..\..\administradorCuentas.xaml"
            this.ModificarUsuario.Click += new System.Windows.RoutedEventHandler(this.ModificarUsuario_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.EliminarUsuario = ((System.Windows.Controls.MenuItem)(target));
            
            #line 77 "..\..\administradorCuentas.xaml"
            this.EliminarUsuario.Click += new System.Windows.RoutedEventHandler(this.EliminarUsuario_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

