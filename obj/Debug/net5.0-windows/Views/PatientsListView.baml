   M S B A M L   `   `   `  ����K  GHealthCareSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:HealthCareSystem.ViewsHealthCareSystem.Views  5   	   -    'HealthCareSystem.Views.PatientsListView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6views$clr-namespace:HealthCareSystem.Views     5   	     � Title$  PatientsListView��5   	   $	��450��6"   $	��800��6/   
�������.��5
      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5      �� $��0��6   $��Zoznam Pacientov��6(   $��20(�6@   �� 5      $��Nový Pacient��6   $��1��6,   $��10 0 0 0q�6<   ��6N   �� *AddNewPatient+�� 5      $��Otvor Záznam��6   $��2��6,   $��10 0 0 0q�6<   ��6N   �� *ShowPatientCard+5      �� 5   
   $��1��6   $��0 25 0 0q�6    ��62   �� *
Patients+ �� SelectedItem 6S   �� *SelectedPatient+ �� View 5      �� 5      .P�5      �� $
��Meno��6%    �� CellTemplate 5       �� 5!      .R�5"   "   �� $��Center=�6,   ��6I   �� *Name+5#      5%      �� 5'      $��
Priezvisko��6%    5(      �� 5)      .R�5*   "   �� ��6,   �� *	Surname+5+      5-      �� 5/      $��Rodné číslo��6%    50      �� 51      .R�52   "   �� ��6,   �� *IdentificationNumber+53      55      �� 57      $��Ulica a číslo��6%    58      �� 59      .R�5:   "   �� ��6,   �� *Street+5;      5=      �� 5?      $
��Obec��6%    5@      �� 5A      .R�5B   "   �� ��6,   �� *City+5C      5E      �� 5G      $
��PSČ��6%    5H      �� 5I      .R�5J   "   �� ��6,   �� *
Postcode+5K      5M      �� 5O      $��E-mail��6%    5P      �� 5Q      .R�5R   "   �� ��6,   �� *Email+5S      5U      5V      5X      5Y      5Z      