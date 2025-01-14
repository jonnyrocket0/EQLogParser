﻿#pragma checksum "..\..\..\..\..\src\ui\common\ChatViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37D1756441CD0FEA8F635AC68DB350A2114701716FB2066BFDB1F916615A2BF4"
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
using WPFTextBoxAutoComplete;


namespace EQLogParser {
    
    
    /// <summary>
    /// ChatViewer
    /// </summary>
    public partial class ChatViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox players;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox channels;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup calendarPopup;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar calendar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox startDate;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox endDate;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox toFilter;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fromFilter;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textFilter;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer chatScroller;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox chatBox;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock statusCount;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontFamily;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontSize;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/common/chatviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
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
            this.players = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.players.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Player_Changed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.channels = ((System.Windows.Controls.ComboBox)(target));
            
            #line 22 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.channels.DropDownClosed += new System.EventHandler(this.Channels_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 46 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Refresh_MouseClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.calendarPopup = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 6:
            this.calendar = ((System.Windows.Controls.Calendar)(target));
            
            #line 51 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.calendar.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Calendar_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.startDate = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.startDate.LostFocus += new System.Windows.RoutedEventHandler(this.DateChooser_LostFocus);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.startDate.GotFocus += new System.Windows.RoutedEventHandler(this.DateChooser_GotFocus);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.startDate.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.DateChooser_KeyDown);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.startDate.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 56 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.StartDate_MouseClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.endDate = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.endDate.LostFocus += new System.Windows.RoutedEventHandler(this.DateChooser_LostFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.endDate.GotFocus += new System.Windows.RoutedEventHandler(this.DateChooser_GotFocus);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.endDate.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.DateChooser_KeyDown);
            
            #line default
            #line hidden
            
            #line 60 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.endDate.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 61 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            ((FontAwesome.WPF.ImageAwesome)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.EndDate_MouseClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.toFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 64 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.toFilter.LostFocus += new System.Windows.RoutedEventHandler(this.ToFilter_LostFocus);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.toFilter.GotFocus += new System.Windows.RoutedEventHandler(this.ToFilter_GotFocus);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.toFilter.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.ToFilter_KeyDown);
            
            #line default
            #line hidden
            
            #line 64 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.toFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.fromFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 65 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.fromFilter.LostFocus += new System.Windows.RoutedEventHandler(this.FromFilter_LostFocus);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.fromFilter.GotFocus += new System.Windows.RoutedEventHandler(this.FromFilter_GotFocus);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.fromFilter.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.FromFilter_KeyDown);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.fromFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.textFilter = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.textFilter.LostFocus += new System.Windows.RoutedEventHandler(this.TextFilter_LostFocus);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.textFilter.GotFocus += new System.Windows.RoutedEventHandler(this.TextFilter_GotFocus);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.textFilter.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextFilter_KeyDown);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.textFilter.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Filter_TextChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.chatScroller = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 15:
            this.chatBox = ((System.Windows.Controls.RichTextBox)(target));
            
            #line 69 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.chatBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Chat_KeyDown);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.chatBox.PreviewMouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.Chat_MouseWheel);
            
            #line default
            #line hidden
            return;
            case 16:
            this.statusCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.fontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 78 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.fontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontFamily_Changed);
            
            #line default
            #line hidden
            return;
            case 18:
            this.fontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 79 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            this.fontSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSize_Changed);
            
            #line default
            #line hidden
            return;
            case 19:
            this.fontFgColor = ((EQLogParser.ColorComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 3:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseDownEvent;
            
            #line 25 "..\..\..\..\..\src\ui\common\ChatViewer.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.Channel_PreviewMouseDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

