   M S B A M L   `   `   `  ����@  <1laba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:_1laba_1laba  5   	   U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5   	       _1laba.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:_1laba     5   	   Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��0.25* �6   �� 5      .+�5   
   �� $��0��6   .+�5      ��  �� TextAlignment$ Center=�6   Время,TIME6;   �� 5      -   5         ��Name$ t_Param��5      $��5��6'   �� 5      $ Center=�6   $
��Wrap=�6/   A?Вероятность рождаемости жертв, ALPHA6i   �� 5      -   5        $ a_Param��5      $	��0,7��6'   �� 5      $ Center=�6   $
��Wrap=�6/   hfВероятность смертности жертв при встрече с хищником, BETA6~   �� 5      -   5        $ b_Param��5      $	��0,5��6'   �� 5      $ Center=�6   $
��Wrap=�6/   ZXВероятность убыли хищников при нехватке еды, GAMMA6w   �� 5      -   5        $ c_Param��5      $	��0,7��6'   �� 5      $ Center=�6   $
��Wrap=�6/   pnВероятность достаточности еды для размножения хищников, DELTA6�   �� 5      -   5        $ d_Param��5      $	��0,3��6'   �� 5      $��
/photo.PNG��6   $��99��6(   66   �� 5      -   5         ��Name$ 
Calculated��5      .��6B   Получить данные6S   5      � 5   
   $��1��6    � RowDefinitions 5      �� 5      $
��0.1* �6    �� 5       $
��0.1* �6    �� 5!      $��* �6    .+�5#      ��  �� Orientation$ 
Horizontal=�6   $��0��62   .+�5$      �� $��Center=�6   $ Center=�67   Хищники, PREDATOR6a   �� 5%      -   5        $ V_Param��5%      $	��100��6+   $��2��6:   �� 5&      $��Center=�6   $ Center=�67   $
��Wrap=�6N   Жертва, PREY6p   �� 5'      -   5        $ P_Param��5'      $	��100��6+   $��8��6:   �� 5(      $��/Uslovie.png��6   $	��335��6.   5)      �� 5+      $ 
Horizontal=�6   $��1��62   .+�5,      �� -	   5        $	��100��5,      $3��-График Добычи и Хищников��6(   6K   �� 5-      -
   5        $	��100��5-      $F��@Фазовая диграмма Хищников и добычи��6(   6U   5.      �� 5/      $��2��6/   ��6   ��  �� View 50      �� 51      .P�52      ��  �� Width$	 100��6T   	 �� DisplayMemberBinding	 6)   �� 
 �� Path$

 step�.��6`   
Время6g   �� 53      $	 200��6T   	 6)   �� $

 Prey�.��6`   Добыча6h   �� 54      $	 200��6X   	 6)   �� $
 Predator�.��6d   Хищники6m   55      57      59      5:      5;      