﻿#pragma checksum "..\..\..\..\..\UI\Registro\rRegistro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AB65A85DA3F407B5769F0792B2FA64ADCF9A40F7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using P1_ap1_josueosorio_20180938.UI.Registro;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace P1_ap1_josueosorio_20180938.UI.Registro {
    
    
    /// <summary>
    /// rRegistro
    /// </summary>
    public partial class rRegistro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegistroTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buscar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FechaIngreso;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegistroPersona;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegistroConcepto;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RegistroMonto;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Nuevo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Guardar;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Eliminar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/P1-ap1-josueosorio-20180938;V1.0.0.0;component/ui/registro/rregistro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RegistroTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Buscar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
            this.Buscar.Click += new System.Windows.RoutedEventHandler(this.Buscar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FechaIngreso = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.RegistroPersona = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.RegistroConcepto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.RegistroMonto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Nuevo = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
            this.Nuevo.Click += new System.Windows.RoutedEventHandler(this.Nuevo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Guardar = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
            this.Guardar.Click += new System.Windows.RoutedEventHandler(this.Guardar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Eliminar = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\..\UI\Registro\rRegistro.xaml"
            this.Eliminar.Click += new System.Windows.RoutedEventHandler(this.Eliminar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

