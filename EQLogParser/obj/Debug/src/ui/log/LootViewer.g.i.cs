﻿#pragma checksum "..\..\..\..\..\src\ui\log\LootViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "96EFCD4422A43B768977ADBBA3E1ABC42746EAF30E3ED2789462826C95FE84CC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ActiproSoftware.Products.DataGrid.Contrib;
using ActiproSoftware.Windows.Controls.DataGrid;
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
    /// LootViewer
    /// </summary>
    public partial class LootViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titleLabel;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox playersList;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox itemsList;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox optionsList;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyOptions;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyCsvClick;
        
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/log/lootviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
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
            this.titleLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            
            #line 23 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
            ((System.Windows.Controls.Button)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.RefreshMouseClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.playersList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
            this.playersList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OptionsChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.itemsList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
            this.itemsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OptionsChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.optionsList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
            this.optionsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OptionsChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dataGrid = ((ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid)(target));
            
            #line 31 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
            this.dataGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.LoadingRow);
            
            #line default
            #line hidden
            return;
            case 7:
            this.copyOptions = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 8:
            this.copyCsvClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 38 "..\..\..\..\..\src\ui\log\LootViewer.xaml"
            this.copyCsvClick.Click += new System.Windows.RoutedEventHandler(this.CopyCsvClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
