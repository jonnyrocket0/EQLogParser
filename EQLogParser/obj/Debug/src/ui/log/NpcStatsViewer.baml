   M S B A M L   `   `   `  ����  EQLogParser     EQLogParser.NpcStatsViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      l hActiproSoftware.DataGrid.Contrib.Wpf, Version=22.1.0.0, Culture=neutral, PublicKeyToken=36ff2196ab5654b9Edatagrid6http://schemas.actiprosoftware.com/winfx/xaml/datagrid  5      .��5
      �   � RowDefinitions  5      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5        $��0,0,4,0q�5      $��24��6    $��30��6,   .��5   
   "  FontAwesome.WPF.ImageAwesome  $��14��6   $��30��6&   $��0,0,0,0q�61   $��Center=�6B      Icon$ Refresh=�6_    � ToolTip$ Refresh Results��6n      
Foreground �#5191c16�   5   	   5      >  8ActiproSoftware.Windows.Controls.DataGrid.ThemedDataGrid  5      -   5          Name$ dataGrid��5          RightAlignGridRowHeaderStyle&   System.Windows.Controls.DataGrid   RowHeaderStyle# [  60      RowHeaderWidth$ 30Q�6�   $��1��6�   	   AutoGenerateColumns	 .  
   
IsReadOnly
 .    EnableRowVirtualization .    SelectionMode$ Single=�6     AlternatingRowBackground 6o   Z�    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5   
   ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6Y      
IsReadOnly .    CanUserReorder .    Width5  /System.Windows.Controls.DataGridLengthConverter$	 170 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6   �� *Name+   ClipboardContentBinding 66   Z� 6�     5   
     RightAlignGridCellStyle   	CellStyle# [ 6<   $ Chromatic Resist %��6�    .  .  6   �� *
LowestText+ 6q   Z� 6�     5   
   # [ 6:   $ Cold Resist %��6�    .  .  6   �� *
ColdText+ 6o   Z� 6�     5   
   # [ 6@   $ Corruption Resist %��6�    .  .  6   �� *CorruptionText+ 6u   Z� 6�     5   
   # [ 6=   $ Disease Resist %��6�    .  .  6   �� *DiseaseText+ 6r   Z� 6�     5   
   # [ 6:   $ Fire Resist %��6�    .  .  6   �� *
FireText+ 6o   Z� 6�     5   
   # [ 6;   $ Magic Resist %��6�    .  .  6   �� *	MagicText+ 6p   Z� 6�     5    
   # [ 6>   $ Physical Resist %��6�    .  .  6   �� *PhysicalText+ 6s   Z� 6�     5!   
   # [ 6<   $ Poison Resist %��6�    .  .  6   �� *
PoisonText+ 6q   Z� 6�     5"   
   # [ 6=   $ Prismatic Resist %��6�    .  .  6   �� *AverageText+ 6r   Z� 6�     5#   
   # [ 6?   $ Reflected %��6�    .  .  6   �� *ReflectedText+ 6t   Z� 6�   5%      5&      5'      