   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5          EQLogParser.LootViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      %localclr-namespace:EQLogParser  5      .��5      �   � 	Resources  5      #   EQLogParser.DateTimeConverter   DateTimeConverter��%   &	          5      6    5       � RowDefinitions 5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5        $��0,0,4,0q�5      $��24��6    $��30��6,   .��5   
   "  FontAwesome.WPF.ImageAwesome  $��14��6   $��30��6&   $��0,0,0,0q�61   $��Center=�6B      Icon$ Refresh=�6_    � ToolTip$ Refresh Results��6n      
Foreground �#5191c16�   5   	   �� 5      $��Stretch=�6   $��2��6.   $��2q�68   ���#1111116C   �� 5      -   5         ��Name$ playersList��5   "   $��4,0,0,0q�6   {�.  $��24��6I   6U   �� 5      -   5        $ 	itemsList��5   "   $��0,0,0,0q�6   {�.  $��24��6G   6S   �� 5      -   5        $ optionsList��5   "   $��0,0,4,0q�6   {�. $��24��6H   6T   5      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5      -   5          Name$ dataGrid��5         RightAlignGridRowHeaderStyle&   System.Windows.Controls.DataGrid	   RowHeaderStyle#	 [ 60   
   RowHeaderWidth$
 50Q�6�   $��1��6�      AutoGenerateColumns .     
IsReadOnly .    EnableRowVirtualization .    AlternatingRowBackground 6o   Z�  � ContextMenu 5       �� 5!   
   .@�5"      m� -   5         m�Name$ copyOptions��5"   &   {�. $��Copy As��6;    m� Icon 5#        5$      $��12��6    $��12��6,   $��Center=�67   $
 Copy=�6T    �#5191c16`   .@�5&      m� -   5        $ copyCsvClick��5&   (   {�. $��	CSV Table��6>    5'        5(      $��12��6"   $��12��6.   $��Center=�69   $ Table=�6V    �#5191c16c   5*      5+      5,         Columns 5.   
   0  *System.Windows.Controls.DataGridTextColumn  5/   
   ,  &System.Windows.Controls.DataGridColumn   Header$
 Time��6�      
IsReadOnly .    CanUserReorder .    MinWidth$ 92Q�6�      Width5  /System.Windows.Controls.DataGridLengthConverter$ 92 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Time+ �� 	Converter# [     ClipboardContentBinding 6d   Z� 6�     50   
   $ Player��6[    .  . $ 90 6�    6   �� *Player+ 68   Z� 6�     51   
   $
 Item��6Y    .  . $	 270 6�    6   �� *Item+ 66   Z� 6�   4	  .System.Windows.Controls.DataGridTemplateColumn	  52   
   $ Quantity��6!    .    SortMemberPath$ Quantity��6E    .  	  CellTemplateSelector 53      .
   (EQLogParser.LootQuantityTemplateSelector
  54      56        57   
   $	 NPC��6X    .  . $	 130 6�    6   �� *Npc+ 65   Z� 6�   59      5:      5;      