﻿#pragma checksum "..\..\AddEditCarWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D75C3EE0C60A9C90905DC6E06BDA01301B30E143"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Auto_Storage;
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


namespace Auto_Storage {
    
    
    /// <summary>
    /// AddEditCarWindow
    /// </summary>
    public partial class AddEditCarWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAddManuf;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbAddMark;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addCarModel;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addCarPower;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addCarAcceleration;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addCarConsumption;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addCarSpeed;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addCarPrice;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addEditCarButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddEditCarWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Auto_Storage;component/addeditcarwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditCarWindow.xaml"
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
            this.cbAddManuf = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\AddEditCarWindow.xaml"
            this.cbAddManuf.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbAddManuf_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbAddMark = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.addCarModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.addCarPower = ((System.Windows.Controls.TextBox)(target));
            
            #line 24 "..\..\AddEditCarWindow.xaml"
            this.addCarPower.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.addCarSpeed_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.addCarAcceleration = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\AddEditCarWindow.xaml"
            this.addCarAcceleration.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.addCarAcceleration_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addCarConsumption = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\AddEditCarWindow.xaml"
            this.addCarConsumption.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.addCarConsumption_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.addCarSpeed = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\AddEditCarWindow.xaml"
            this.addCarSpeed.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.addCarSpeed_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            this.addCarPrice = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\AddEditCarWindow.xaml"
            this.addCarPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.addCarSpeed_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.addEditCarButton = ((System.Windows.Controls.Button)(target));
            return;
            case 10:
            this.cancelButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\AddEditCarWindow.xaml"
            this.cancelButton.Click += new System.Windows.RoutedEventHandler(this.cancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

