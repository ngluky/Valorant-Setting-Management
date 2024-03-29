﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8264759768498847785D5B5FE0AECE12C79CA293"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CopySettings;
using CopySettings.MVVM.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace CopySettings {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 286 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel GENERAL;
        
        #line default
        #line hidden
        
        
        #line 332 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel CONTROL;
        
        #line default
        #line hidden
        
        
        #line 371 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Popup;
        
        #line default
        #line hidden
        
        
        #line 374 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.UserControl PopupUserControl;
        
        #line default
        #line hidden
        
        
        #line 469 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Acc;
        
        #line default
        #line hidden
        
        
        #line 509 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListAcc;
        
        #line default
        #line hidden
        
        
        #line 535 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DowAth;
        
        #line default
        #line hidden
        
        
        #line 538 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Ps1;
        
        #line default
        #line hidden
        
        
        #line 542 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Ps;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Setting Management;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.GENERAL = ((System.Windows.Controls.StackPanel)(target));
            
            #line 286 "..\..\..\MainWindow.xaml"
            this.GENERAL.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.close_Popup);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 313 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SetProfiles);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 319 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListView)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CONTROL = ((System.Windows.Controls.StackPanel)(target));
            
            #line 332 "..\..\..\MainWindow.xaml"
            this.CONTROL.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SettingUserView_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Popup = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            
            #line 372 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.close_Popup);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PopupUserControl = ((System.Windows.Controls.UserControl)(target));
            return;
            case 8:
            
            #line 382 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.close_Popup);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 417 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Import_MouseEnter);
            
            #line default
            #line hidden
            
            #line 417 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Import_MouseLeave);
            
            #line default
            #line hidden
            
            #line 417 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickImport);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 433 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Import_MouseEnter);
            
            #line default
            #line hidden
            
            #line 433 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Import_MouseLeave);
            
            #line default
            #line hidden
            
            #line 433 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickExport);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 449 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Import_MouseEnter);
            
            #line default
            #line hidden
            
            #line 449 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.Import_MouseLeave);
            
            #line default
            #line hidden
            
            #line 449 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ClickSetting);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Acc = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.ListAcc = ((System.Windows.Controls.ListView)(target));
            return;
            case 14:
            
            #line 513 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Login);
            
            #line default
            #line hidden
            return;
            case 15:
            this.DowAth = ((System.Windows.Controls.Grid)(target));
            return;
            case 16:
            this.Ps1 = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 17:
            this.Ps = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

