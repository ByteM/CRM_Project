   M S B A M L   `   `   `  ����  CRM_User_Interface.    (CRM_User_Interface.frmCRM_EmpDetailsEdit   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  frmCRM_EmpDetailsEdit��5   	   $	��430��6'   $	��540��64    � AllowsTransparency .  � WindowStyle$
 None=�6Z   
������  � WindowStartupLocation$ CenterScreen=�6�   .��5      � $��	0,0,0,247q�6   .+�5   
   �� 
���   �$��10,20,10,15q�6%   $
��Left=�6C   $	��435��6^   $	��Top=�6k   $	��540��6�   $��
0,0,0,-252q�6�    �� CornerRadius$ 10��6�   ._�5      � 
�������.+�5      � -   5         �Name$ grd_EmployeeDetails��5      $y�Visible=�64   $
��Left=�6I   $	��395��6d   $��2,0,0,0q�6q   $	��Top=�6�   $	��518��6�   ���	#FFDEF0E1.+�5	      �� -   5         ��Name$ cmbAdm_Emp_YearExp��5	      $
��Left=�6;   $��205,297,0,0q�6V   $	��Top=�6k   $	��110��6�    �� 
IsEditable . 6�   �� 5
      -   5        $ cmbAdm_Emp_Months��5
      $
��Left=�6:   $��379,297,0,0q�6U   $	��Top=�6j   $	��110��6�   $y�Visible=�6�    . 6�   �� 5      -   5         ��Name$ btnAdm_Emp_Exit��5      $
��Exit��66   $
��Left=�6E   $��258,360,0,0q�6`   $	��Top=�6u   $��75��6�   $��25��6�   6�   �� 5      $��Employee ID:��6   $
��Left=�63   $��32,9,0,0q�6N   $	��Top=�6`   �� 5      $��Name:��6   $
��Left=�6,   $��	32,42,0,0q�6G   $	��Top=�6Z   �� 5      -   5        	 ��Name$	 txtAdm_EmpName��5      $
��Left=�66   $��23��6Q   $��
162,44,0,0q�6]   
 �� TextWrapping$

 Wrap=�6q   $	��Top=�6�   $	��270��6�   �� 5      $��Date Of Birth:��6   $
��Left=�65   $��	32,72,0,0q�6P   $	��Top=�6c   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dtpAdm_Emp_DOB��5   !   $
��Left=�69   $��
162,74,0,0q�6T   $	��Top=�6h   $	��155��6�   �� 5      $��Address:��6   $
��Left=�6/   $��
32,103,0,0q�6J   $	��Top=�6^   �� 5      -   5        $	 txtAdm_Emp_Address��5      $
��Left=�6:   $��63��6U   $��162,105,0,0q�6a   $

 Wrap=�6v   $	��Top=�6�   $	��270��6�   �� 5      $��Designation:��6   $
��Left=�63   $��
31,234,0,0q�6N   $	��Top=�6b   �� 5      -   5        $	 txtAdm_Emp_Designation��5      $
��Left=�6>   $��23��6Y   $��161,236,0,0q�6e   $

 Wrap=�6z   $	��Top=�6�   $	��270��6�   �� 5      $��Date Of Joining:��6   $
��Left=�67   $��
31,263,0,0q�6R   $	��Top=�6f     5      -	   5        $ dtpAdm_Emp_DOJ��5   !   $
��Left=�69   $��162,265,0,0q�6T   $	��Top=�6i   $	��155��6�   �� 5      $��
Mobile No:��6   $
��Left=�61   $��
32,173,0,0q�6L   $	��Top=�6`   �� 5      -
   5        $	 txtAdm_Emp_MobileNo��5      $
��Left=�6;   $��23��6V   $��162,175,0,0q�6b   $

 Wrap=�6w   $	��Top=�6�   $	��270��6�   �� 5      -   5         ��Name$ 	Phone_No_��5      $��	Phone No:��6/   $
��Left=�6C   $��
32,203,0,0q�6^   $	��Top=�6r   �� 5      -   5        $	 txtAdm_Emp_PhoneNo��5      $
��Left=�6:   $��23��6U   $��162,205,0,0q�6a   $

 Wrap=�6v   $	��Top=�6�   $	��270��6�   �� 5      $��Experience:��6   $
��Left=�62   $��
32,294,0,0q�6M   $	��Top=�6a   �� 5      $��Salary:��6   $
��Left=�6.   $��
32,324,0,0q�6I   $	��Top=�6]   �� 5      -   5        $	 txtAdm_Emp_Salary��5      $
��Left=�69   $��23��6T   $��162,326,0,0q�6`   $

 Wrap=�6u   $	��Top=�6�   $	��270��6�   �� 5      -   5        $ btnAdm_Emp_Save��5      $
��Save��66   $
��Left=�6E   $��162,360,0,0q�6`   $	��Top=�6u   $��75��6�   $��25��6�   6�   �� 5       -   5        $ lblYears��5       $��Years��6.   $
��Left=�6>   $��163,295,0,0q�6Y   $	��Top=�6n   �� 5!      -   5        $ 	lblMonths��5!      $��Months��6/   $
��Left=�6@   $��324,294,0,0q�6[   $	��Top=�6p   $y�Visible=�6�   �� 5"      -   5        $ lblEmpID��5"   1   $��
EmployeeID��6   $
��Left=�6C   $��
163,10,0,0q�6^   $	��Top=�6r   �� 5#      -   5        $	 txtAdm_EmployeeID��5#      $
��Left=�69   $��23��6T   $��
484,12,0,0q�6`   $

 Wrap=�6t   $	��Top=�6�   $��34��6�   5$      5&      5'      5)      5*      