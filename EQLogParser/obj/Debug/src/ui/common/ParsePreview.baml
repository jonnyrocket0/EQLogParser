   M S B A M L   `   `   `  ����  EQLogParser    EQLogParser.ParsePreview   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � ColumnDefinitions  5	      �� 5
      $	��100 �6   �� 5      $
��400* �6   .+�5      � $��0��6    � RowDefinitions 5      �� 5   
   $	��47* �6   �� 5   
   $��50 �6   .+�5      �� -   5         ��Name$ sharePlayerParseLabel��5      $��0��61   $
��Wrap=�6>   $��14(�6R   $��10,2,0,0q�6`   ���#c2c2c0No Players Selected6�   �� 5      $��1��6    �� Orientation$ Vertical=�6    .+�5   
   �� -   5        $" sharePlayerParseWarningLabel��5      $
��Wrap=�6:   $��10(�6N   $��12,0,0,4q�6\   
������$��Italic$�6�   $��12��6�   $y�Hidden=�6�   	0 / 5096�   �� 5   
   -   5         ��Name$ copyToEQButton��5      $��80��6)   $��24��64   $��	10,4,10,0q�6@   $��
Copy Parse��6S   {�.  ���	#FF5A5A5A��6�   Z� 6�   5   	   5      � 5      $��1��6    5      �� 5   
   $��30 �6   �� 5   
   $	��50* �6   .+�5      �� $��Right=�6   $��0��6/   $ 
Horizontal=�6<   .+�5   
   �� -   5         ��Name$ customParseTitle��5      $��4,0,8,0q�6,   $��Center=�6=   $��24��6_   $	��200��6k   ���	#FF7070706�   �� 5   
   -   5         ��Name$ 	parseList��5   $   $��0,0,4,0q�6   {�. $��24��6H   6T   �� 5    
   $��Stretch=�6   $��2��60   $��2q�6:   ���#1111116E   �� 5!   
   -   5         ��Name$ playerParseTextDoTotals��5!       d� 	IsChecked$
 TrueY�64   $��4,2,10,0q�6E   $��Center=�6W   $��Center=�6r   .��6�   Include Raid Total6�   �� 5"   
   -   5        $ playerParseTextDoSpecials��5"      $
 TrueY�66   $��0,2,10,0q�6G   $��Center=�6Y   $��Center=�6t   .��6�   Include Specials6�   �� 5#   
   -   5        $ playerParseTextDoTime��5#      $
 TrueY�62   $��0,2,10,0q�6C   $��Center=�6U   $��Center=�6p   .��6�   Include Time6�   �� 5$   
   -	   5        $ playerParseTextDoRank��5$      $
 TrueY�62   $��0,2,10,0q�6C   $��Center=�6U   $��Center=�6p   .��6�   Rank Players6�   5%   	   �� 5&      -
   5        $ playerParseTextBox��5&   -   $��1��6   $��1��6    	 �� TextWrapping$
	 Wrap=�6I   
 �� 
IsReadOnly
 . ���	#FF232325���#c2c2c0$��0q�6�   $��14(�6�    �� SelectionBrush �	#FF206CF16�   5'      5(      5)      