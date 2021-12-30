﻿#pragma checksum "..\..\..\..\..\src\ui\summary\TankingSummary.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CDF3A7097C090B1EA89A8CA0111BB6BEF1D6AEF26533D04F6970FC51B56980F1"
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
    /// TankingSummary
    /// </summary>
    public partial class TankingSummary : EQLogParser.SummaryTable, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label title;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox showPets;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox damageTypes;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox classesList;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox selectedColumns;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid dataGrid;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyTankingParseToEQClick;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome copyTankingParseIcon;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyReceivedHealingParseToEQClick;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome copyReceivedHealingParseIcon;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyOptions;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem copyCsvClick;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem createImageClick;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemSetAsPet;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome setPetIcon;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemShowDefensiveTimeline;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome showDefensiveTimelineIcon;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemShowSpellCasts;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome showSpellCastsIcon;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemShowSpellCounts;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome showSpellCountsIcon;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemShowHealingBreakdown;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome showHealingBreakdownIcon;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemShowTankingBreakdown;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome showTankingBreakdownIcon;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemShowTankingLog;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome showTankingLogIcon;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemSelectAll;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome selectAllIcon;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem menuItemUnselectAll;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FontAwesome.WPF.ImageAwesome unselectAllIcon;
        
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
            System.Uri resourceLocater = new System.Uri("/EQLogParser;component/src/ui/summary/tankingsummary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
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
            this.title = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.showPets = ((System.Windows.Controls.CheckBox)(target));
            
            #line 24 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.showPets.Checked += new System.Windows.RoutedEventHandler(this.OptionsChanged);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.showPets.Unchecked += new System.Windows.RoutedEventHandler(this.OptionsChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.damageTypes = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.damageTypes.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OptionsChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.classesList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.classesList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.selectedColumns = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.selectedColumns.DropDownClosed += new System.EventHandler(this.SelectDataGridColumns);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dataGrid = ((ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid)(target));
            
            #line 52 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.copyTankingParseToEQClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 55 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.copyTankingParseToEQClick.Click += new System.Windows.RoutedEventHandler(this.CopyToEQClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.copyTankingParseIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 9:
            this.copyReceivedHealingParseToEQClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 60 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.copyReceivedHealingParseToEQClick.Click += new System.Windows.RoutedEventHandler(this.CopyReceivedHealingToEQClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.copyReceivedHealingParseIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 11:
            this.copyOptions = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 12:
            this.copyCsvClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 69 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.copyCsvClick.Click += new System.Windows.RoutedEventHandler(this.CopyCsvClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.createImageClick = ((System.Windows.Controls.MenuItem)(target));
            
            #line 74 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.createImageClick.Click += new System.Windows.RoutedEventHandler(this.CreateImageClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.menuItemSetAsPet = ((System.Windows.Controls.MenuItem)(target));
            
            #line 81 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.menuItemSetAsPet.Click += new System.Windows.RoutedEventHandler(this.SetPetClick);
            
            #line default
            #line hidden
            return;
            case 15:
            this.setPetIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 16:
            this.menuItemShowDefensiveTimeline = ((System.Windows.Controls.MenuItem)(target));
            
            #line 87 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.menuItemShowDefensiveTimeline.Click += new System.Windows.RoutedEventHandler(this.DataGridDefensiveTimelineClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.showDefensiveTimelineIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 18:
            this.menuItemShowSpellCasts = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 19:
            this.showSpellCastsIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 20:
            this.menuItemShowSpellCounts = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 21:
            this.showSpellCountsIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 22:
            this.menuItemShowHealingBreakdown = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 23:
            this.showHealingBreakdownIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 24:
            this.menuItemShowTankingBreakdown = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 25:
            this.showTankingBreakdownIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 26:
            this.menuItemShowTankingLog = ((System.Windows.Controls.MenuItem)(target));
            
            #line 113 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.menuItemShowTankingLog.Click += new System.Windows.RoutedEventHandler(this.DataGridTankingLogClick);
            
            #line default
            #line hidden
            return;
            case 27:
            this.showTankingLogIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 28:
            this.menuItemSelectAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 119 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.menuItemSelectAll.Click += new System.Windows.RoutedEventHandler(this.DataGridSelectAllClick);
            
            #line default
            #line hidden
            return;
            case 29:
            this.selectAllIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            case 30:
            this.menuItemUnselectAll = ((System.Windows.Controls.MenuItem)(target));
            
            #line 124 "..\..\..\..\..\src\ui\summary\TankingSummary.xaml"
            this.menuItemUnselectAll.Click += new System.Windows.RoutedEventHandler(this.DataGridUnselectAllClick);
            
            #line default
            #line hidden
            return;
            case 31:
            this.unselectAllIcon = ((FontAwesome.WPF.ImageAwesome)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

