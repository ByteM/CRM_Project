   M S B A M L   `   `   `  ����  CRM_User_Interface%    CRM_User_Interface.frmInsurance   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Window1��5   	   $	��450��6   $	��569��6&    � AllowsTransparency .  � WindowStyle$
 None=�6L   
������  � WindowStartupLocation$ CenterScreen=�6x   .��5      �� 
���   �$��10,25,10,15q�6!   $
��Left=�6?   $	��450��6Z   $	��Top=�6g   $	��570��6   $��
0,0,-1,-60q�6�    �� CornerRadius$ 10��6�   ._�5   
   � .+�5      �� -   5         ��Name$ 	btnInExit��5      $��19��6(   $��518,-57,6,379q�64   ���	#FFF6F6F6���	#FF090909$y�Visible=�6y   $
��Bold"�6�   $��X��6�   5	      � 5
      ���	#FFF0F0F0.+�5      �� $��Open New Insurance��6   $
��Left=�65   $��	182,0,0,0q�6P   $	��Top=�6c   $��18(�6{   $
��Bold"�6�   $��Italic$�6�   � 5      $
��Left=�6   $	��342��62   $��	25,36,0,0q�6?   $	��Top=�6R   $	��495��6j   
�������.+�5      �� $��Customer Name:��6   $
��Left=�65   $��	32,35,0,0q�6P   $	��Top=�6c   �� 5      -   5         ��Name$ lblCustomerName��5      $��Customer Name:��65   $
��Left=�6N   $��
164,36,0,0q�6i   $	��Top=�6}   $	��275��6�   �� 5      $��Mobile No.:��6   $
��Left=�62   $��	32,64,0,0q�6M   $	��Top=�6`   �� 5      -   5        $ lblMobileNo��5      $��MobileNo��61   $
��Left=�6D   $��
164,64,0,0q�6_   $	��Top=�6s   $	��275��6�   �� 5      $��	Email ID:��6   $
��Left=�60   $��	32,93,0,0q�6K   $	��Top=�6^   �� 5      -   5        $ 
lblEmailID��5      $��EmailID��60   $
��Left=�6B   $��
164,92,0,0q�6]   $	��Top=�6q   $	��301��6�   �� 5      $��Insurance No.:��6   $
��Left=�65   $��32,5,0,0q�6P   $	��Top=�6b   �� 5      -   5        $ lblInsuranceNo��5      $��InsuranceNo��64   $
��Left=�6J   $��	164,6,0,0q�6e   $	��Top=�6x   $	��275��6�   �� 5      $��Insurance Amt:��6   $
��Left=�65   $��
32,148,0,0q�6P   $	��Top=�6d   �� 5      -   5         ��Name$ txtInsuranceAmt��5      $
��Left=�67   $��23��6R   $��163,149,0,0q�6^    �� TextWrapping$
 Wrap=�6s   $	��Top=�6�   $	��196��6�   �� 5      $��Bank Integration:��6   $
��Left=�68   $��
32,177,0,0q�6S   $	��Top=�6g   �� 5      -   5        	 ��Name$	 cmbBankIntegration��5      $
��Left=�6;   $��163,178,0,0q�6V   $	��Top=�6k   $	��303��6�   
 �� 
IsEditable
 . $��25��6�   �� 5      $��	Validity:��6   $
��Left=�60   $��
33,237,0,0q�6K   $	��Top=�6_   �� 5      -   5        $ txtValidity��5      $
��Left=�63   $��23��6N   $��164,238,0,0q�6Z   $
 Wrap=�6o   $	��Top=�6�   $��71��6�   �� 5      -	   5        $	 cmbValidity��5      $
��Left=�64   $��241,239,0,0q�6O   $	��Top=�6d   $	��120��6|   6�   �� 5      $��Installment Interval:��6   $
��Left=�6<   $��33,347,0,-31q�6W   $	��Top=�6m   $y�Hidden=�6�   �� 5      -
   5        $ txtInterval��5      $
��Left=�63   $��23��6N   $��164,348,0,-29q�6Z   $
 Wrap=�6q   $	��Top=�6�   $��71��6�   $��0��6�   $y�Hidden=�6�   �� 5      $��First Party Insurance:��6   $
��Left=�6=   $��
33,267,0,0q�6X   $	��Top=�6l   �� 5      -   5         ��Name$ chbInsurance��5      $�� ��65   $
��Left=�6@   $��165,273,0,0q�6[   $	��Top=�6p   �� 5       -   5        $ btnSave��5       $
��Save��6.   $
��Left=�6=   $��156,304,0,0q�6X   $	��Top=�6m   $��75��6�   $��25��6�   6�   �� 5!      -   5        $ btnClear��5!      $��Clear��6/   $
��Left=�6?   $��242,304,0,0q�6Z   $	��Top=�6o   $��75��6�   $��25��6�   6�   �� 5"      -   5        $ btnExit��5"      $
��Exit��6.   $
��Left=�6=   $��329,304,0,0q�6X   $	��Top=�6m   $��75��6�   $��25��6�   6�   �� 5#      $��Date:��6   $
��Left=�6,   $��
33,206,0,0q�6G   $	��Top=�6[   �� 5$      -   5        $	 cmbInterval��5$      $
��Left=�64   $��241,349,0,-29q�6O   $	��Top=�6f   $	��120��6~   $y�Hidden=�6�   (  "System.Windows.Controls.DatePicker  5%      -   5          Name$ dtpDate��5%   !   $
��Left=�64   $��164,208,0,0q�6O   $	��Top=�6d   $	��127��6|      Text$ dd - MM - yyyy��6�   6�     5&      -   5        $ dtpInstallmentDate��5&   !   $
��Left=�6=   $��367,270,0,0q�6X   $	��Top=�6m   $	��127��6�   $y�Hidden=�6�   �� 5'      -   5        $ 	txtMonths��5'      $
��Left=�61   $��23��6L   $��379,238,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $��71��6�   $y�Hidden=�6�   �� 5(      -   5        $ txtIntervalTotalAmt��5(      $
��Left=�6;   $��23��6V   $��380,347,-2,-28q�6b   $
 Wrap=�6z   $	��Top=�6�   $	��117��6�   $
��0.00��6�   $y�Hidden=�6�   �� 5)      $��ProductName��6   $
��Left=�62   $��
32,119,0,0q�6M   $	��Top=�6a   �� 5*      -   5        $ lblProductName��5*      $��ProductName��64   $
��Left=�6J   $��164,118,0,0q�6e   $	��Top=�6z   $	��301��6�   �� 5+      -   5        $ txtDate��5+      $
��Left=�6/   $��23��6J   $��379,208,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $��71��6�   $y�Hidden=�6�   5,      �� 5-      -   5        $ txtInsuranceID��5-      $
��Left=�62   $��23��6M   $��	454,5,0,0q�6Y   $
 Wrap=�6l   $	��Top=�6�   $��31��6�   $y�Hidden=�6�   �� 5.      -   5        $ txtCustomerID��5.      $
��Left=�61   $��23��6L   $��	501,5,0,0q�6X   $
 Wrap=�6k   $	��Top=�6   $��31��6�   $y�Hidden=�6�   5/      50      51      52      