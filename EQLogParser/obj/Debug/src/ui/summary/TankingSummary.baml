   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5           EQLogParser.TankingSummary   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5      �   � 	Resources  5         EQLogParser.ZeroConverter   ZeroConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6     5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   �� 5      $
��300* �6   .+�5      ��  �� Orientation$ Vertical=�6   $��0��6(   $��0q�65   .+�5      �� -   5         ��Name$ title��5      $��0,0,0,0q�6   ���	#FF4F9FE2$��30��6E   $��15(�6Q   $
��Bold"�6_   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ showPets��5       d� 	IsChecked$
 TrueY�6#   $��2,0,4,0q�64   $��Center=�6E   {�. $��Center=�6q   .��6�   	Show Pets6�   �� 5      $��Stretch=�6   $��2��6.   $��2q�68   ���#1111116C   �� 5      -   5         ��Name$ damageTypes��5   4    �� SelectedIndex$ 0��6   $��2,0,0,0q�6#   $��85��6I   $��26��6T   .@�5   
   �� .��6   
All Damage6#   �� 5   
   .��6   Melee6   �� 5   
   .��6   	Non-Melee6"   5   	   �� 5      -   5        $ classesList��5   "   $��0,0,0,0q�6   $��26��67   6C   �� 5       -   5        $ selectedColumns��5       
 � Tag$ TankingSummaryColumns��6*   $��26��6F   $	��140��6R   $��0,0,4,0q�6^   ���	#FF707070��5!   
   .   (EQLogParser.ComboBoxItemTemplateSelector  5"      	   SelectedItemTemplates	 5#      �� 5$      
 �� DataType%  EQLogParser.ComboBoxItemDetails"
  6   .R�5%      �� ��6   �� *SelectedText+5&         DropDownItemTemplates 5(      �� 5)      "
  6   .R�5*      �� $ 
Horizontal=�6   .+�5+      �� $��20��6=    6   �� *	IsChecked+6=   �� 5,       J� IsHitTestVisible .  ��6   �� *Text+64   5-      5.      50      52   	   53      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  54      -   5          Name$ dataGrid��54      $��1��6T   &   System.Windows.Controls.DataGrid   CanUserResizeColumns .    CanUserResizeRows .     RowHeaderWidth$ 0Q�6�   $��0,-1,0,1q�6�      AutoGenerateColumns .     
IsReadOnly .  K� ZIndex$ -4��6�      EnableRowVirtualization .    AlternatingRowBackground 60   Z�  � ContextMenu 55      �� 56   
   .@�57      m� -   5         m�Name$ copyTankingParseToEQClick��57   '   {�.  $��Copy Selected Parse��6J    m� Icon 58      "  FontAwesome.WPF.ImageAwesome  59      -   5          Name$ copyTankingParseIcon��59       $��10��6>   $��10��6J   $��Center=�6U      Icon$
 Copy=�6r      
Foreground �	#FF4F9FE26~   5;      m� 5<      -	   5        $' !copyReceivedHealingParseToEQClick��5<   '   {�.  $*��$Copy Selected Received Healing Parse��6R    5=        5>      -
   5        $" copyReceivedHealingParseIcon��5>       $��10��6F   $��10��6R   $��Center=�6]   $
 Copy=�6z    �	#FF4F9FE26�   5@      m� 5A      -   5        $ copyOptions��5A   '   {�.  $��Copy Summary As��6<    5B        5C      $��12��6    $��12��6,   $��Center=�67   $
 Copy=�6T    �#5191c16`   .@�5E      m� -   5        $ copyCsvClick��5E   (   {�. $	��CSV��6>    5F        5G      $��12��6"   $��12��6.   $��Center=�69   $ Table=�6V    �#5191c16c   5I      m� 5J      -   5        $ createImageClick��5J   (   {�. $��Image��6B    5K        5L      $��12��6"   $��12��6.   $��Center=�69   $ Image=�6V    �#5191c16c   5N      5O      �� 5P      m� 5Q      -   5        $ menuItemSetAsPet��5Q      {�.  $��Set Unknown As Pet��6A    5R        5S      -   5        $ 
setPetIcon��5S       $��10��64   $��10��6@   $��Center=�6K   $	 Paw=�6h    �	#FF4F9FE26s   5U      �� 5V      m� 5W      -   5        $# menuItemShowDefensiveTimeline��5W      {�.  $��Defensive Chart��6N    5X        5Y      -   5        $ showDefensiveTimelineIcon��5Y       $��10��6C   $��10��6O   $��Center=�6Z   $
 Bars=�6w    �	#FF4F9FE26�   5[      m� 5\      -   5        $ menuItemShowSpellCasts��5\      {�.  $��Spell Cast Timeline��6G    5]        5^      -   5        $ showSpellCastsIcon��5^       $��10��6<   $��10��6H   $��Center=�6S   $ ClockOutline=�6p    �	#FF4F9FE26�   5`      m� 5a      -   5        $ menuItemShowSpellCounts��5a      {�.  $��Spell Counts��6H    5b        5c      -   5        $ showSpellCountsIcon��5c       $��10��6=   $��10��6I   $��Center=�6T   $ 
Calculator=�6q    �	#FF4F9FE26�   5e      �� 5f      m� 5g      -   5        $" menuItemShowHealingBreakdown��5g      {�.  $ ��Received Healing Breakdown��6M    5h        5i      -   5        $ showHealingBreakdownIcon��5i       $��10��6B   $��10��6N   $��Center=�6Y   $ Heart=�6v    �	#FF4F9FE26�   5k      m� 5l      -   5        $" menuItemShowTankingBreakdown��5l      {�.  $��Tanking Breakdown��6M    5m        5n      -   5        $ showTankingBreakdownIcon��5n       $��10��6B   $��10��6N   $��Center=�6Y   $ Shield=�6v    �	#FF4F9FE26�   5p      m� 5q      -   5        $ menuItemShowTankingLog��5q      {�.  $��Tanking Log��6G    5r        5s      -   5        $ showTankingLogIcon��5s       $��10��6<   $��10��6H   $��Center=�6S   $
 File=�6p    �	#FF4F9FE26|   5u      �� 5v      m� 5w      -   5        $ menuItemSelectAll��5w      {�.  $��
Select All��6B    5x        5y      -   5        $ selectAllIcon��5y       $��10��67   $��10��6C   $��Center=�6N   $ Square=�6k    �	#FF4F9FE26y   5{      m� 5|      -   5        $ menuItemUnselectAll��5|      {�.  $��Unselect All��6D    5}        5~      -   5        $ unselectAllIcon��5~       $��10��69   $��10��6E   $��Center=�6P   $ SquareOutline=�6m    �	#FF4F9FE26�   5�      5�         Columns 5�   	   4  .System.Windows.Controls.DataGridTemplateColumn  5�   
   ,	  &System.Windows.Controls.DataGridColumn 	  MinWidth$ 48Q�6!    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$ 48
 6/      CellTemplate 5�      �� 5�      .R�5�      �� $ 
Horizontal=�6   .+�5�      �� $��0,0,2,0q�6   $��15��6)   66   �� 5�      $��20��6     �� TextAlignment$  Right=�6'   ��6=   �� *Rank+6U   5�      5�      5�      0  *System.Windows.Controls.DataGridTextColumn  5�   
   ! 	  Header$
! Name��6Y   " 	  
IsReadOnly" . # 	  CanUserReorder# .  $ 90Q�6�   $	 90*
 6�   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 6   �� *Name+%   ClipboardContentBinding% 66   Z� 6�     5�   
     TotalColumnStyle& 	  HeaderStyle#& [ 6i     RightAlignGridCellStyle' 	  	CellStyle#' [ 6�   $! % Total��6�   " . # . $ 65Q�6*  $	 65*
 68  $ 6   �� *PercentOfRaid+( �� 	Converter#( [  % 6�   Z� 68    5�   
     CenterGridHeaderStyle#& [ 6i   #' [ 6�   $! Damaged��6�   " . # . $ 75Q�6/  $	 75*
 6=  $ 6   �� *Total+#( [ % 6�   Z� 6=    5�   
   #& [ 6i   #' [ 6�   $! Healed��6�   " . # . $ 75Q�6.  $	 75*
 6<  $ 6   �� *Extra+#( [ % 6�   Z� 6<    5�   
     DPSColumnStyle#& [ 6g   #' [ 6�   $	! DPS��6�   " . # . $ 60Q�6"  $	 60*
 60  $ 6   �� *DPS+#( [ % 6�   Z� 60    5�   
     SDPSColumnStyle#& [ 6h   #' [ 6�   $
! SDPS��6�   " . # . $ 60Q�6%  $	 60*
 63  $ 6   �� *SDPS+#( [ % 6�   Z� 63    5�   
   #& [ 6p   #' [ 6�   $	! Sec��6�   " . # . $ 55Q�62  $	 55*
 6@  $ 6   �� *TotalSeconds+#( [ % 6�   Z� 6@    5�   
   #& [ 6h   #' [ 6�   $! # Hits��6�   " . # . $ 60Q�6-  $	 60*
 6;  $ 6   �� *Hits+#( [ % 6�   Z� 6;    5�   
   #& [ 6g   #' [ 6�   $! Max Hit��6�   " . # . $ 70Q�6-  $	 70*
 6;  $ 6   �� *Max+#( [ % 6�   Z� 6;    5�   
   #& [ 6g   #' [ 6�   $! Av Hit��6�   " . # . $ 65Q�6,  $	 65*
 6:  $ 6   �� *Avg+#( [ % 6�   Z� 6:    5�   
     MeleeAccRateColumnStyle#& [ 6h   #' [ 6�   $! % Acc��6�   " . # . $ 55Q�6.  $	 55*
 6<  $ 6   �� *MeleeAccRate+#( [  % 6�   Z� 6<    5�   
     MeleeHitRateColumnStyle#& [ 6h   #' [ 6�   $! % Hit��6�   " . # . $ 55Q�6.  $	 55*
 6<  $ 6   �� *MeleeHitRate+#( [  % 6�   Z� 6<    5�   
    	 StrikethroughColumnStyle#& [	 6m   #' [ 6�   $! % Strikethrough��6�   " . # . $ 65Q�6>  $	 65*
 6L  $ 6   �� *StrikethroughRate+#( [  % 6�   Z� 6L    5�   
    
 RiposteColumnStyle#& [
 6g   #' [ 6�   $! 	% Riposte��6�   " . # . $ 80Q�6,  $	 80*
 6:  $ 6   �� *RiposteRate+#( [  % 6�   Z� 6:    5�   
     RampageColumnStyle#& [ 6g   #' [ 6�   $! 	% Rampage��6�   " . # . $ 85Q�6,  $	 85*
 6:  $ 6   �� *RampageRate+#( [  % 6�   Z� 6:    5�   
   #& [ 6;   ) 	  CanUserSort) . $! Class��6�   " . # . $ 90Q�6�   $	 90*
 6�   $ 6   �� *	ClassName+% 6�   Z� 6�   5�      5�      5�      