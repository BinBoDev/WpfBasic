   M S B A M L   `   `   `  ����@  <Proj1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Proj1Proj1  5   	       Proj1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Proj1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�6.   .+�5      �� $
��Tên��6   �� 5      $��2q�6Q   $	��100��6\   $��Center=�6h   ��6   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�6h   �� 5      $
��SĐT��6   �� 5      $��2q�6S   $	��100��6^   $��Center=�6j   ��6   �� *Number+$ PropertyChanged=�6j   �� 5      $��email��6   �� 5      $��2q�6R   $	��150��6]   $��Center=�6i   ��6   �� *Email+$ PropertyChanged=�6i   �� 5      $��2q�6   $	��Add��6?   
��� � ���6    �� *
AddCommand+6M   �� 5      $��2q�6   $
��Xóa��6?   
���  ����6    �� *
DelCommand+6M   �� 5      $��2q�6   $��Sửa��6@   
��� �����6    �� *EditCommand+6N   5      &   System.Windows.Controls.DataGrid  5   
   $��1��6      CanUserAddRows$ False��6       AutoGenerateColumns$ False��67   ��6S   �� *Users+ �� SelectedItem 6q   �� *SelectedUser+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *Name+  5      $	 Phone Number��6%   
 6;   �� *Number+  5      $	 Email��6%   
 64   �� *Email+5      5!      5"      