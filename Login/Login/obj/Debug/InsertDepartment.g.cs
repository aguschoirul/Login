﻿#pragma checksum "..\..\InsertDepartment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B45FE067D9FC5FD296163C3F98145A5B94FAF86C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Login;
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


namespace Login {
    
    
    /// <summary>
    /// InsertDepartment
    /// </summary>
    public partial class InsertDepartment : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\InsertDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\InsertDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox manager;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\InsertDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveDept;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\InsertDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Department;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\InsertDepartment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete;
        
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
            System.Uri resourceLocater = new System.Uri("/Login;component/insertdepartment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\InsertDepartment.xaml"
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
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.manager = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.SaveDept = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\InsertDepartment.xaml"
            this.SaveDept.Click += new System.Windows.RoutedEventHandler(this.SaveDept_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Department = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\InsertDepartment.xaml"
            this.Department.Loaded += new System.Windows.RoutedEventHandler(this.DataDepartmenet_Loaded);
            
            #line default
            #line hidden
            
            #line 15 "..\..\InsertDepartment.xaml"
            this.Department.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.Department_SelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Delete = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\InsertDepartment.xaml"
            this.Delete.Click += new System.Windows.RoutedEventHandler(this.Delete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
