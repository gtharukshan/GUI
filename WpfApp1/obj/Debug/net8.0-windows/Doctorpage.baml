   M S B A M L   `   `   `  ����  WpfApp1    WpfApp1.Doctorpage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $	��600��5      $	��850��6   .��5      � $��20q�6     � RowDefinitions  5   
   �� 5      $
��Auto �6   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Doctor Management��6   $��22(�5      $
��Bold"�6"   
����  �$��Center=�5       �� Padding$ 10q�5      $��0��5      $��0,0,0,10q�5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�5      $��1��5      $��0,0,0,10q�5      .+�5      �� -   5        $��
Add Doctor��5         BlueMenuButton#��[  6*   6R   �� 5      -   5        $��Delete Doctor��5      #��[  6-   6U   �� 5       -   5        $��Update Doctor��5       #��[  6-   6U   5!      &   System.Windows.Controls.DataGrid  5$   
   -   5          Name$ DoctorsGrid��5$         AutoGenerateColumns$ False��5%         HeadersVisibility$ Column=�5&         
IsReadOnly$
 True��5'         SelectionMode$ Single=�5(      
�������
���   �
����  �$��2q�5,      $��2��5-      $��Stretch=�5.      $��Stretch=�5/       � 	Resources 52      =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value��%�   '        �� 53      "	  6   .�54      �� 
 � ��
 ��  �63   �� 55      
 � ��
 �����63   �� 56      
 � ��$
 Bold"�63   �� 57      
 � ��$ 10q�60   58      59         Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Doctor ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
DoctorId+6U     5=      $
 Name��6%   $ * 6L    63   �� *Name+6L     5>      $ Specialization��6%   $ * 6`    6=   �� *Specialization+6`     5?      $ Phone Number��6%   $ * 6Z    6;   �� *
DoctorsNum+6Z     5@      $ Email��6%   $ * 6Q    64   �� *
DocEmail+6Q      RowStyle 5D      �� 5E      )  #System.Windows.Controls.DataGridRow"	  6   .�5F      �� 
 � ��
 �����63   �� 5G      
 � ��
 �   �63   �� 5H      
 � ��$ 14(�61    �� Triggers 5I      P� 5J       P� Property �@ 
IsSelected P� Value$
 True��68   . �5K      �� 
 � ��
 ��ح�6;   �� 5L      
 � ��$
 Bold"�6;   5M      5O      5R      5T      5U      