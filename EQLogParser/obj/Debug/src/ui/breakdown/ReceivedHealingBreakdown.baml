   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5      *    $EQLogParser.ReceivedHealingBreakdown   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5
      �   � 	Resources  5         EQLogParser.ZeroConverter   ZeroConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6     5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ choicesList��5   "   $��0,0,4,0q�6   $��24��67   6C   �� 5      $��Stretch=�6   $��2��6.   $��2q�68   ���#1111116C   �� 5      -   5        $ selectedColumns��5      
 � Tag$% ReceivedHealingBreakdownColumns��6*   $��26��6P   $	��140��6\   $��0,0,4,0q�6h   ���	#FF707070��5   
   .   (EQLogParser.ComboBoxItemTemplateSelector  5         SelectedItemTemplates 5      �� 5       �� DataType%  EQLogParser.ComboBoxItemDetails"  6   .R�5      �� ��6   �� *SelectedText+5         DropDownItemTemplates 5!      �� 5"      "  6   .R�5#      �� $ 
Horizontal=�6   .+�5$      �� $��20��6=   	 d� 	IsChecked	 6   �� *	IsChecked+6=   �� 5%      
 J� IsHitTestVisible
 .  ��6   �� *Text+64   5&      5'      5)      5+   	   5,      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5-      -   5          Name$ dataGrid��5-      $��1��6T   &   System.Windows.Controls.DataGrid   RowHeaderWidth$ 0Q�6a      AutoGenerateColumns .     
IsReadOnly .    EnableRowVirtualization .    AlternatingRowBackground 60   Z�    Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/   
   ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6Y      
IsReadOnly .    CanUserReorder .     MinWidth$	 150Q�6�      Width5	  /System.Windows.Controls.DataGridLengthConverter$
 150*	 6�   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6   �� *Name+ 
  ClipboardContentBinding 66   Z� 6�     50   
     PlayerTotalColumnStyle   HeaderStyle# [ 6c     RightAlignGridCellStyle   	CellStyle# [ 6�   $ % Player��6�    .  . $ 70Q�6+  $	 70*	 69   6   �� *	Percent+ �� 	Converter# [   6�   Z� 69    51   
     CenterGridHeaderStyle# [ 6i   # [ 6�   $
 Heal��6�    .  . $ 90Q�6,  $	 90*	 6:   6   �� *Total+# [  6�   Z� 6:    52   
     OverHealColumnStyle# [ 6i   # [ 6�   $ Over Healed��6�    .  . $ 94Q�61  $	 94*	 6?   6   �� *Extra+# [  6�   Z� 6?    53   
     HPSColumnStyle# [ 6g   # [ 6�   $	 HPS��6�    .  . $ 60Q�6"  $	 60*	 60   6   �� *DPS+# [  6�   Z� 60    54   
     SHPSColumnStyle# [ 6h   # [ 6�   $
 SHPS��6�    .  . $ 60Q�6%  $	 60*	 63   6   �� *SDPS+# [  6�   Z� 63    55   
   # [ 6p   # [ 6�   $	 Sec��6�    .  . $ 55Q�62  $	 55*	 6@   6   �� *TotalSeconds+# [  6�   Z� 6@    56   
   # [ 6h   # [ 6�   $ # Heals��6�    .  . $ 60Q�6.  $	 60*	 6<   6   �� *Hits+# [  6�   Z� 6<    57   
   # [ 6g   # [ 6�   $ Max Heal��6�    .  . $ 70Q�6.  $	 70*	 6<   6   �� *Max+# [  6�   Z� 6<    58   
   # [ 6g   # [ 6�   $ Av Heal��6�    .  . $ 60Q�6-  $	 60*	 6;   6   �� *Avg+# [  6�   Z� 6;    59   
   # [ 6k   # [ 6�   $ Av Crit��6�    .  . $ 60Q�61  $	 60*	 6?   6   �� *	AvgCrit+# [  6�   Z� 6?    5:   
   # [ 6l   # [ 6�   $ Av Lucky��6�    .  . $ 70Q�63  $	 70*	 6A   6   �� *
AvgLucky+# [  6�   Z� 6A    5;   
     OverHealPercentColumnStyle# [ 6e   # [ 6�   $ % Over��6�    .  . $ 55Q�6/  $	 55*	 6=   6   �� *	ExtraRate+# [   6�   Z� 6=    5<   
   # [ 6d   # [ 6�   $ % Crit��6�    .  . $ 55Q�6)  $	 55*	 67   6   �� *
CritRate+# [   6�   Z� 67    5=   
   # [ 6d   # [ 6�   $ % Luck��6�    .  . $ 60Q�6)  $	 60*	 67   6   �� *
LuckRate+# [   6�   Z� 67    5>   
   # [ 6h   # [ 6�   $
 % TC��6�    .  . $ 50Q�6+  $	 50*	 69   6   �� *TwincastRate+# [   6�   Z� 69  5@      5A      5B      