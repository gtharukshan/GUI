   M S B A M L   `   `   `  ����   WpfApp1    WpfApp1.PatientPage   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     $	��600��$	��850��.��� $��20q�  � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��Patient Management��$��22(�$
��Bold"�
����  �$��Center=� �� Padding$ 10q�$��0��$��0,0,0,10q���  �� Orientation$ 
Horizontal=�$��Center=�$��1��$��0,0,0,10q�.+��� -   $��Add Patient��   BlueMenuButton#��[  �� -   $��Delete Patient��#��[  �� -   $��Update Patient��#��[  &   System.Windows.Controls.DataGrid  -     Name$ PatientsGrid��   AutoGenerateColumns$ False��   HeadersVisibility$ Column=�   
IsReadOnly$
 True��   SelectionMode$ Single=�
�������
���   �
����  �$��2q�$��2��$��Stretch=�$��Stretch=� � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader	 �� 
TargetType
 �� Property �� Value��%u   '        �� "	  .��� 
 � ��
 ��  ��� 
 � ��
 ������� 
 � ��$
 Bold"��� 
 � ��$ 10q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Patient ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	PatientId+  $
 Name��$ *  �� *Name+  $ Phone Number��$ *  �� *PhoneNumber+  $ Disease��$ *  �� *	Disease+4  .System.Windows.Controls.DataGridCheckBoxColumn  $ 	Emergency��$ *  �� *IsEmergency+  $ Address��$ *  �� *	Address+   RowStyle �� )  #System.Windows.Controls.DataGridRow"	  .��� 
 � ��
 ������� 
 � ��
 �   ��� 
 � ��$ 14(� �� Triggers P�  P� Property �@ 
IsSelected P� Value$
 True��. ��� 
 � ��
 ��ح��� 
 � ��$
 Bold"�