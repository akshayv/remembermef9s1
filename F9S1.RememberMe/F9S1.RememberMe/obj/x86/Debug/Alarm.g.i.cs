﻿#pragma checksum "..\..\..\Alarm.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A3F9E99A323DCD189D31B8D72206BFAC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
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


namespace F9S1.RememberMe {
    
    
    /// <summary>
    /// Alarm
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class Alarm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 7 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button postpone_button;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox days;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hours;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minutes;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label4;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label5;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button archive_button;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Alarm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement mediaElement1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/F9S1.RememberMe;component/alarm.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Alarm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\..\Alarm.xaml"
            ((F9S1.RememberMe.Alarm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.postpone_button = ((System.Windows.Controls.Button)(target));
            
            #line 7 "..\..\..\Alarm.xaml"
            this.postpone_button.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.days = ((System.Windows.Controls.TextBox)(target));
            
            #line 8 "..\..\..\Alarm.xaml"
            this.days.GotFocus += new System.Windows.RoutedEventHandler(this.days_GotFocus);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\Alarm.xaml"
            this.days.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.days_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.hours = ((System.Windows.Controls.TextBox)(target));
            
            #line 9 "..\..\..\Alarm.xaml"
            this.hours.GotFocus += new System.Windows.RoutedEventHandler(this.hours_GotFocus);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Alarm.xaml"
            this.hours.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.hours_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.minutes = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\Alarm.xaml"
            this.minutes.GotFocus += new System.Windows.RoutedEventHandler(this.minutes_GotFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\Alarm.xaml"
            this.minutes.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.minutes_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.label3 = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.label4 = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.label5 = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.archive_button = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Alarm.xaml"
            this.archive_button.Click += new System.Windows.RoutedEventHandler(this.button2_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.mediaElement1 = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

