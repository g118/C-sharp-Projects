   M S B A M L   `   `   `  ����H  DRandom Number, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Random_NumberRandom_Number  5   	       Random_Number.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Random_Number     5   	     � Title$  Randon_number��5   	   $	��350��6   $	��525��6,   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $	��.5* �6   �� 5      $	��.5* �6   .+�5   
   �� -   5        $��lblIntro��5      $��Center=�6    $��Center=�6;   $��3��6X   $��0��6l   $��0��6y   $0��*I'm thinking of a number between 1 and 100��6�   $��25(�6�   �� 5   
   -   5        $��lblInstruct��5      $��Right=�6#   $��Center=�6?   $��1��6Z   $��0��6g   $��Enter your guess:��6w   $��20(�6�   �� 5   
   -   5        $��tbGuess��5      $��20q�6!   $��25(�6-   $��1��6;   $��1��6K    �� 	MaxLength$ 3��6X    �� TextAlignment$ Center=�6f   ��6}   �� *Guess+ �� Mode$ TwoWay=��� 5   
   -   5        $��btnCheck��5      $��20q�6!   $��20(�6-   $��Check��6<   $��2��6L   $��1��6\   6i   �� 5   
   -   5        $��lblLast��5      $��20(�6   $��Last guess:��6-   $��Right=�6C   $��0��6_   $��2��6o   �� 5   
   -   5        $��lblAll��5      $��20(�6   $��All guesses:��6,   $��Right=�6C   $��0��6_   $��3��6o   �� 5   
   -   5        $��tbLast��5      $��5q�6    $��20(�6+   $��1��69   $��2��6I   $��2��6]   $
 Left=�6j   ��6   �� *	lastGuess+$ TwoWay=��� 5   
   -   5        $��tbAll��5      $��5q�6   $��20(�6*   $��1��68   $��2��6H   $��3��6\   $
 Left=�6i   ��6~   �� *
allGuesses+$ TwoWay=�5      5      