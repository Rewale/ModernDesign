   M S B A M L   `   `   `  ����G  CModernDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:ModernDesign.MVVM.ViewModernDesign.MVVM.View  5   	   +    %ModernDesign.MVVM.View.giveBookWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:ModernDesign.MVVM.View     5   	   M IModernWpf.Controls, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullD @ModernWpf, Version=0.9.4.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   5   	   0  *ModernWpf.Controls.Primitives.WindowHelper    UseModernWindowStyle  . ���#282828 � Title$ 
bookWindow��5
   	   $	��450��6   $	��550��6)   .��5      � $��10q�6   $��Center=�6   $��Center=�64   .+�5   
   � -   5         �Name$ grid1��5      $	��Top=�6   $
��Left=�67    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#   .+�5      �� $��Center=�6   $��0��60   $��3q�6=   $
��Left=�6H   $��0��6c   $��Книга:��6s   
�������$��24(�6�   �� 5      -   5         ��Name$ booksBox��5   ^    �� DisplayMemberPath$
 name��6D   $	��300��6p   $��Center=�6|   $��0��6�   $��3q�6�   $
��Left=�6�   $��1��6�   
�������$��24(�6�   �� 5      $��Center=�6   $��1��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Читатель:��6r   
�������$��24(�6�   �� 5      -   5        $ chitsBox��5   /   $	 FIO��6   $	��300��6A   $��Center=�6M   $��1��6i   $��3q�6v   $
��Left=�6�   $��1��6�   
�������$��24(�6�   �� 5      $��Center=�6   $��2��6/   $��3q�6<   $
��Left=�6G   $��0��6b   $��Экземпляр:��6r   
�������$��24(�6�   �� 5      -   5        $ exmpBox��5   8   $ id_exemplar��6   $	��300��6I   $��Center=�6U   $��2��6q   $��3q�6~   $
��Left=�6�   $��1��6�   
�������$��24(�6�   �� 5"      -   5        $��9��5"   *   $��0��67   $��2��6G   
���   �$��Center=�6o   $��0, 30q�6�   
������� J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��179��6�   $��48��6�   $��Выдать��6�   5$      5&      5(      5)      