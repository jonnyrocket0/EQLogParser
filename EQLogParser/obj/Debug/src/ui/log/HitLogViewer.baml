   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5          EQLogParser.HitLogViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5
      �   � 	Resources  5      #   EQLogParser.DateTimeConverter   DateTimeConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6      5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ 	groupHits��5      $y�Visible=�6$    d� 	IsChecked$
 TrueY�69   {�. $��2,0,4,0q�6[   $��Center=�6l   $��Center=�6�   .��6�   Group Actions6�   �� 5      -   5         ��Name$ spellDivider��5      $��Stretch=�6(   $��2��6D   $��2q�6N   ���#1111116Y   �� 5      -   5        $ showPets��5      $y�	Collapsed=�6#   $
 TrueY�6:   {�.  $��4,0,4,0q�6]   $��Center=�6n   $��Center=�6�   .��6�   	Show Pets6�   �� 5      -   5        $ 
petDivider��5      $��Stretch=�6&   $��2��6B   $��2q�6L   ���#1111116W   �� 5      -   5         ��Name$ typeList��5   "   $��4,0,4,0q�6   {�.  $��24��6F   6R   �� 5      -   5        $ 
actionList��5   "   $��0,0,4,0q�6   {�.  $��24��6H   6T   �� 5      -   5        $ 	actedList��5   "   $��0,0,4,0q�6   {�.  $��24��6G   6S   5      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5      -	   5          Name$ dataGrid��5         RightAlignGridRowHeaderStyle&   System.Windows.Controls.DataGrid	   RowHeaderStyle#	 [ 60   
   RowHeaderWidth$
 50Q�6�   $��1��6�      AutoGenerateColumns .     
IsReadOnly .    EnableRowVirtualization .    SelectionMode$ Extended=�6     AlternatingRowBackground 6o   Z�    Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!   
   ,  &System.Windows.Controls.DataGridColumn   Header$
 Time��6�      
IsReadOnly .    CanUserReorder .    MinWidth$ 92Q�6�      Width5  /System.Windows.Controls.DataGridLengthConverter$ 92 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Time+ �� 	Converter# [     ClipboardContentBinding 6d   Z� 6�     5"   
     CenterAlignGridCellStyle   	CellStyle# [ 6^   $ Since��6�    .  . $ 56Q�6�      MaxWidth$ 56Q�6�    6   �� *	TimeSince+ 6;   Z� 6�     5#   
   $
 Type��6Y    .  . $ 80Q�6�    6   �� *Type+ 66   Z� 6�     5$   
   $ Action��6\    .  . $ 80Q�6�    6   �� *	SubType+ 69   Z� 6�     5%   
     CenterGridHeaderStyle   HeaderStyle# [ 6i     RightAlignGridCellStyle# [ 6�   $  ��6�    . $ 90Q�6   6   �� *Total+# [  6�   Z� 6    5&   
   # [ 6m   # [ 6�   $ Over Healed��6�      
Visibility$ 	Collapsed=�6   . $ 90Q�68   6   �� *	OverTotal+# [  6�   Z� 68  4	  .System.Windows.Controls.DataGridTemplateColumn	  5'   
   $
 Hits��6!    .  .  	  CellTemplateSelector 5(      .
   (EQLogParser.CountCheckedTemplateSelector
  5)       
  Header$
 Hits��61   5+      	  5,   
   $ Critical��6!    .  .  5-      
  5.      $ Critical��61   50      	  51   
   $ Lucky��6!    .  .  52      
  53      $ Lucky��61   55      	  56   
   $ Twincast��6!    .  .  57      
  58      $ Twincast��61   5:      	  5;   
   $ Rampage��6!    .  .  5<      
  5=      $ Rampage��61   5?      	  5@   
   $ Riposte��6!    .  .  5A      
  5B      $ Riposte��61   5D      	  5E   
   $ Strikethrough��6!    .  .  5F      
  5G      $ Strikethrough��61   5I        5J   
   $  ��6Z    .  . $	 100Q�6�    6   �� *Actor+ 67   Z� 6�     5K   
   $  ��6Z    .  . $
 180* 6�    6   �� *Acted+ 67   Z� 6�   5M      5N      5O      