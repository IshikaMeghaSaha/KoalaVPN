   M S B A M L   `   `   `  ����C  ?KoalaVPN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:KoalaVPNKoalaVPN  5   	   -clr-namespace:KoalaVPN.CoreKoalaVPN.Core  5   	   7 clr-namespace:KoalaVPN.MVVM.ViewKoalaVPN.MVVM.View  5   	   A%clr-namespace:KoalaVPN.MVVM.ViewModelKoalaVPN.MVVM.ViewModel  5	   	       KoalaVPN.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:KoalaVPN     5   	   2
extensionsclr-namespace:KoalaVPN.Core     5   	   1view clr-namespace:KoalaVPN.MVVM.View     5   	   ;	viewmodel%clr-namespace:KoalaVPN.MVVM.ViewModel     5	   	     � Title$  KoalaVPN��5   	   $	��450��6   $	��800��6'    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � 
ResizeMode$ 	CanResize=�5   	   .��5      ]� ���#1E1E1E$��7q�6%   .+�5   
   �� $��28��6   ���#252525$	��Top=�62    J� InputBindings 5   
   d� 5       d� MouseAction$ 	LeftClicke�6    �� Command 5      �� *MoveWindowCommand+._�5      �  � ColumnDefinitions 5      �� 5      �� 5      $	��100 �6'   .+�5      �� $��KoalaVPN��6   
�������$��Inter)�5      $
��Bold"�5      $��Center=�5       $��Center=�5!      $��	100,0,0,0q�5"      �� 5#      $��1��6    �� Orientation$ 
Horizontal=�5$      $��Right=�5%      $��0,0,4,0q�5&      .+�5'      �� $
��🗕��6   $��0,0,0,5q�5)      ��5(      �� *MinimizeWindowCommand+5)      �� 5*      $
��🗖��6   $��0,0,0,1q�5,      ��5+      �� *MaximizeWindowCommand+5,      �� 5-      $	��✖��6   $��0,0,2,0q�5/      ��5.      �� *ShutdownWindowCommand+5/      50      51      52      �� 53   
   $��48��6   $
��Left=�6   ���#252525��55      �� 56      	 �� Triggers	 57      :� 58      
 :� RoutedEvent$
 Border.MouseEnter��6'   [�59      �� 5:   "   .��5;   &   �� .��5<   *   W�  �� TargetProperty$ (Border.Width)�6:   	 W� To 1205=   )    g� Duration$ 0:0:.1D�62   5>   '   5?   #   5A      :� 5B      $
 Border.MouseLeave��6(   [�5C      �� 5D   "   .��5E   &   �� .��5F   *   W� $ (Border.Width)�6:    605G   )   $ 0:0:.1D�61   5H   '   5I   #   5K      5M      ._�5O      �� .+�5P      	� $��Protect��6   $��16(�5Q      $��Normal"�6   
������� d� 	IsChecked$
 TrueY�5R   (      KoalaVPN.Core.Extensions   Icon$
 🛡��5T      $��7.6,3.5,8,0q�5U      ��5S      �� *ShowProtectionView+5U      	� 5V      $��Settings��6   $��16(�5W      $��Normal"�6   
�������$
 TrueY�5X   (   $	 ⚙��5Z      $��6,3.5,4.7,0q�5[      ��5Y      �� *ShowSettingsView+5[      5\      5]      �� 5^   
   ��6   �� *CurrentView+5_      5`      