   M S B A M L   `   `   `  ����@  <WPFUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFUIWPFUI  5   	       WPFUI.MonsterManualWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:WPFUI     5   	   -   5        $��14(�5   	     � Title$  MonsterManualWindow��5	   	   $	��300��6%   $	��400��62    � WindowState$ 	Maximized=�6U    � WindowStyle$ ThreeDBorderWindow=�6m    � 	Resources 5
         WPFUI.DungeonBuddyDataSet   dungeonBuddyDataSet  monsterIndexViewSource �� Source �� Source��%]   &	        &	      7     5   
   6$   �� 5   
    6>   �� *MonsterIndex+8   5      .��5      �  � DataContext# [ 6    � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $��* �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      $��20 �6   .+�5&   
   o� -   5        	 o�Name$
	 menu��5&      $��0��6   $��0��6-   $��10��6:   ��5'      �� 5(      
 �� Color#
 � ��6"   .@�5*      m� $��_File��6   .@�5+      m� -   5         m�Name$ menuItem_Exit��5+      $
��Exit��62   6B   5,      5-      �� 5/   
   -   5         ��Name$ 	countText��5/      $��1��6'   $��1��67   $	��0,5q�6D   ( 9999 / 9999 )51      �� 53   
   -   5         ��Name$ TB_SearchBox��53      $��1��6(   $��2��68   .��6l   Search55      �� 57   
   -   5         ��Name$ CB_Size��57      $��2��6$   $��2��64    �� Text$
 Size��6A    �� 
IsReadOnly .  �� 
IsEditable . $��10,0,0,0q�6q   .@�58      �� $
��Tiny��6   �� 59      $��Small��6   5:      �� 5<   
   -   5        $ CB_Type��5<      $��3��6$   $��2��64   $
 Type��6A    .  . $��1,0,0,0q�6q   .@�5=      �� $
��Tiny��6   �� 5>      $��Small��6   5?      �� 5A   
   -   5        $ CB_Allignment��5A      $��4��6*   $��2��6:   $ 
Allignment��6G    .  . $��1,0,0,0q�6}   .@�5B      �� $
��Tiny��6   �� 5C      $��Small��6   5D      �� 5F   
   -	   5        $ CB_Environment��5F      $��5��6+   $��2��6;   $ Environment��6H    .  . $��1,0,0,0q�6   .@�5G      �� $
��Tiny��6   �� 5H      $��Small��6   5I      �� 5K   
   -
   5         ��Name$ ChallengeSlider��5K       � Minimum$ 0Q�6*    � Maximum$	 100Q�66   $��6��6D   $��2��5L       �� TickPlacement$
 Both=�6   $��10,0,0,0q�63   6G   �� 5N   
   -   5         ��Name$ btn_AddMonsters��5N      $��7��6*   $��2��6:   $��Center=�6G   .��6�   Add5P      �� 5R   
   -   5        $ btn_ClearMonsters��5R      $��8��6,   $��2��6<   $��Center=�6I   .��6d   Clear5T      &   System.Windows.Controls.DataGrid  5V   
   -   5          Name$ monsterIndexDataGrid��5V         AutoGenerateColumns .  $��1��6M      EnableRowVirtualization . $��	0,10,0,10q�5W   J   $��3��6]      RowDetailsVisibilityMode$ VisibleWhenSelected=�5X      $��6��6B   ��5W   2   ��    Columns 5Y      0  *System.Windows.Controls.DataGridTextColumn  5Z      -   5        
nameColumn��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5Z   R      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 6`   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *Name+6`     5[      -   5        
sizeColumn��$
 Size��5[   R   $ SizeToCells 6`    69   �� *Size+6`     5\      -   5        
typeColumn��$
 Type��5\   R   $ SizeToCells 6`    69   �� *Type+6`     5]      -   5        
tagsColumn��$
 Tags��5]   R   $ SizeToHeader 6`      
Visibility$ Hidden=�6u    69   �� *Tags+6u     5^      -   5        alignmentColumn��$ 	Alignment��5^   \   $ SizeToCells 6o    6>   �� *	Alignment+6o     5_      -   5        environmentColumn��$ Environment��5_   `   $ * 6u    6@   �� *Environment+6u     5`      -   5        challengeColumn��$ 	Challenge��5`   \   $ SizeToHeader 6o    6>   �� *	Challenge+6o     5a      -   5        xPColumn��$ XP��5a   N   $ SizeToCells 6Z    67   �� *XP+6Z     5b      -   5        sourceColumn��$ Source��5b   V   $ SizeToHeader 6f   $ Hidden=�6{    6;   �� *Source+6{     5c      -   5        
pageColumn��$
 Page��5c   R   $ SizeToHeader 6`   $ Hidden=�6u    69   �� *Page+6u     5d      -   5        referenceColumn��$ 	Reference��5d   \   $ SizeToHeader 6o   $ Hidden=�6�    6>   �� *	Reference+6�     5e      -   5        	sRDColumn��$	 SRD��5e   P   $ SizeToHeader 6]   $ Hidden=�6r    68   �� *SRD+6r     5f      -   5        descriptionColumn��$ Description��5f   `   $ SizeToHeader 6u   $ Hidden=�6�    6@   �� *Description+6�   5h      �� 5j   
   -   5          ��Name$  
TABControl��5j      $��7��6)   $��3��69   $��	5,10,0,10q�6F   $��2��6Y   .@�5k      �� $��Details��6   .��5l      �� Details Go Here5n      5o      �� 5p      $��My Monsters��6   .��5q      �� $��0q�6   My Monsters Go Here5s      5t      5u      �� 5w   
   -   5        $ FiltersBlock��5w      $��1��6*   $��4��6:   $��Filters Go Here��6G   5y      5z      