﻿#pragma checksum "..\..\ViewAndColor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4FE09DE052984B7DED7431C516B823261DEA3DE903B4661C678DF55FB800765F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using calendar;


namespace calendar {
    
    
    /// <summary>
    /// ViewAndColor
    /// </summary>
    public partial class ViewAndColor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ViewAndColor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ColorComboBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ViewAndColor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ViewComboBox;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ViewAndColor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonDone;
        
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
            System.Uri resourceLocater = new System.Uri("/calendar;component/viewandcolor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ViewAndColor.xaml"
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
            
            #line 8 "..\..\ViewAndColor.xaml"
            ((calendar.ViewAndColor)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\ViewAndColor.xaml"
            ((calendar.ViewAndColor)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ColorComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\ViewAndColor.xaml"
            this.ColorComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxColorSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ViewComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 16 "..\..\ViewAndColor.xaml"
            this.ViewComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxViewSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonDone = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ViewAndColor.xaml"
            this.ButtonDone.Click += new System.Windows.RoutedEventHandler(this.ButtonDoneClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
