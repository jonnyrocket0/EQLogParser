﻿#pragma checksum "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F5863AECED3D980F2EED0CF3D913E58A88264EA9709D1331EEC0C9A671F529C"
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
    /// TankingBreakdown
    /// </summary>
    public partial class TankingBreakdown : EQLogParser.BreakdownTable, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titleLabel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectedColumns;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/breakdown/tankingbreakdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
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
            this.selectedColumns = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
            this.selectedColumns.DropDownClosed += new System.EventHandler(this.SelectDataGridColumns);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dataGrid = ((ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid)(target));
            
            #line 43 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
            this.dataGrid.Sorting += new System.Windows.Controls.DataGridSortingEventHandler(this.CustomSorting);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\..\..\src\ui\breakdown\TankingBreakdown.xaml"
            this.dataGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.LoadingRow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

