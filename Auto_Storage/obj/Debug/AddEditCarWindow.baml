   M S B A M L   `   `   `  ����G  CAuto_Storage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Auto_StorageAuto_Storage  5   	   #    Auto_Storage.AddEditCarWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Auto_Storage     5   	     � Title$   ��5   	   $	��500��6   $	��400��6    � WindowStartupLocation$ CenterScreen=�6+    � 
ResizeMode$ NoResize=�6P    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ 	20 8 20 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �� .+�5   
   �� $ ��Производитель��6   �� 5   
   -   5         ��Name$ 
cbAddManuf��5       �� 
IsEditable . $
��10,0q�69   $��25��6G   6S   �� 5   
   $��
Марка��6   �� 5   
   -   5        $ 	cbAddMark��5       . $
��10,0q�68   $��25��6F   �� 5   
   $��Модель��6   �� 5   
   -   5        	 ��Name$	 addCarModel��5      $
��10,0q�6'   $��25��65   �� 5   
   $��Мощность, л.с.��6   �� 5   
   -   5        $	 addCarPower��5      $
��10,0q�6'   $��25��65   6A   �� 5   
   $��Разгон 0-100, с��6   �� 5   
   -   5        $	 addCarAcceleration��5      $
��10,0q�6.   $��25��6<   6H   �� 5   
   $-��'Расход топлива, л/100км��6   �� 5   
   -   5        $	 addCarConsumption��5      $
��10,0q�6-   $��25��6;   6G   �� 5   
   $8��2Максималькая скорость, км/ч��6   �� 5   
   -   5        $	 addCarSpeed��5      $
��10,0q�6'   $��25��65   6A   �� 5   
   $��Цена��6   �� 5    
   -   5        $	 addCarPrice��5       $
��10,0q�6'   $��25��65   6A   �� 5!   
   $��Center=�6   
 �� Orientation$
 
Horizontal=�62   .+�5"      �� -	   5         ��Name$ addEditCarButton��5"      �� 5#      -
   5        $ cancelButton��5#      $��Отмена��6+   6<   5$      5%      5&      