﻿#pragma checksum "..\..\..\..\..\src\ui\log\EQLogViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6ECF09B21529EC8A9112DBC9252F1C7CF640D65205B43CFC5C1B71831FA27C67"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EQLogParser;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
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


namespace EQLogParser {
    
    
    /// <summary>
    /// EQLogViewer
    /// </summary>
    public partial class EQLogViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titleLabel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logSearch;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox logSearchModifier;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logSearch2;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox logSearchTime;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button searchButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome searchIcon;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label progress;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox logFilterModifier;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox logFilter;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer logScroller;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox logBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusCount;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontFamily;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontSize;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal EQLogParser.ColorComboBox fontFgColor;
        
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/log/eqlogviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.titleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.logSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextChange);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch.LostFocus += new System.Windows.RoutedEventHandler(this.SearchLostFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch.GotFocus += new System.Windows.RoutedEventHandler(this.SearchGotFocus);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.logSearchModifier = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.logSearch2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextChange);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch2.LostFocus += new System.Windows.RoutedEventHandler(this.SearchLostFocus);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch2.GotFocus += new System.Windows.RoutedEventHandler(this.SearchGotFocus);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logSearch2.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SearchKeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.logSearchTime = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.searchButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.searchButton.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.SearchClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.searchIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 8:
            this.progress = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.logFilterModifier = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logFilterModifier.DropDownClosed += new System.EventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            return;
            case 10:
            this.logFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logFilter.LostFocus += new System.Windows.RoutedEventHandler(this.FilterLostFocus);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logFilter.GotFocus += new System.Windows.RoutedEventHandler(this.FilterGotFocus);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logFilter.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.FilterKeyDown);
            
            #line default
            #line hidden
            
            #line 41 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FilterTextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.logScroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 12:
            this.logBox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 44 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.LogKeyDown);
            
            #line default
            #line hidden
            
            #line 44 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.logBox.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.LogMouseWheel);
            
            #line default
            #line hidden
            return;
            case 13:
            this.statusCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.fontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.fontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontFamily_Changed);
            
            #line default
            #line hidden
            return;
            case 15:
            this.fontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 54 "..\..\..\..\..\src\ui\log\EQLogViewer.xaml"
            this.fontSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSize_Changed);
            
            #line default
            #line hidden
            return;
            case 16:
            this.fontFgColor = ((EQLogParser.ColorComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
