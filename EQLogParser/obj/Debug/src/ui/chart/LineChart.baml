   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5       EQLogParser   EQLogParser.LineChart   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      .��5
      � ���#232325  � RowDefinitions  5      �� 5      $��30 �6   6$   �� 5      $
��200* �6   6&   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6   $
��Left=�67   .+�5      �� -   5         ��Name$ 
titleLabel��5      $��0,0,0,0q�6"   ���	#FF4F9FE2$��15(�6J   $
��Bold"�6X   5      �� 5      $��0��6   $ 
Horizontal=�6   $��Right=�67   .+�5      �� -   5         ��Name$ petOrPlayerList��5   "   $��0,0,0,0q�6   $��24��6;   $��60��6G   6U   �� 5      -   5        $ choicesList��5   "   $��0,0,4,0q�6   $��24��67   $��60��6C   6Q   5      #   LiveCharts.Wpf.CartesianChart  5      -   5          Name$ lvcChart��5      $��1��6+   &    LiveCharts.Wpf.Charts.Base.Chart   Zoom$ X=�68   
   Pan$ X=�6A      LegendLocation$ Right=�6I    � ContextMenu 5      �� 5   
   .@�5      m� -   5        	 m�Name$	 copyOptions��5   &   {�. $��Copy As��6;   
 m� Icon
 5      "  FontAwesome.WPF.ImageAwesome  5      $��12��6    $��12��6,   $��Center=�67      Icon$
 Copy=�6T      
Foreground �#5191c16`   .@�5      m� -   5        $	 copyCsvClick��5   (   {�. $	��CSV��6>   
 5        5       $��12��6"   $��12��6.   $��Center=�69   $ Table=�6V    �#5191c16c   5"      m� 5#      -   5        $	 createImageClick��5#   (   {�. $��Image��6B   
 5$        5%      $��12��6"   $��12��6.   $��Center=�69   $ Image=�6V    �#5191c16c   5'      5(      m� 5)      -   5        $	 recenterClick��5)   &   {�. $��Recenter��6=   
 5*        5+      $��12��6    $��12��6,   $��Center=�67   $ Bullseye=�6T    �#5191c16d   5-      5.         AxisY 51   
      LiveCharts.Wpf.Axis     MinValue$ 0Q�6   6"      AxisX 54   
     $ 0Q�6   6"      Series 57   
      LiveCharts.Wpf.LineSeries     LiveCharts.Wpf.Series   Title$ Player��6      PointGeometry �	6<   59      5:      5;      