   M S B A M L   `   `   `  ����G  CBetterWpfAPP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:BetterWpfAPPBetterWpfAPP  5   	       BetterWpfAPP.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:BetterWpfAPP     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$
 Exit��5      $��3��6   $��Wyjście��6-   $��30(�6S   
���� ��6a   �� 5   
   -   5        $ PobierzDane��5      $��Wyszukaj��6&   $��1��69   $��30(�6F   
��� ���6h   �� 5   
   -   5        $��Wprowadzanie��5      $��1��6&   $��2��66   
����  �$��Wprowadź imię zawodnika��6\    �� TextAlignment$ Center=�6{   $��30(�6�   6�   �� 5   
   -   5         ��Name$ NazwiskoZawodnika��5      $��1��6/   $��1��6?   $��30(�6L   $��Nazwisko��6Z    �� TextAlignment$ Center=�6j   �� 5   
   -   5        $ ImięZawodnika��5      $��2��6+   $��1��6;   $��30(�6H   $��Imię��6V   $ Center=�6b   �� 5   
   -   5        $ WagaZawodnika��5      $��1��6+   $��2��6;   $��30(�6H   $
��Waga��6V   $ Center=�6b   �� 5   
   -   5        $ WzrostZawodnika��5      $��2��6-   $��2��6=   $��30(�6J   $��Wzrost��6X   $ Center=�6f   �� 5   
   -   5        $ IloscZawodnikow��5      $B��<Tutaj pokaże się ilośc zawodników o wprowadzonym imieniu��6-   �� 5   
   -	   5        $ testokna��5      $��Okno błędu��6#   $��3��68   $��3��6E   6U   5       5!      