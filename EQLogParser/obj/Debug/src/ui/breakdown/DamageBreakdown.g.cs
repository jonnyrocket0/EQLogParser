﻿#pragma checksum "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73EAC0CCF1ABEDC4A61540B20906CEC2FCBFAF6399C0533103FBDB083C097441"
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
    /// DamageBreakdown
    /// </summary>
    public partial class DamageBreakdown : EQLogParser.BreakdownTable, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label titleLabel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox showPets;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox groupDoT;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox groupDirectDamage;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox groupProcs;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectedColumns;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/breakdown/damagebreakdown.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
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
            this.showPets = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.showPets.Checked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.showPets.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            return;
            case 3:
            this.groupDoT = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.groupDoT.Checked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.groupDoT.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            return;
            case 4:
            this.groupDirectDamage = ((System.Windows.Controls.CheckBox)(target));
            
            #line 27 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.groupDirectDamage.Checked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            
            #line 27 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.groupDirectDamage.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            return;
            case 5:
            this.groupProcs = ((System.Windows.Controls.CheckBox)(target));
            
            #line 28 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.groupProcs.Checked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.groupProcs.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsChange);
            
            #line default
            #line hidden
            return;
            case 6:
            this.selectedColumns = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.selectedColumns.DropDownClosed += new System.EventHandler(this.SelectDataGridColumns);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dataGrid = ((ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid)(target));
            
            #line 50 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.dataGrid.Sorting += new System.Windows.Controls.DataGridSortingEventHandler(this.CustomSorting);
            
            #line default
            #line hidden
            
            #line 50 "..\..\..\..\..\src\ui\breakdown\DamageBreakdown.xaml"
            this.dataGrid.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.LoadingRow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

