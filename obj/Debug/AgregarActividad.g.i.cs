﻿#pragma checksum "..\..\AgregarActividad.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A2AF7BB1E35B03D52F2CAF261A62357"
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
    /// AgregarActividad
    /// </summary>
    public partial class AgregarActividad : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbRaiz;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCerrar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombreActividad;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtFechaInicio;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtFechaEntrega;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnColor;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNickMateria;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\AgregarActividad.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstActividades;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\AgregarActividad.xaml"
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
            System.Uri resourceLocater = new System.Uri("/IDE-AR;component/agregaractividad.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AgregarActividad.xaml"
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
            this.tbRaiz = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.btnCerrar = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\AgregarActividad.xaml"
            this.btnCerrar.Click += new System.Windows.RoutedEventHandler(this.btnCerrar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtNombreActividad = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\AgregarActividad.xaml"
            this.txtNombreActividad.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNombreActividad_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dtFechaInicio = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.dtFechaEntrega = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnColor = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\AgregarActividad.xaml"
            this.btnColor.Click += new System.Windows.RoutedEventHandler(this.btnColor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtNickMateria = ((System.Windows.Controls.TextBox)(target));
            
            #line 83 "..\..\AgregarActividad.xaml"
            this.txtNickMateria.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtNickMateria_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lstActividades = ((System.Windows.Controls.ListView)(target));
            
            #line 90 "..\..\AgregarActividad.xaml"
            this.lstActividades.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstActividades_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\AgregarActividad.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.btnAgregarClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
