   M S B A M L   `   `   `  ����G  CAuto_Storage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Auto_StorageAuto_Storage  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Auto_Storage.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Auto_Storage     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$)  #Список автомобилей��5	   	   $	��450��6$   $	��400��61   $	��900��6A   $	��850��6M    � WindowStartupLocation$ CenterScreen=�6\   
������� � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� $ ��Производитель��6   �� 5      -   5         ��Name$ cbManufacturer��5      $	��150��6/   	 �� 
IsEditable	 . 
 �� SelectedIndex$
 0��6M   6_   �� 5      $��
Марка��6   �� 5      -   5        $ cbMark��5      $	��150��6'   	 . $
 0��6E   6W   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ carsGrid��5      $��1��6%      
IsReadOnly .    AutoGenerateColumns .     MinColumnWidth$ 52Q�6`      CanUserAddRows .     SelectionMode$ Single=�6�    5         Manufacturer��%   &	        �� 5      67   5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$  Производитель��6F   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Manufacturer+6F     5#      $ 
Марка��6>    6%   �� *Mark+6>     5$      $ Модель��6?    6%   �� *Model+6?     5%      $ Мощность, л.с.��6?    6%   �� *Power+6?     5&      $ Разгон 0-100, с��6F    6%   �� *Acceleration+6F     5'      $- 'Расход топлива, л/100км��6E    6%   �� *Consumption+6E     5(      $8 2Максимальная скорость, км/ч��6B    6%   �� *
MaxSpeed+6B     5)      $ Цена��6?    6%   �� *Price+6?   5+      �� 5,   
   $��Center=�6   $��2��63   $ 
Horizontal=�6@   .+�5-      �� -   5         ��Name$ 	addButton��5-      $��Добавить��6(   6;   �� 5.      -   5        $ 
editButton��5.      $��Изменить��6)   6<   �� 5/      -   5        $ deleteButton��5/      $��Удалить��6+   6=   50      51      52      