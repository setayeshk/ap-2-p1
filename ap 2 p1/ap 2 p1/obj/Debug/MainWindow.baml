   M S B A M L   `   `   `  ����B  >ap 2 p1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ap_2_p1ap_2_p1  5   	       ap_2_p1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ap_2_p1     5   	     � Title$  
MainWindow��5   	   $��663.052��6   $��1029.549��6-   .��5	      �  J� RenderTransformOrigin$ 0.5,0.5&�6   z�5
   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.128Q�6"   T� 5      5      .+�5   
   �� $
��Left=�6   
�������$	��614��6G   $	��Top=�6U   $	��800��6m   $��0,10,0,0q�6y   .@�5      �� $��informations��6   
�������$��-2,0,-8.333,1.667q�6D   $��51��6_   $��Bottom=�6k   .��5      � ���	#FFE5E5E5$��0,0,0.333,-3.333q�6.   .+�5      �� $
��name��6   $
��Left=�6,   $��14(�6G   
��� � �$��Italic$�6�   $	��Top=�6�   $��52��6�   $��84��6�   $��0,9,0,0q�6�   �� 5      $��	last name��6   $
��Left=�60   $��14(�6K   
��� � �$��Italic$�6�   $	��Top=�6�   $��0,94,0,0q�6�   $��84��6�   $��52��6�   �� 5      $
��city��6   $��14(�6+   
��� � �$��Italic$�6d   $
��Left=�6w   $	��Top=�6�   $��	0,172,0,0q�6�   $��54��6�   $��84��6�   �� 5      $	��age��6   $
��Left=�6*   $��14(�6E   
��� � �$��Italic$�6~   $	��Top=�6�   $��	0,245,0,0q�6�   $��52��6�   $��84��6�   �� 5      $��	equations��6   $��17(�60   
�����_�$��Italic$�6m   $
��Left=�6�   $	��Top=�6�   $��
10,319,0,0q�6�   $��81��6�   $��84��6�   �� 5      -   5         ��Name$
 name��5      $
��Left=�6,   $��46��6G    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��144��6   $��	84,15,0,0q�6�   �� 5      -   5        $ 	last_name��5      $
��Left=�62   $��47��6M   $
 Wrap=�6Y   $	��Top=�6o   $	��144��6�   $��	84,94,0,0q�6�   �� 5      -   5        $
 city��5      $
��Left=�6,   $��49��6G   $
 Wrap=�6S   $	��Top=�6g   $	��144��6   $��
84,172,0,0q�6�   �� 5      -   5        $	 age��5      $
��Left=�6+   $��52��6F   $
 Wrap=�6R   $	��Top=�6f   $	��144��6~   $��
84,245,0,0q�6�   �� 5      -   5        $ 	equations��5      $
��Left=�61   $	��104��6L   $
 Wrap=�6Y   $	��Top=�6n   $	��186��6�   $��123,343,0,0q�6�   �� 5       -   5         ��Name$ 
soloutions��5    !   $
��Left=�67   $
��Wrap=�6R   $	��Top=�6f   $��
378,32,0,0q�6~   $	��283��6�   $	��364��6�   �� 5!      -   5        $	��Add��5!      $��14(�6+   
�������$��Black"�6d   $
��Left=�6�   $	��Top=�6�   $��75��6�   $��298,182,0,0q�6�   6�   5#      5%      �� 5&      $��query��6   
�������$��7.333,0,-53,0.667q�6<   .��5'      � ���	#FFE5E5E5$��0,1,0.333,-3.333q�6.   .+�5(      �� -   5        $ Peopleolderthan��5(       $
��Left=�69   $��18��6T   $
 Wrap=�6`   $	��Top=�6u   $��49��6�   $��
137,36,0,0q�6�   �� 5)      -	   5        $ Agemodaiszero��5)      $
��Left=�66   $��15��6Q   $
 Wrap=�6]   $	��Top=�6r   $��49��6�   $��140,316,0,0q�6�   �� 5*      -
   5        $ Peoplelastname��5*       $
��Left=�68   $��15��6S   $
 Wrap=�6_   $	��Top=�6s   $��49��6�   $��140,399,0,0q�6�   �� 5+      -   5        $ Lastnamestartwith��5+      $
��Left=�6;   $��15��6V   $
 Wrap=�6b   $	��Top=�6v   $��49��6�   $��
355,36,0,0q�6�   �� 5,      -   5        $ Numberofequations��5,      $
��Left=�6:   $��15��6U   $
 Wrap=�6a   $	��Top=�6u   $��49��6�   $��
355,79,0,0q�6�   �� 5-      -   5        $ Peoplecitystartwith��5-      $
��Left=�6<   $��15��6W   $
 Wrap=�6c   $	��Top=�6x   $��49��6�   $��364,120,0,0q�6�   �� 5.      -   5        $ Peopleyoungerthan��5.      $
��Left=�6:   $��15��6U   $
 Wrap=�6a   $	��Top=�6u   $��49��6�   $��
140,80,0,0q�6�   �� 5/      -   5        $ Answeroftheequation��5/      $
��Left=�6<   $��15��6W   $
 Wrap=�6c   $	��Top=�6x   $��72��6�   $��140,124,0,0q�6�   �� 50      -   5        $ Namestartwith��50      $
��Left=�66   $��15��6Q   $
 Wrap=�6]   $	��Top=�6r   $��49��6�   $��140,170,0,0q�6�   �� 51      -   5        $ Equation��51      $
��Left=�61   $��22��6L   $
 Wrap=�6X   $	��Top=�6l   $	��135��6�   $��
96,219,0,0q�6�   �� 52      -   5        $ Peoplenamed��52      $
��Left=�64   $��15��6O   $
 Wrap=�6[   $	��Top=�6p   $��49��6�   $��140,269,0,0q�6�   �� 53      -   5        $ 
Peoplecity��53      $
��Left=�63   $
 Wrap=�6N   $��49��6c   $��140,362,0,0q�6n   $��15��6�   $	��Top=�6�   �� 54      $��people older than��6   $
��Left=�68   $	��Top=�6S   $��	10,32,0,0q�6k   $��26��6~   $	��108��6�   $ 0.867,-0.555&�6�   �� 55      $��people younger than��6   $
��Left=�6:   $	��Top=�6U   $��	10,76,0,0q�6m   $��26��6�   $	��125��6�   �� 56      $��answer of the equation��6   $
��Left=�6=   $	��Top=�6X   $��	0,120,0,0q�6p   $��26��6�   $	��130��6�   $ 0.867,-0.555&�6�   �� 57      $��name start with��6   $
��Left=�66   $	��Top=�6Q   $��
10,166,0,0q�6i   $��26��6}   $	��130��6�   $ 0.867,-0.555&�6�   �� 58      $��	Equations��6   $
��Left=�60   $	��Top=�6K   $��
10,215,0,0q�6c   $��26��6w   $	��130��6�   $ 0.867,-0.555&�6�   �� 59      $��people firstname��6   $
��Left=�67   $	��Top=�6R   $��	5,265,0,0q�6j   $��26��6}   $	��130��6�   $ 0.867,-0.555&�6�   �� 5:      $��age mod a is zero��6   $
��Left=�68   $	��Top=�6S   $��	0,312,0,0q�6k   $��26��6~   $	��130��6�   $ 0.867,-0.555&�6�   �� 5;      $��people city��6   $
��Left=�62   $	��Top=�6M   $��	0,358,0,0q�6e   $��26��6x   $	��130��6�   $ 0.867,-0.555&�6�   �� 5<      $��people lastname��6   $
��Left=�66   $	��Top=�6Q   $��	0,396,0,0q�6i   $��26��6|   $	��130��6�   $ 0.867,-0.555&�6�   �� 5=      $ ��people lastname start with��6   $
��Left=�6A   $	��Top=�6\   $��
191,32,0,0q�6t   $��26��6�   $	��159��6�   $ 0.867,-0.555&�6�   �� 5>      $��numberofequations��6   $
��Left=�68   $	��Top=�6S   $��
205,76,0,0q�6k   $��26��6   $	��159��6�   $ 0.867,-0.555&�6�   �� 5?      $��people city start with��6   $
��Left=�6=   $	��Top=�6X   $��217,116,0,0q�6p   $��30��6�   $	��145��6�   $ 0.867,-0.555&�6�   �� 5@      -   5        $
��find��5@      $��17(�6,   
�������$��Black"�6e   $
��Left=�6�   $	��Top=�6�   $	��139��6�   $��
509,99,0,0q�6�   $��36��6�   6�   �� 5A      -   5        $ people��5A       $
��Left=�60   $
��Wrap=�6K   $	��Top=�6`   $��236,153,0,0q�6x   $	��309��6�   $	��541��6�   5B      5C      �� 5D      $��Draw diagram��6   
�������$��51.333,0,-55.667,0.667q�6D   .��5E      �� ���	#FFE5E5E5$��0,0,-12.667,-4q�60   .+�5F      �� -   5         ��Name$ draw_function��5F      $
��Draw��64   $
��Left=�6C   $	��Top=�6^   $	��370��6v   $��29��6�   
�������6�   �� 5G      -   5        $ clear_function��5G      $��Clear��65   $
��Left=�6E   $	��Top=�6`   $	��367��6x   $��408,0,-0.333,0q�6�   $��29��6�   
�������6�   �� 5H      -   5        $ 	function1��5H      $
��Left=�61   $��33��6L   $
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��683��6�   $��
62,519,0,0q�6�   �� 5I      -   5        $ min_y��5I      $
��Left=�6-   $��31��6H   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��104��6�   $��
62,476,0,0q�6�   �� 5J      -   5        $ max_y��5J      $
��Left=�6-   $��31��6H   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��103��6�   $��246,476,0,0q�6�   �� 5K      -   5        $ min_x��5K      $
��Left=�6-   $��31��6H   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��104��6�   $��458,476,0,0q�6�   �� 5L      -   5        $ max_x��5L      $
��Left=�6-   $��31��6H   $
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��105��6�   $��640,476,0,0q�6�   �� 5M      $
��Left=�6    $
��Wrap=�6;   $��Min y =��6O   $	��Top=�6^   $��
21,477,0,0q�6v   $��30��6�   �� 5N      $
��Left=�6    $
��Wrap=�6;   $��Max y =��6O   $	��Top=�6^   $��198,477,0,0q�6v   $��30��6�   �� 5O      $
��Left=�6    $
��Wrap=�6;   $��Min x =��6O   $	��Top=�6^   $��412,477,0,0q�6v   $��30��6�   �� 5P      $
��Left=�6    $
��Wrap=�6;   $��Max x =��6O   $	��Top=�6^   $��592,477,0,0q�6v   $��30��6�   �� 5Q      $
��Left=�6   $��f(x) =��67   $	��Top=�6H   $��
29,519,0,0q�6`   $��30��6t   �� 5R      -   5         ��Name$ coordinate_plane��5R      $	��800��67   $	��438��6C   
 �� Top$ 34��6P   
�������6a   5T      5U      5V      �� 5W   
   -   5        $ watch��5W      $	��172��6    	 �� Left$		 835��6,   $	��172��6>   $ 10��6K   $��841,10,9.667,452q�6[   5]      A� 5^      -   5        
 A�Name$
 clock��5^      $
��Left=�6%   $	��172��6@   
����ح�$	��Top=�6`   $	��172��6x   $		 835��6�   $ 10��6�   $��
841,10,0,0q�6�   5d      5e      