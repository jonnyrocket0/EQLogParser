﻿#pragma checksum "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3505E0ACEE9768D0E2B2F32828D065ACE9D9A028E2E42EF4BB25BE668A1541E5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using LiveCharts.Wpf;
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
    /// HitFreqChart
    /// </summary>
    public partial class HitFreqChart : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider pageSlider;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox playerList;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox critTypeList;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hitTypeList;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox minFreqList;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.CartesianChart lvcChart;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyOptions;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyCsvClick;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem createImageClick;
        
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/chart/hitfreqchart.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
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
            this.pageSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 16 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.pageSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.PageSliderValueChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.playerList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 17 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.playerList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PlayerListSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.critTypeList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.critTypeList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CritTypeListSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.hitTypeList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.hitTypeList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.minFreqList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.minFreqList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lvcChart = ((LiveCharts.Wpf.CartesianChart)(target));
            
            #line 22 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.lvcChart.SizeChanged += new System.Windows.SizeChangedEventHandler(this.ChartSizeChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.copyOptions = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.copyCsvClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 29 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.copyCsvClick.Click += new System.Windows.RoutedEventHandler(this.CopyCsvClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.createImageClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 34 "..\..\..\..\..\src\ui\chart\HitFreqChart.xaml"
            this.createImageClick.Click += new System.Windows.RoutedEventHandler(this.CreateImageClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
