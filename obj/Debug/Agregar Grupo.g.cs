﻿#pragma checksum "..\..\Agregar Grupo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "64A96F44BDD24037013173E291D36B1F"
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
    /// Agregar_Grupo
    /// </summary>
    public partial class Agregar_Grupo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\Agregar Grupo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Agregar Grupo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\Agregar Grupo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnColor;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Agregar Grupo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNick;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Agregar Grupo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstGrupos;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Agregar Grupo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
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
            System.Uri resourceLocater = new System.Uri("/IDE-AR;component/agregar%20grupo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Agregar Grupo.xaml"
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
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Agregar Grupo.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.btnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\Agregar Grupo.xaml"
            this.txtNombre.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNombre_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnColor = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\Agregar Grupo.xaml"
            this.btnColor.Click += new System.Windows.RoutedEventHandler(this.btnColor_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtNick = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\Agregar Grupo.xaml"
            this.txtNick.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNick_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lstGrupos = ((System.Windows.Controls.ListView)(target));
            
            #line 72 "..\..\Agregar Grupo.xaml"
            this.lstGrupos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstGrupos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\Agregar Grupo.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.btnAgregarClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

