   M S B A M L   `   `   `  ����  F9S1.RememberMe     F9S1.RememberMe.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  Remember Me��5   	   $	��375��6   $	��524��6*    � Icon$* $/F9S1.RememberMe;component/Logo1.png��6�    � WindowStyle$ SingleBorderWindow=�6�    � 
ResizeMode$ 	CanResize=�6�    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Undo��5      5        5	   
   -   5        $
 Redo��5	      5       J� InputBindings 5      �� 5   
    �� Command$
 Undo��6   
 �� Key$ Z��6$   	 �� 	Modifiers$
	 Ctrlf�6,   �� 5   
   $
 Redo��6   $ Y��6$   $
	 Ctrlf�6,   
 � 	Resources
 5         NoMouseOverNoBorder �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName=  7System.Windows.Controls.Primitives.DataGridColumnHeader  myDataGridStyle �� 	Resources �� Color��%�  &	        '  �    'd� A    &	 �    �� 5   
   " ��6,   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��4q�5      $	 4,2q�5      
������ $ 3��5      #��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5        5!      P� 5"       �@J�IsMouseOver . . �5#   "   �� $ border��6)    � ��
 �   �6T   5$      5&      5(      5)      �� 5*   
   "  6   .�5+      ��  � ��
 ���� 6+   5,      �� 5-   
   toggle_style��" d�6&   .�5.      ��  � �� 5/      �� 50      .R�51      �� $	��img��6    $+��%/F9S1.RememberMe;component/unstar.png��6+   $��20��6Z   6g    52      P� 53       �@d�	IsChecked$
 TrueY�6H   . �54   "   �� $	 img��6)    � ��$, &/F9S1.RememberMe;component/starred.png��6L   6}   �� 55   "   $	 img��6)    � ��$ 20��6K   6X   56      58      5:      5;      �� 5<   
    5=      ���� 5>      $ 	#FF2175B7��6T   (��       6"   * SystemColors.HighlightBrushKey+)6T   5?      5@      5A      .��5B      � ��5C   
   �� 5D       �� ImageSource$_ Y/F9S1.RememberMe;component/Images/large_Abstract_Dark_Gray_Paper_Rape_Wallpaper_86207.jpg��6   .+�5F   
   �� -   5        $��helpBox��5F   M   $	��220��6   $
��Left=�6   $��	12,51,0,0q�6:   $	��Top=�6\   $	��479��6t   $y�	Collapsed=�6�   {�.  �� 
IsReadOnly . $ �� HorizontalScrollBarVisibility$ Visible=�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   �� 5G   
   -   5        $��
displayBox��5G   $   $��
12,0,12,12q�6   ���	#FFEB1919$
��Bold"�6M   $��49��6_   $��Bottom=�6k   �� 5H   
   -   5        $��inputBox��5H   &   $��
12,0,12,65q�6   
�������$��52��6�   $��Bottom=�6�    �� IsUndoEnabled .   J� Opacity$ 1Q�6
  $
��Bold"�6   �� SelectionBrush �	#FFAAAAAA.��6C  ��5I      �� 5J      .��5K   "   5L      &   System.Windows.Controls.DataGrid  5M   
   -   5        $��	dataGrid1��5M   �   #��[ 6      AutoGenerateColumns .  $��12,51,12,124q�6p   
�������
���   �   CanUserDeleteRows .      GridLinesVisibility$
  None=�6�   $ 1Q�6E  !   HeadersVisibility$! Column=�6�  ""   VerticalScrollBarVisibility$" Hidden=�6�  $#   HorizontalScrollBarVisibility$# Hidden=�6�  $��Normal"�6�  ��6X   �� ��6Q  Z� $   Columns$ 5S      4  .System.Windows.Controls.DataGridTemplateColumn  5T      ,  &System.Windows.Controls.DataGridColumn%   Header$%   ��6)   &   CellTemplate& 5U      �� 5V      .R�5W      d� -   5        ' d� 	IsChecked' 5W   +   �� ( �� Path$( 	IsStarred�5X      5Y      5[      0  *System.Windows.Controls.DataGridTextColumn  5\      $% Details��6%   )   
IsReadOnly) . *   MinWidth$	* 230Q�6d   1  +System.Windows.Controls.DataGridBoundColumn+   Binding+ 66   �� *	Details+6d     5]      $% Deadline��6%   $	* 130Q�6[   + 67   �� *DisplayDeadline+6[     5^      $% Label��6%   $* 60Q�6O   + 64   �� *Labels+6O     5`      $
%     ��6)   & 5a      �� 5b      .R�5c      �� -	   5        $��0q�5c   %   #��[" �69   
������ $��20��6�   
�������.��5d   "   �� $,��&/F9S1.RememberMe;component/archive.png��6(   5e      5f      5h        5i      $
%     ��6)   & 5j      �� 5k      .R�5l      �� -
   5        $��0q�5l   %   #��[" �69   
������ $��20��6�   
�������.��5m   "   �� $+��%/F9S1.RememberMe;component/delete.png��6(   5n      5o      5q      5s      G� 5t   
   -   5        $��passwordBox1��5t   5   $��23��6   $��	311,9,0,0q�6"   $	��Top=�6I   $y�	Collapsed=�6a   $
��Left=�6x   $	��142��6�   ��.  6�   �� 5u   
   -   5        $��passwordLabel��5u   d   $��Password��6   $��13(�6#   $
��Bold"�61   $��26��6C   $��236,5,198,0q�6O   $	��Top=�6y   $��Center=�6�   ���	#FF5BB82D$y�	Collapsed=�6�   �� 5v   
   -   5        $��userBox��5v   K   $��23��6   $
��Left=�6   $��88,9,0,0q�69   $	��Top=�6Z   $	��142��6r   $y�	Collapsed=�6~   ��.  6�   �� 5w   
   -   5        $��	userLabel��5w   |   $��Username��6   $��13(�6#   $
��Bold"�61   $��26��6C   $
��Left=�6O   $��12,6,0,0q�6j   $	��Top=�6�   $��73��6�   ���	#FF6CB548$y�	Collapsed=�6�   �� 5x   
   -   5        $��
syncButton��5x   w   #��[  6   $��40��6>   $��Right=�6J   $��0,5,6,0q�6f   $	��Top=�6�   $��40��6�   ���	#FF62B43A$
��Bold"�6�   ��5y      �� 5z      $4 ./F9S1.RememberMe;component/Images/g_normal.png��6   5|      �� 5}   
   -   5        $��
helpButton��5}   x   #��[  6   $��40��6>   $��Right=�6J   $��0,5,56,0q�6f   $	��Top=�6�   $��40��6�   ���	#FF42B72D$
��Bold"�6�   $y�Visible=�6�   ��5~      �� 5      $0 */F9S1.RememberMe;component/Images/help.png��6   5�      �� 5�   
   -   5        $��
doneButton��5�   \   $
��Done��6   $��23��6    $
��Left=�6,   $��229,288,0,0q�6G   $	��Top=�6n   $��75��6�   $y�	Collapsed=�6�   6�   5�      5�      