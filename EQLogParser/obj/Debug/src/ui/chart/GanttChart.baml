   M S B A M L   `   `   `  ����  EQLogParser    EQLogParser.GanttChart   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      .��5	      �   � RowDefinitions  5
      �� 5      $��30 �6   6$   �� 5      $
��300* �6   6&   .+�5      �� -   5         ��Name$ 	titlePane��5      $��0��6$    �� Orientation$ 
Horizontal=�61   $
��Left=�6J   .+�5      �� -   5         ��Name$ titleLabel1��5      $��0,0,0,0q�6#   ���	#FF4F9FE2$��30��6K   $��15(�6m   $
��Bold"�6{   $��5,5,0,5q�6�   ��6W   Z� 6�   �� 5      -   5        $ titleLabel2��5      $��0,0,0,0q�6#   ���	#FFCDCDCD$��30��6K   $��15(�6m   $
��Bold"�6{   $	��0,5q�6�   ��6W   Z� 6�   �� 5      -   5        $ titleLabel3��5      $��0,0,0,0q�6#   ���	#FF4F9FE2$��30��6K   $��15(�6m   $
��Bold"�6{   $��0,5,5,5q�6�   ��6W   Z� 6�   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ showSelfOnly��5       d� 	IsChecked$ FalseY�6'   $��2,0,8,0q�69   $��Center=�6J   {�.   � ToolTip$� �Include spells that only have a message that the player sees.
Meaning there is no 'lands on other' message if the spell is cast on someone else. Turning this off makes
it easier to compare spell that players have in common.��6w   $��Center=�6k  .��6�  	Self Only6�  �� 5      -   5        $ showCasterAdps��5      $
 TrueY�6)   $��2,0,8,0q�6:   $��Center=�6K   {�.  $��Center=�6x   .��6�   Caster ADPS6�   �� 5      -   5        $ showMeleeAdps��5      $
 TrueY�6(   $��2,0,8,0q�69   $��Center=�6J   {�.  $��Center=�6w   .��6�   
Melee ADPS6�   5      � 5      $��1��6     5      �� 5   
   $��25 �6   6&   �� 5   
   $��* �6   6%    � ContextMenu 5      �� 5   
   .@�5      m� -   5         m�Name$ copyOptions��5   &   {�. $��Copy As��6;   	 m� Icon	 5       "  FontAwesome.WPF.ImageAwesome  5!      $��12��6    $��12��6,   $��Center=�67   
   Icon$

 Copy=�6T      
Foreground �#5191c16`   .@�5#      m� -	   5        $ copyCsvClick��5#   (   {�. $	��CSV��6>   	 5$        5%      $��12��6"   $��12��6.   $��Center=�69   $
 Table=�6V    �#5191c16c   5'      m� 5(      -
   5        $ createImageClick��5(   (   {�. $��Image��6B   	 5)        5*      $��12��6"   $��12��6.   $��Center=�69   $
 Image=�6V    �#5191c16c   5,      5-      �� 5.      m� 5/      -   5        $ reloadClick��5/   &   {�. $��Reload ADPS Data��6;   	 50        51      $��12��6    $��12��6,   $��Center=�67   $
 Database=�6T    �#5191c16d   53      54      .+�56      �� -   5         ��Name$ headerScroller��56      $��0��6-   $��Disabled=�6:   $��Hidden=�6a   .��57   
   � -   5         �Name$ contentHeader��57      $��0��6&   ���	#FF232325  58      �� 59      $��* �6   5;      5<   	   � 5=      $��1��6   ���	#FF232325 � ColumnDefinitions 5>   
   �� 5?      $	��190 �6   $	��190��6)   $	��190��68   �� 5@      $��* �6   .+�5B   
   �� -   5        $ labelsScroller��5B      $��0��6/   ��. $��Hidden=�6W   $��Hidden=�6~   .��5C      � -   5        $ contentLabels��5C      ���	#FF232325  5D      �� 5E      $��* �6   5G      5H      �� 5I   
   -   5        $ contentScroller��5I      $��1��60   ��. $
��Auto=�6X   $
��Auto=�6}   .��5J      � -   5        $ content��5J      ���	#FF232325  5K      �� 5L      $��* �6   5N      5O      5P   	   5Q      5R      5S      