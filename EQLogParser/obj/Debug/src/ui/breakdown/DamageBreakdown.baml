   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5      !    EQLogParser.DamageBreakdown   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5
      �   � 	Resources  5         EQLogParser.ZeroConverter   ZeroConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6     5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ showPets��5       d� 	IsChecked$
 TrueY�6#   $��2,0,4,0q�64   $��Center=�6E   {�.  $��Center=�6r   .��6�   	Show Pets6�   �� 5      $��Stretch=�6   $��2��6.   $��2q�68   ���#1111116C   �� 5      $��0,0,4,2q�6   $��Center=�6   $��Italic$�6:   $��14(�6M   .��6[   
Combine:6e   �� 5      -   5        $ groupDoT��5      $
 TrueY�6#   $��2,0,8,0q�64   $��Center=�6E   {�.  $��Center=�6r   .��6�   DoTs6�   �� 5      -   5        $ groupDirectDamage��5      $
 TrueY�6,   $��2,0,8,0q�6=   $��Center=�6N   {�.  $��Center=�6{   .��6�   Direct Damage6�   �� 5      -   5        $ 
groupProcs��5      $
 TrueY�6%   $��2,0,8,0q�66   $��Center=�6G   {�.  $��Center=�6t   .��6�   Procs6�   �� 5      $��Stretch=�6   $��2��6.   $��2q�68   ���#1111116C   �� 5      -   5         ��Name$ selectedColumns��5      
 � Tag$ DamageBreakdownColumns��6*   $��26��6G   $	��140��6S   $��0,0,4,0q�6_   ���	#FF707070��5   
   .   (EQLogParser.ComboBoxItemTemplateSelector  5          SelectedItemTemplates 5!      �� 5"      	 �� DataType%  EQLogParser.ComboBoxItemDetails"	  6   .R�5#      �� ��6   �� *SelectedText+5$      
   DropDownItemTemplates
 5&      �� 5'      "	  6   .R�5(      �� $ 
Horizontal=�6   .+�5)      �� $��20��6=    6   �� *	IsChecked+6=   �� 5*       J� IsHitTestVisible .  ��6   �� *Text+64   5+      5,      5.      50   	   51      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  52      -   5          Name$ dataGrid��52       $��1��6V   &   System.Windows.Controls.DataGrid   RowHeaderWidth$ 0Q�6c      AutoGenerateColumns .     
IsReadOnly .    EnableRowVirtualization .    AlternatingRowBackground 62   Z�    Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54   
   ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6Y      
IsReadOnly .    CanUserReorder .     MinWidth$	 160Q�6�      Width5	  /System.Windows.Controls.DataGridLengthConverter$
 160*	 6�   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6   �� *Name+ 
  ClipboardContentBinding 66   Z� 6�     55   
     PlayerTotalColumnStyle   HeaderStyle# [ 6c     RightAlignGridCellStyle   	CellStyle# [ 6�   $ % Player��6�    .  . $ 70Q�6+  $	 70*	 69   6   �� *	Percent+ �� 	Converter# [   6�   Z� 69    56   
     CenterGridHeaderStyle# [ 6i   # [ 6�   $ Damage��6�    .  . $ 90Q�6.  $	 90*	 6<   6   �� *Total+# [  6�   Z� 6<    57   
      
Visibility$ Hidden=�6   # [ 6�   # [ 6�   $ Assassinate��6   .  . $ 90Q�6J  $	 90*	 6X   61   �� *
TotalAss+# [  6�   Z� 6X    58   
   $ Hidden=�6   # [ 6�   # [ 6�   $ Finishing Blow��6   .  . $	 110Q�6S  $
 110*	 6b   61   �� *TotalFinishing+# [  6�   Z� 6b    59   
   $ Hidden=�6   # [ 6�   # [ 6�   $ Headshot��6   .  . $ 90Q�6H  $	 90*	 6V   61   �� *	TotalHead+# [  6�   Z� 6V    5:   
   # [ 6p   # [ 6�   $ Riposte��6�    .  . $ 90Q�66  $	 90*	 6D   6   �� *TotalRiposte+# [  6�   Z� 6D    5;   
   $ Hidden=�6   # [ 6�   # [ 6�   $ Slay Undead��6   .  . $ 90Q�6K  $	 90*	 6Y   61   �� *	TotalSlay+# [  6�   Z� 6Y    5<   
     DPSColumnStyle# [ 6g   # [ 6�   $	 DPS��6�    .  . $ 65Q�6"  $	 65*	 60   6   �� *DPS+# [  6�   Z� 60    5=   
     SDPSColumnStyle# [ 6h   # [ 6�   $
 SDPS��6�    .  . $ 65Q�6%  $	 65*	 63   6   �� *SDPS+# [  6�   Z� 63    5>   
   # [ 6p   # [ 6�   $	 Sec��6�    .  . $ 55Q�62  $	 55*	 6@   6   �� *TotalSeconds+# [  6�   Z� 6@    5?   
   # [ 6h   # [ 6�   $ # Hits��6�    .  . $ 55Q�6-  $	 55*	 6;   6   �� *Hits+# [  6�   Z� 6;    5@   
   # [ 6g   # [ 6�   $ Max Hit��6�    .  . $ 70Q�6-  $	 70*	 6;   6   �� *Max+# [  6�   Z� 6;    5A   
   # [ 6g   # [ 6�   $ Av Hit��6�    .  . $ 60Q�6,  $	 60*	 6:   6   �� *Avg+# [  6�   Z� 6:    5B   
   # [ 6k   # [ 6�   $ Av Crit��6�    .  . $ 60Q�61  $	 60*	 6?   6   �� *	AvgCrit+# [  6�   Z� 6?    5C   
   # [ 6l   # [ 6�   $ Av Lucky��6�    .  . $ 70Q�63  $	 70*	 6A   6   �� *
AvgLucky+# [  6�   Z� 6A    5D   
   $ Hidden=�6     AvgNonTwincastColumnStyle# [ 6�   # [ 6�   $ 	Av Non-TC��6   .  . $ 70Q�6R  $	 70*	 6`   61   �� *AvgNonTwincast+# [  6�   Z� 6`    5E   
     MeleeAccRateColumnStyle# [ 6h   # [ 6�   $ % Acc��6�    .  . $ 55Q�6.  $	 55*	 6<   6   �� *MeleeAccRate+# [   6�   Z� 6<    5F   
    	 MeleeHitRateColumnStyle# [	 6h   # [ 6�   $ % Hit��6�    .  . $ 55Q�6.  $	 55*	 6<   6   �� *MeleeHitRate+# [   6�   Z� 6<    5G   
   $ Hidden=�6   # [ 6~   # [ 6�   $ 	# Blocked��6   .  . $ 70Q�6F  $	 70*	 6T   61   �� *Blocks+# [  6�   Z� 6T    5H   
   $ Hidden=�6   # [ 6~   # [ 6�   $ # Dodged��6   .  . $ 70Q�6E  $	 70*	 6S   61   �� *Dodges+# [  6�   Z� 6S    5I   
   $ Hidden=�6   # [ 6�   # [ 6�   $ # Invulnerable��6   .  . $ 92Q�6Q  $	 92*	 6_   61   �� *Invulnerable+# [  6�   Z� 6_    5J   
   $ Hidden=�6   # [ 6~   # [ 6�   $ # Missed��6   .  . $ 65Q�6E  $	 65*	 6S   61   �� *Misses+# [  6�   Z� 6S    5K   
   $ Hidden=�6   # [ 6   # [ 6�   $ 	# Parried��6   .  . $ 65Q�6G  $	 65*	 6U   61   �� *	Parries+# [  6�   Z� 6U    5L   
   $ Hidden=�6   # [ 6�   # [ 6�   $
 # TC��6   .  . $ 50Q�6G  $	 50*	 6U   61   �� *TwincastHits+# [  6�   Z� 6U    5M   
   $ Hidden=�6   # [ 6   # [ 6�   $ 	# Resists��6   .  . $ 65Q�6G  $	 65*	 6U   61   �� *	Resists+# [  6�   Z� 6U    5N   
    
 CritColumnStyle# [
 6d   # [ 6�   $ % Crit��6�    .  . $ 55Q�6#  $	 55*	 61   6   �� *
CritRate+# [   6�   Z� 61    5O   
   # [ 6d   # [ 6�   $ % Luck��6�    .  . $ 60Q�6)  $	 60*	 67   6   �� *
LuckRate+# [   6�   Z� 67    5P   
   $ Hidden=�6   # [ 6}   # [ 6�   $ % Double Bow��6
   .  . $ 95Q�6H  $	 95*	 6V   61   �� *DoubleBowRate+# [   6�   Z� 6V    5Q   
   $ Hidden=�6   # [ 6z   # [ 6�   $ % Flurry��6   .  . $ 65Q�6A  $	 65*	 6O   61   �� *
FlurryRate+# [   6�   Z� 6O    5R   
   # [ 6h   # [ 6�   $
 % TC��6�    .  . $ 50Q�6+  $	 50*	 69   6   �� *TwincastRate+# [   6�   Z� 69    5S   
   $ Hidden=�6   # [ 6z   # [ 6�   $ % Resist��6   .  . $ 65Q�6A  $	 65*	 6O   61   �� *
ResistRate+# [   6�   Z� 6O  5U      5V      5W      