   M S B A M L   `   `   `  ����>  :wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:wpfwpf  5   	       wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:wpf     5   	     � Title$  	ToDo List��5   	   $	��600��6   $	��850��6(    � 
ResizeMode$ NoResize=�64   .��5	      �� 
�������.+�5
   
   �� $��20q�6   
���ؿ��$��3q�63    �� CornerRadius$ 5��5   	    �� Padding$
 30 0q�6   
����+��._�5   
   �� $
��Bold"�6   $��20(�6"   
�������.��6C   	ToDo List6N   5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��tbToDoTasks��5   W   $	��350��5   :   $��Center=�6G      	RowHeight$ 50Q�5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 150 6      
IsReadOnly$
 true��6/   $��
30,21,80,0q�6C   $	��Top=�5      $	��450��6%      HeadersVisibility$	 All=�61   	   AreRowDetailsFrozen$
	 True��6I   
   CanUserResizeColumns$
 False��5      
���������5      ��  �� Path$ Tasks�5   *   �� 5      $ Vertical=�6   .+�5      �� $��	10,20,0,0q�6   $��15(�6+   
���   �.��6L   Task6R   �� 5      $ 5��6   $��1q�6*   
���   �$	��200��6R   ._�5      �� -   5        $��
tbTaskName��5      $��0q�6,   $	��200��6@   $��22��6L   $��15(�6X   
���   � �� TextWrapping$
 Wrap=�5   $   .��68   ��5      �� 5      .��5   *   5      5       �� 5"      $��	10,10,0,0q�6   $��15(�6+   
���   �.��6L   	Details6U   �� 5#      $ 5��6   $��1q�6*   
���   �$	��200��6R   ._�5$      �� -   5        $��	tbDetails��5$      $��0q�6+   $	��200��6?   $	��100��6K   $��15(�6X   
���   �$
 Wrap=�5%   $   .��68   ��5&      �� 5'      .��5(   *   5)      5*      �� 5,      $��	10,10,0,0q�6   $��15(�6+   
���   �.��6L   
Due Date6V   �� 5-      $��Center=�5.      $��Center=�5/      $ 5��50      $��1q�51      
���   �._�53      (  "System.Windows.Controls.DatePicker  -   5        $��	tbDueDate��53      
�������$	��200��6D   $��1��54      $��Center=�6!   $��22��6<   $��11(�6H   
���   �   CalendarStyle 55      �� 56       �� 
TargetType&   System.Windows.Controls.Calendar"  6    .�57      ��  �� Property � �� �� Value
 �����6;   58       � 	Resources 5:      :  4System.Windows.Controls.Primitives.DatePickerTextBox��%T   '        �� 5;      "  6    .�5<      ��  � ��
 �����6;   5=      5>      5?      5@      �� 5B      -   5        $��0,30,0,0q�5B   +   $��24��6=   $	��200��6I   
����+��
�������$��15(�6�   .��6�   Add 5C      ��%^   '��       �� 5D      " ��6    .�5E      ��  �@��CornerRadius$ 5��6=   5F      5G      5H      �� 5I      -   5        $��0,20,0,0q�5I   .   $��24��6@   $	��200��6L   
����+��
�������$��15(�6�   .��6�   Delete 5J      ��%^   '��       �� 5K      " ��6    .�5L      ��  �@��CornerRadius$ 5��6=   5M      5N      5O      5Q      5R      5S      5T      