   M S B A M L   `   `   `  ����B  >Hangman, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:HangmanHangman  5   	       Hangman.HangmanWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Hangman     5   	     � Title$  Hangman��5   	   $	��450��6   $	��875��6&   ���	#FFE81616 � 
ResizeMode$ NoResize=�6I    � WindowStartupLocation$ CenterScreen=�6_    � WindowStyle$
 None=�6�   .��5
      � $��0q�6   ���	#FFCFD8DC$
��Auto��6-   $
��Auto��6;   .+�5   
   �� -   5        $��Check��5      $��113,349,0,0q�6!   $��27��6T   $	��Top=�6`   $
��Left=�6x   $��86��6�   $��Cooper Black)�6�   �� 5   
   -   5        $��Check��5      $��330,349,0,0q�6!   $��27��66   $	��Top=�6B   $
��Left=�6Z   $��86��6u   $��Cooper Black)�6�   �� 5   
   -   5         ��Name$ 	GuessWord��5      $��215,349,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $��Guess the word��6s   $��Center=�6�   $��27��6�   $	��Top=�6�   $
��Left=�6�   $	��115��6	  .��6  ��5      �� 5       �� Color# � ��6"   .��5   "   5      �� 5   
   -   5        $ Letter��5      $��
63,349,0,0q�6"   $
 Wrap=�66   $��Letter��6J   $��Center=�6X   $��27��6�   $	��Top=�6�   $
��Left=�6�   $��50��6  .��6  ��5      �� 5      # � ��6"   .��5   "   5      �� 5   
   -   5        $
��Exit��5      $
��Left=�6    $��729,349,0,0q�6;   $	��Top=�6P   $��86��6h   $��Cooper Black)�6�   $��27��6�   $��14(�6�   �� 5   
   -   5         ��Name$	 img��5      $��
488,72,0,0q�6   $�� ��61   $
��Fill=�6;   $	��254��6J   $	��Top=�6W   $
��Left=�6o   $	��257��6�   $��0��6�    J� OpacityMask 6�   Z� �� 5   
   $��Guess the word��6   $
��Left=�6)   $��	49,21,0,0q�6D   $	��Top=�6W   $	��253��6o   $��Center=�6{   $��30(�6�   $
��Bold"�6�   $��Cooper Black)�6�   $��37��6�   ���#455A646�   � 5   
   -   5        	 �Name$	 	LabelWord��5      ���	#FFCFD8DC$��	53,82,0,0q�69   $
��Left=�6L   $	��292��6g   $��38��6s   $	��Top=�6   � 5   
   -   5        $	 lowercaseLetters��5      ���	#FFCFD8DC$��	0,400,0,0q�6@   
 J� RenderTransformOrigin$
 0.503,1.151&�6S   $��24��6w   $	��Top=�6�   �� 5   
   -	   5        $��New Game��5      $��538,349,0,0q�6$   $��27��69   $	��Top=�6E   $
��Left=�6^   $	��124��6y   $��Cooper Black)�6�   $
 1.424,0.844&�6�   �� 5   
   -
   5         ��Name$ score��5      $�� ��6   $
��Left=�6*   $��
541,34,0,0q�6E   $	��Top=�6Y   $��27��6q   $��38��6|   $
 0.444,1.156&�6�   $��Cooper Black)�6�   $��25(�6�   �� 5   
   -   5        $ 	scoreText��5      $��Score:��6$   $��1��65   $
��Left=�6E   $��
464,41,0,0q�6`   $	��Top=�6t   $��Cooper Black)�6�   $��71��6�   $��20(�6�   $��31��6�   ���#455A646�   5       5%      