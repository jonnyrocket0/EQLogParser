   M S B A M L   `   `   `  ����F  BEQLogParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EQLogParserEQLogParser  5          EQLogParser.EQLogViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      %localclr-namespace:EQLogParser  5      .��5
      �   � 	Resources  5      #   EQLogParser.DateTimeConverter   DateTimeConverter��%   &	          5      6    5       � RowDefinitions 5      �� 5      $��30 �6   �� 5      $
��300* �6   �� 5      $��20 �6   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��30��6J   $��15(�6l   $
��Bold"�6z   ��6V   Z� 6z   5      �� 5      $��0��6   $ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 	logSearch��5      $��4,0,0,0q�6#   $��24��64    � ToolTip$ Minimum of 2 Characters��6@   $��Center=�6b   ���#101010���#EEEEEE$��Italic$�6�   $	��190��6�   ���	#FF7070706A  �� 5      -   5         ��Name$ logSearchModifier��5      $��0,0,0,0q�6,   $��24��6=    �� SelectedIndex$ 0��6I   $��76��6[   $��Center=�6f   ���#101010���#EEEEEE.@�5   
   �� .��6   And6   �� 5   
   .��6   Or6   �� 5   
   .��6   	Excluding6"   5   	   �� 5      -   5        $ 
logSearch2��5      $��0,0,0,0q�6$   $��24��65   $ Minimum of 2 Characters��6A   $��Center=�6c   ���#101010���#EEEEEE$��Italic$�6�   $	��190��6�   ���	#FF7070706B  �� 5      -   5        $ logSearchTime��5      $��0,0,0,0q�6(   $��24��69   $ 0��6E   $	��100��6W   $��Center=�6c   ���#101010���#EEEEEE6�   �� 5      -   5         ��Name$ searchButton��5      $��0,0,4,0q�6%   $��24��66   $��30��6B   .��5    
   "  FontAwesome.WPF.ImageAwesome  -   5        	  Name$	 
searchIcon��5       $��14��6.   $��30��6:   $��0,0,0,0q�6E   $��Center=�6V   
   Icon$
 Search=�6s   $ 
Search Log��6�      
Foreground �#5191c16�   5!   	   �� 5"      -   5        $ progress��5"      $y�Hidden=�6    $��24��64   $��Italic$�6@   5#      �� 5$      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5%      �� -	   5        $ logFilterModifier��5%      $��4,0,0,0q�6,   $��24��6=   $ 0��6I   $��84��6[   $��Center=�6f   ���#101010���#EEEEEE.@�5&   
   �� .��6   
Includes6!   �� 5'   
   .��6   
Excludes6!   5(   	   �� 5)      -
   5        $ 	logFilter��5)      $��0,0,4,0q�6#   $��24��64   $��Center=�6@   ���#101010���#EEEEEE$��Italic$�6�   $	��190��6�   ���	#FF7070706   5*      �� 5+      -   5         ��Name$ logScroller��5+      $��1��6(   $��1q�65   
���   �.��5,      �� -   5         ��Name$ logBox��5,      $��16(�6$   $��0,0,0,0q�62   
�������* �� #IsInactiveSelectionHighlightEnabled .  �� 
IsReadOnly . $��0q�6�   ���	#FF202020��6�   Z� ��6�   Z� . �5-   
   /� 5.      5/   	   50      �� 51      $��2��6   $��11(�6   ���#151515.@�52      �� -   5         ��Name$ statusCount��52      	0 Lines60   53      �� 54      $��2��6   $ 
Horizontal=�6   $��Right=�67   $��0,0,0,0q�6T   .+�55      �� -   5        $ 
fontFamily��55      $��20��6%   $��11(�61   $	��120��6?      System.Windows.Media.Fonts   SystemFontFamilies#��Z 6K   6}   �� 56      -   5        $ fontSize��56      $��20��6#   $��11(�6/   6=      EQLogParser.ColorComboBox  57      -   5          Name$ fontFgColor��57         EQLogParser.ColorComboBox   SelectionChanged$ FontFgColor_Changed��6K   $��20��61   $��11(�6=   6K   58      59      5:      