   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5      "    EQLogParser.TankingBreakdown   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5
      �   � 	Resources  5         EQLogParser.ZeroConverter   ZeroConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6     5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ selectedColumns��5      
 � Tag$ TankingBreakdownColumns��6*   $��26��6H   $	��140��6T   $��0,0,4,0q�6`   ���	#FF707070��5   
   .   (EQLogParser.ComboBoxItemTemplateSelector  5         SelectedItemTemplates 5      �� 5       �� DataType%  EQLogParser.ComboBoxItemDetails"  6   .R�5      �� ��6   �� *SelectedText+5         DropDownItemTemplates 5      �� 5       "  6   .R�5!      �� $ 
Horizontal=�6   .+�5"      �� $��20��6=   	 d� 	IsChecked	 6   �� *	IsChecked+6=   �� 5#      
 J� IsHitTestVisible
 .  ��6   �� *Text+64   5$      5%      5'      5)   	   5*      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5+      -   5          Name$ dataGrid��5+      $��1��6T   &   System.Windows.Controls.DataGrid   RowHeaderWidth$ 0Q�6a      AutoGenerateColumns .     
IsReadOnly .    EnableRowVirtualization .    AlternatingRowBackground 60   Z�    Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-   
   ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6Y      
IsReadOnly .    CanUserReorder .     MinWidth$	 160Q�6�      Width5	  /System.Windows.Controls.DataGridLengthConverter$
 160*	 6�   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6   �� *Name+ 
  ClipboardContentBinding 66   Z� 6�     5.   
     PlayerTotalColumnStyle   HeaderStyle# [ 6c     RightAlignGridCellStyle   	CellStyle# [ 6�   $ % Player��6�    .  . $ 70Q�6+  $	 70*	 69   6   �� *	Percent+ �� 	Converter# [   6�   Z� 69    5/   
     CenterGridHeaderStyle# [ 6i   # [ 6�   $ Damaged��6�    .  . $ 90Q�6/  $	 90*	 6=   6   �� *Total+# [  6�   Z� 6=    50   
     DPSColumnStyle# [ 6g   # [ 6�   $	 DPS��6�    .  . $ 65Q�6"  $	 65*	 60   6   �� *DPS+# [  6�   Z� 60    51   
     SDPSColumnStyle# [ 6h   # [ 6�   $
 SDPS��6�    .  . $ 65Q�6%  $	 65*	 63   6   �� *SDPS+# [  6�   Z� 63    52   
   # [ 6p   # [ 6�   $	 Sec��6�    .  . $ 55Q�62  $	 55*	 6@   6   �� *TotalSeconds+# [  6�   Z� 6@    53   
   # [ 6h   # [ 6�   $ # Hits��6�    .  . $ 55Q�6-  $	 55*	 6;   6   �� *Hits+# [  6�   Z� 6;    54   
   # [ 6g   # [ 6�   $ Max Hit��6�    .  . $ 70Q�6-  $	 70*	 6;   6   �� *Max+# [  6�   Z� 6;    55   
   # [ 6g   # [ 6�   $ Av Hit��6�    .  . $ 60Q�6,  $	 60*	 6:   6   �� *Avg+# [  6�   Z� 6:    56   
     MeleeAccRateColumnStyle# [ 6h   # [ 6�   $ % Acc��6�    .  . $ 55Q�6.  $	 55*	 6<   6   �� *MeleeAccRate+# [   6�   Z� 6<    57   
     MeleeHitRateColumnStyle# [ 6h   # [ 6�   $ % Hit��6�    .  . $ 55Q�6.  $	 55*	 6<   6   �� *MeleeHitRate+# [   6�   Z� 6<    58   
   # [ 6j   # [ 6�   $ 	# Blocked��6�    .  . $ 70Q�62  $	 70*	 6@   6   �� *Blocks+# [  6�   Z� 6@    59   
   # [ 6j   # [ 6�   $ # Dodged��6�    .  . $ 70Q�61  $	 70*	 6?   6   �� *Dodges+# [  6�   Z� 6?    5:   
   # [ 6p   # [ 6�   $ # Invulnerable��6�    .  . $ 92Q�6=  $	 92*	 6K   6   �� *Invulnerable+# [  6�   Z� 6K    5;   
   # [ 6j   # [ 6�   $ # Missed��6�    .  . $ 65Q�61  $	 65*	 6?   6   �� *Misses+# [  6�   Z� 6?    5<   
   # [ 6k   # [ 6�   $ 	# Parried��6�    .  . $ 65Q�63  $	 65*	 6A   6   �� *	Parries+# [  6�   Z� 6A    5=   
    	 StrikethroughColumnStyle# [	 6m   # [ 6�   $ % Strikethrough��6�    .  . $ 65Q�6>  $	 65*	 6L   6   �� *StrikethroughRate+# [   6�   Z� 6L    5>   
    
 RiposteColumnStyle# [
 6g   # [ 6�   $ 	% Riposte��6�    .  . $ 80Q�6,  $	 80*	 6:   6   �� *RiposteRate+# [   6�   Z� 6:    5?   
   # [
 6g   # [ 6�   $ 	% Rampage��6�    .  . $ 84Q�6,  $	 84*	 6:   6   �� *RampageRate+# [   6�   Z� 6:  5A      5B      5C      