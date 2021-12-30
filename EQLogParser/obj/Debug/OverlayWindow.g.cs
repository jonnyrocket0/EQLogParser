﻿#pragma checksum "..\..\OverlayWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B236E16902DA8C59DFFED295A162238E0BC5AF8D4DA8DCAAB46B5F32960B123B"
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


namespace EQLogParser {
    
    
    /// <summary>
    /// OverlayWindow
    /// </summary>
    public partial class OverlayWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.SolidColorBrush windowBrush;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas overlayCanvas;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel configPanel;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox maxRowsSelection;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontSizeSelection;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox showNameSelection;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox showCritRateSelection;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox damageModeSelection;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox classesList;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel savePanel;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\OverlayWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/overlaywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OverlayWindow.xaml"
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
            
            #line 11 "..\..\OverlayWindow.xaml"
            ((EQLogParser.OverlayWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.WindowClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.windowBrush = ((System.Windows.Media.SolidColorBrush)(target));
            return;
            case 3:
            this.overlayCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 15 "..\..\OverlayWindow.xaml"
            this.overlayCanvas.SizeChanged += new System.Windows.SizeChangedEventHandler(this.PanelSizeChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.configPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.maxRowsSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\OverlayWindow.xaml"
            this.maxRowsSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MaxRowsSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.fontSizeSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 25 "..\..\OverlayWindow.xaml"
            this.fontSizeSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSizeSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.showNameSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\OverlayWindow.xaml"
            this.showNameSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ShowNamesSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.showCritRateSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\OverlayWindow.xaml"
            this.showCritRateSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ShowCritRateSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.damageModeSelection = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.classesList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 51 "..\..\OverlayWindow.xaml"
            this.classesList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectPlayerClassChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.savePanel = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 12:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\OverlayWindow.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.SaveClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

