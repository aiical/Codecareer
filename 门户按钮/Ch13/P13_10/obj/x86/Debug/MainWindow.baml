   M S B A M L   `   `   `  ����
  P13_10    P13_10.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  P13_10��5   	   $	��270��6   $	��480��6%    � 	Resources 5         path E� 
StartPoint �� Point �� Size �� RotationAngle �� SweepDirection��%�  &	        B� 5   
   .��5      E� $ 15,108&�6   .��5      �� $ 215,108&�6   $ 100,80��6-   $	 180Q�6;   $ 	Clockwise=�6O   �� 5	      $ 415,108&�6   $ 100,80��6-   $	 180Q�6;   $ Counterclockwise=�6O   �� 5
      $ 215,108&�6   $ 100,80��6-   $	 180Q�6;   $ Counterclockwise=�6O   �� 5      $ 15,108&�6   $ 100,80��6,   $	 180Q�6:   $ 	Clockwise=�6N   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      �� .��5      W� 	 �� 
TargetName$		 sun��6*   
 �� TargetProperty$
 (Canvas.Left)�6F    W� From$	 115X�6p   	 W� To$	 315X�6{    g� Duration$ 0:0:3D�6�    g� AutoReverse .  g� RepeatBehavior$ Forever��6�   5      5      �� 5      .��5      �� .��5      T� $	 earth��63   $
 (Canvas.Left)�6Q   $ 0:0:6D�6{   $ Forever��6�    T� PathGeometry# [  6�    T� Source$ X=�6�   T� 5      $	 earth��63   $
 (Canvas.Top)�6Q   $ 0:0:6D�6z   $ Forever��6�   # [  6�   $ Y=�6�   5      5      5      .��5       �� -   5        $��canvas1��5       .+�5!   
   �� -   5        $	��sun��5!       �� Left$	 115��6   
 �� Top$	 100��6-   $��sun.gif��6>   �� 5"   
   -   5        $��earth��5"      $ 15��6   $	 108��6.   $��	earth.gif��6?   F� 5#   
   
���   �$	��0.5��6   #��[  65   z�5$      T� 5%       T� X$ 10Q�6%    T� Y$ 10Q�6,   5'      5(      5)      