   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5           EQLogParser.HealingSummary   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5      �   � 	Resources  5         EQLogParser.ZeroConverter   ZeroConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6     5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   �� 5      $
��300* �6   .+�5      ��  �� Orientation$ Vertical=�6   $��0��6(   $��0q�65   .+�5      �� -   5         ��Name$ title��5      $��0,0,0,0q�6   ���	#FF4F9FE2$��30��6E   $��15(�6Q   $
��Bold"�6_   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ classesList��5   "   $��0,0,0,0q�6   $��26��67   6C   �� 5      -   5        $ selectedColumns��5      
 � Tag$ HealingSummaryColumns��6*   $��26��6F   $	��140��6R   $��0,0,4,0q�6^   ���	#FF707070��5   
   .   (EQLogParser.ComboBoxItemTemplateSelector  5         SelectedItemTemplates 5      �� 5       �� DataType%  EQLogParser.ComboBoxItemDetails"  6   .R�5      �� ��6   �� *SelectedText+5         DropDownItemTemplates 5!      �� 5"      "  6   .R�5#      �� $ 
Horizontal=�6   .+�5$      �� $��20��6=   	 d� 	IsChecked	 6   �� *	IsChecked+6=   �� 5%      
 J� IsHitTestVisible
 .  ��6   �� *Text+64   5&      5'      5)      5+   	   5,      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5-      -   5          Name$ dataGrid��5-      $��1��6T   &   System.Windows.Controls.DataGrid   CanUserResizeColumns .    CanUserResizeRows .     RowHeaderWidth$ 0Q�6�   $��0,-1,0,1q�6�      AutoGenerateColumns .     
IsReadOnly .  K� ZIndex$ -4��6�      EnableRowVirtualization .    AlternatingRowBackground 60   Z�  � ContextMenu 5.      �� 5/   
   .@�50      m� -   5         m�Name$ copyHealParseToEQClick��50   '   {�.  $��Copy Selected Parse��6G    m� Icon 51      "  FontAwesome.WPF.ImageAwesome  52      -   5          Name$ copyHealParseIcon��52       $��10��6;   $��10��6G   $��Center=�6R      Icon$
 Copy=�6o      
Foreground �	#FF4F9FE26{   54      m� 55      -   5        $  copyTopHealsParseToEQClick��55   '   {�.  $��Copy Top Heals Parse��6K    56        57      -   5        $ copyTopHealsParseIcon��57       $��10��6?   $��10��6K   $��Center=�6V   $
 Copy=�6s    �	#FF4F9FE26   59      m� 5:      -	   5        $ copyOptions��5:   '   {�.  $��Copy Summary As��6<    5;        5<      $��12��6    $��12��6,   $��Center=�67   $
 Copy=�6T    �#5191c16`   .@�5>      m� -
   5        $ copyCsvClick��5>   (   {�. $	��CSV��6>    5?        5@      $��12��6"   $��12��6.   $��Center=�69   $ Table=�6V    �#5191c16c   5B      m� 5C      -   5        $ createImageClick��5C   (   {�. $��Image��6B    5D        5E      $��12��6"   $��12��6.   $��Center=�69   $ Image=�6V    �#5191c16c   5G      5H      �� 5I      m� 5J      -   5        $ menuItemShowSpellCasts��5J      {�.  $��Spell Cast Timeline��6G    5K        5L      -   5        $ showSpellCastsIcon��5L       $��10��6<   $��10��6H   $��Center=�6S   $ ClockOutline=�6p    �	#FF4F9FE26�   5N      m� 5O      -   5        $ menuItemShowSpellCounts��5O      {�.  $��Spell Counts��6H    5P        5Q      -   5        $ showSpellCountsIcon��5Q       $��10��6=   $��10��6I   $��Center=�6T   $ 
Calculator=�6q    �	#FF4F9FE26�   5S      �� 5T      m� 5U      -   5        $ menuItemShowBreakdown��5U      {�.  $��Healing Breakdown��6F    5V        5W      -   5        $ showBreakdownIcon��5W       $��10��6;   $��10��6G   $��Center=�6R   $ Heart=�6o    �	#FF4F9FE26|   5Y      m� 5Z      -   5        $ menuItemShowHealingLog��5Z      {�.  $��Healing Log��6G    5[        5\      -   5        $ showHealingLogIcon��5\       $��10��6<   $��10��6H   $��Center=�6S   $
 File=�6p    �	#FF4F9FE26|   5^      �� 5_      m� 5`      -   5        $ menuItemSelectAll��5`      {�.  $��
Select All��6B    5a        5b      -   5        $ selectAllIcon��5b       $��10��67   $��10��6C   $��Center=�6N   $ Square=�6k    �	#FF4F9FE26y   5d      m� 5e      -   5        $ menuItemUnselectAll��5e      {�.  $��Unselect All��6D    5f        5g      -   5        $ unselectAllIcon��5g       $��10��69   $��10��6E   $��Center=�6P   $ SquareOutline=�6m    �	#FF4F9FE26�   5i      5j         Columns 5l      4  .System.Windows.Controls.DataGridTemplateColumn  5m   
   ,	  &System.Windows.Controls.DataGridColumn 	  MinWidth$ 48Q�6!    	  Width5
  /System.Windows.Controls.DataGridLengthConverter$ 48
 6/      CellTemplate 5n      �� 5o      .R�5p      �� $ 
Horizontal=�6   .+�5q      �� $��0,0,2,0q�6   $��15��6)   66   �� 5r      $��20��6    �� TextAlignment$ Right=�6'   ��6=   �� *Rank+6U   5s      5t      5v      0  *System.Windows.Controls.DataGridTextColumn  5w   
    	  Header$
 Name��6Y     	  
IsReadOnly  . ! 	  CanUserReorder! .  $ 84Q�6�   $	 84*
 6�   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 6   �� *Name+#   ClipboardContentBinding# 66   Z� 6�     5x   
     TotalColumnStyle$ 	  HeaderStyle#$ [ 6i     RightAlignGridCellStyle% 	  	CellStyle#% [ 6�   $ % Total��6�     . ! . $ 64Q�6*  $	 64*
 68  " 6   �� *PercentOfRaid+& �� 	Converter#& [  # 6�   Z� 68    5y   
     CenterGridHeaderStyle#$ [ 6i   #% [ 6�   $ Healing��6�     . ! . $ 78Q�6/  $	 78*
 6=  " 6   �� *Total+#& [ # 6�   Z� 6=    5z   
     OverHealColumnStyle#$ [ 6i   #% [ 6�   $ Over Healed��6�     . ! . $ 90Q�61  $	 90*
 6?  " 6   �� *Extra+#& [ # 6�   Z� 6?    5{   
     HPSColumnStyle#$ [ 6g   #% [ 6�   $	 HPS��6�     . ! . $ 50Q�6"  $	 50*
 60  " 6   �� *DPS+#& [ # 6�   Z� 60    5|   
     SHPSColumnStyle#$ [ 6h   #% [ 6�   $
 SHPS��6�     . ! . $ 50Q�6%  $	 50*
 63  " 6   �� *SDPS+#& [ # 6�   Z� 63    5}   
   #$ [ 6p   #% [ 6�   $	 Sec��6�     . ! . $	 54*
 62  " 6   �� *TotalSeconds+#& [ # 6�   Z� 62    5~   
   #$ [ 6h   #% [ 6�   $ # Heals��6�     . ! . $ 60Q�6.  $	 60*
 6<  " 6   �� *Hits+#& [ # 6�   Z� 6<    5   
   #$ [ 6g   #% [ 6�   $ Max Heal��6�     . ! . $ 70Q�6.  $	 70*
 6<  " 6   �� *Max+#& [ # 6�   Z� 6<    5�   
   #$ [ 6g   #% [ 6�   $ Av Heal��6�     . ! . $ 60Q�6-  $	 60*
 6;  " 6   �� *Avg+#& [ # 6�   Z� 6;    5�   
   #$ [ 6k   #% [ 6�   $ Av Crit��6�     . ! . $ 64Q�61  $	 64*
 6?  " 6   �� *	AvgCrit+#& [ # 6�   Z� 6?    5�   
   #$ [ 6l   #% [ 6�   $ Av Lucky��6�     . ! . $ 74Q�63  $	 74*
 6A  " 6   �� *
AvgLucky+#& [ # 6�   Z� 6A    5�   
     OverHealPercentColumnStyle#$ [ 6e   #% [ 6�   $ % Over��6�     . ! . $ 60Q�6/  $	 60*
 6=  " 6   �� *	ExtraRate+#& [  # 6�   Z� 6=    5�   
   #$ [ 6d   #% [ 6�   $ % Crit��6�     . ! . $ 54Q�6)  $	 54*
 67  " 6   �� *
CritRate+#& [  # 6�   Z� 67    5�   
   #$ [ 6d   #% [ 6�   $ % Luck��6�     . ! . $ 60Q�6)  $	 60*
 67  " 6   �� *
LuckRate+#& [  # 6�   Z� 67    5�   
   #$ [ 6;   ' 	  CanUserSort' . $ Class��6�     . ! . $ 90Q�6�   $	 90*
 6�   " 6   �� *	ClassName+# 6�   Z� 6�   5�      5�      5�      