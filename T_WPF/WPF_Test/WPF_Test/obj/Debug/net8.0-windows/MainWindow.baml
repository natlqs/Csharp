   M S B A M L   `   `   `  ����  WPF_Test    WPF_Test.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $��14(�5        � Title$3  -WPF中文网之数据绑定 - www.wpfsoft.com��5   	   $	��350��6/   $	��500��6<    � 	Resources 5         	OnChecked �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OnUnchecked��%P  &	        &	 �     �� 5	   
   .��5
      U� $ (FrameworkElement.Width)�6,   $ _LeftBorder��6a   .\�5        $ 0:0:0.2��6'   $ 0Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ _LeftBorder��6a   .\�5        $ 0:0:0.2��6'   $	 200Q�69   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ToggleButton.Checked��6    :� 
SourceName$ 	_CheckBox��6:   .[�5      �� #��[  6   5      :� 5   
   $ ToggleButton.Unchecked��6   $ 	_CheckBox��6<   .[�5      �� #��[ 6   5      .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $
��auto �6   �� 5      .+�5!   
   �� -   5        
 ��Name$
 _LeftBorder��5!   !   $��0��6   $	��188��66   
�������._�5#      �� $	��205��6   $��0,0,0,0q�5$      $��Right=�5%      .+�5&      �� -   5        $��
tbDateText��5(      $
��Auto��5&      $��10,5,0,0q�5'      
�������$
��Bold"�5*      $��Arial)�5+      $��15(�5,      �� 5-      -   5        $��
tbTimeText��5/      $
��Auto��5-      $��10,5,0,0q�5.      ���#ffa51f$
��Bold"�51      $��Calibri)�52      $��23(�53      54      55      �� 56   
   -   5        $
 _RightBorder��56   !   $��1��6   ._�57      �� -   5         ��Name$ 	_CheckBox��57      ��58      �� 59       �� 
TargetType" ��6   .�5:      ��  �� Property � �� �� Value$ 50��62   �� 5;       � ��$ 50��63   �� 5<       � ��$	 开��64   �� 5=       � ��
 ����67   �� 5>       � �� 5?      �� 5@   "    �� 
TargetType" ��62   .R�5A   &   �� #��z��6-   #��z��6M    �� CornerRadius$ 60��6o   #��z��6�   ._�5B   *   �� #��z��64   $��Center=�6U   $��Center=�6r   5C   '   5D   #   5F       �� Triggers 5G      P� 5H       P� Property �@d�	IsChecked P� Value$
 TrueY�6;   . �5I   "   ��  � ��
 �  ��6?   �� 5J   "    � ��
 �����6?   �� 5K   "    � ��$	 关��6<   5L      :� 5M      $ 
MouseEnter��6+   [�5N   "   �� 5O   &   .��5P   *   �� .��5Q   .   W�  g� Duration$ 	0:0:0.300D�6>   $ Width�6S   	 W� To 606u   W� 5R   .   $ 	0:0:0.300D�6>   $ Height�6S    606v   5S   +   5T   '   5V      :� 5W      $ 
MouseLeave��6+   [�5X   "   �� 5Y   &   .��5Z   *   �� .��5[   .   W� $ 	0:0:0.300D�6>   $ Width�6S    506u   W� 5\   .   $ 	0:0:0.300D�6>   $ Height�6S    506v   5]   +   5^   '   5`      5b      5d      5e      5f      5h      