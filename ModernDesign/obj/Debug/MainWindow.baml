   M S B A M L   `   `   `  ����G  CModernDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ModernDesignModernDesign  5   	   I)clr-namespace:ModernDesign.MVVM.ViewModelModernDesign.MVVM.ViewModel  5   	   ?$clr-namespace:ModernDesign.MVVM.ViewModernDesign.MVVM.View  5   	       ModernDesign.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ModernDesign     5   	   ?	viewModel)clr-namespace:ModernDesign.MVVM.ViewModel     5   	   5view$clr-namespace:ModernDesign.MVVM.View     5   	   M IModernWpf.Controls, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullD @ModernWpf, Version=0.9.4.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   5	   	   $	��600��5   	   $
��1080��6     � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency .  � DataContext 5      /  )ModernDesign.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 20��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5       �� $��Библиотека��6   $��Center=�6*   $
��Left=�5!      
�������$��22(�5#      $��20 0 0 0q�5$      �� 5&      $��1��6   .+�5(      	� $��Список книг��6    d� 	IsChecked$
 TrueY�5)      $��50��5*      
�������$��14(�5+   1      MenuButtonTheme#��[  5,      ��5-      �� *HomeViewCommand+	� 5.      $��Выдача книг��6   $��50��5/      
�������$��14(�51   1   #��[  52      ��50      �� *GivenBookViewCommand+52      	� 54      $!��Желтый квадрат��6   $��50��55      
�������$��14(�56   1   #��[  57      ��58      �� *DicoveryViewCommand+	� 59      -   5        $��
Выйти��59      $��50��5:      
�������$��14(�5;   1   #��[  5<      5=      5?      '  !ModernWpf.Controls.AutoSuggestBox  5I      -   5         �� DisplayMemberPath$
 name��5J      	   PlaceholderText$	 Search��5K      
   	QueryIcon-  'ModernWpf.Controls.IconElementConverter$

 Find 5O      $	��300��5P      $��20(�5Q      $��Center=�5R      $
��Left=�5S      $��5q�5T      $��1��5U      �� 5W      $��1��6   
�������$��Center=�6;   $��36(�6V   $��Center=�6d     HeaderTextBlockStyle#��[ 6�   ��6�   �� *
nameUser+6�   �� 5\      $��1��6   $��1��5]      $��10q�5^      ��5_      �� *CurrentView+5c      5f      5g      