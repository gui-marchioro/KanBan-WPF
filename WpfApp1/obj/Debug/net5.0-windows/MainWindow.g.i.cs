﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "175B477F5E08E872751F4E872F97CF28294F545D"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTask;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAddTask;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btRemoveTask;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btNotStarted;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btInProgress;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCompleted;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbNotStarted;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbInProgress;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbCompleted;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbTask = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btAddTask = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\MainWindow.xaml"
            this.btAddTask.Click += new System.Windows.RoutedEventHandler(this.btAddTaskHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btRemoveTask = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\MainWindow.xaml"
            this.btRemoveTask.Click += new System.Windows.RoutedEventHandler(this.btRemoveTaskHandler);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btNotStarted = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\MainWindow.xaml"
            this.btNotStarted.Click += new System.Windows.RoutedEventHandler(this.btNotStartedHandler);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btInProgress = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\MainWindow.xaml"
            this.btInProgress.Click += new System.Windows.RoutedEventHandler(this.btInProgressHandler);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btCompleted = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\MainWindow.xaml"
            this.btCompleted.Click += new System.Windows.RoutedEventHandler(this.btCompletedHandler);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbNotStarted = ((System.Windows.Controls.ListBox)(target));
            
            #line 50 "..\..\..\MainWindow.xaml"
            this.lbNotStarted.IsMouseCapturedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.lbNotStartedUnselect);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbInProgress = ((System.Windows.Controls.ListBox)(target));
            
            #line 53 "..\..\..\MainWindow.xaml"
            this.lbInProgress.IsMouseCapturedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.lbInProgressUnselect);
            
            #line default
            #line hidden
            return;
            case 9:
            this.lbCompleted = ((System.Windows.Controls.ListBox)(target));
            
            #line 56 "..\..\..\MainWindow.xaml"
            this.lbCompleted.IsMouseCapturedChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.lbCompletedUnselect);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

