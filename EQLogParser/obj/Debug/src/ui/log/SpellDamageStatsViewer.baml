   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5      (    "EQLogParser.SpellDamageStatsViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      %localclr-namespace:EQLogParser  5      .��5      �   � 	Resources  5         EQLogParser.ZeroConverter   ZeroConverter'   !EQLogParser.NumberFormatConverter  NumberFormatConverter��%:   &	        &	        5      6     5      6$   5       � RowDefinitions 5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5        $��0,0,4,0q�5      $��24��6    $��30��6,   .��5   
   "  FontAwesome.WPF.ImageAwesome  $��14��6   $��30��6&   $��0,0,0,0q�61   $��Center=�6B      Icon$ Refresh=�6_    � ToolTip$ Refresh Results��6n      
Foreground �#5191c16�   5   	   �� 5      $��Stretch=�6   $��2��6.   $��2q�68   ���#1111116C   �� 5      -   5         ��Name$ showPlayers��5       d� 	IsChecked$
 TrueY�6&   $��4,0,8,0q�67   $��Center=�6H   {�. $��Center=�6t   .��6�   Verified Players6�   �� 5      -   5        	 ��Name$	 fightOption��5   "   $��0,0,0,0q�6   
 �� SelectedIndex$
 0��67   {�. $��24��6Z   .@�5   
   �� .��6   
All Fights6#   �� 5   
   .��6   Selected Fights6(   5    	   �� 5!      -   5        $	 
playerList��5!   "   $��0,0,0,0q�6   {�. $��24��6G   6S   �� 5"      -   5        $	 	spellList��5"   "   $��0,0,0,0q�6   {�. $��24��6F   6R   �� 5#      -   5        $	 typeList��5#   "   $��0,0,4,0q�6   {�. $��24��6E   6Q   5$      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5%      -   5          Name$ dataGrid��5%         RightAlignGridRowHeaderStyle&   System.Windows.Controls.DataGrid   RowHeaderStyle# [ 60      RowHeaderWidth$ 30Q�6�   $��1��6�      AutoGenerateColumns .     
IsReadOnly .    EnableRowVirtualization .    SelectionMode$ Extended=�6     AlternatingRowBackground 6o   Z�    Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'   
   ,  &System.Windows.Controls.DataGridColumn   Header$ Spell��6Z      
IsReadOnly .    CanUserReorder .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 220 6�   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6   �� *Spell+ 	  ClipboardContentBinding 67   Z� 6�     5(   
   $ Caster��6[    .  .    MinWidth$ 70Q�6�    6   �� *Caster+ 68   Z� 6�     5)   
   $
 Type��6Y    .  . $ 80Q�6�    6   �� *Type+ 66   Z� 6�     5*   
     CenterGridHeaderStyle   HeaderStyle# [ 6g     SpellGridDataCellStyle   	CellStyle# [ 6�      SortDirection$ 
DescendingX�6�   $ Av Hit��6   .  . $ 80Q�6G  $ 80 6U   6   �� *Avg+ �� 	Converter# [  6�   Z� 6U    5+   
   # [ 6g   # [ 6�   $ Max Hit��6�    .  . $ 85Q�6,  $ 85 6:   6   �� *Max+# [  6�   Z� 6:    5,   
   # [ 6i   # [ 6�   $ Total��6�    .  . $	 100Q�6,  $	 100 6;   6   �� *Total+# [  6�   Z� 6;    5-   
   # [ 6h   # [ 6�   $ # Hits��6�    .  . $ 60Q�6,  $ 60 6:   6   �� *Hits+# [  6�   Z� 6:  5/      50      51      