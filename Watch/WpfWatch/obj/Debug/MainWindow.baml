   M S B A M L   `   `   `  ����C  ?WpfWatch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WpfWatch.ViewModelsWpfWatch.ViewModels  5   	   #clr-namespace:WpfWatchWpfWatch  5   	   9!clr-namespace:WpfWatch.ViewModelsWpfWatch.ViewModels  5   	       WpfWatch.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   3local!clr-namespace:WpfWatch.ViewModels     5   	   &wpfclr-namespace:WpfWatch     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   *vm!clr-namespace:WpfWatch.ViewModels  5   	     � Title$  Watch��5	   	   $	��128��6   $	��410��6$   ���	#FF818181 � 
ResizeMode$ NoResize=�6G    � 	Resources 5      (   "WpfWatch.ViewModels.ViewModelWatch   ViewModelWatch��%   &	          5   
   6   5      .��5      � $	��400��6J   $	��100��6V   ���	#FF818181$��0,0,0,0q�6z    � DataContext 6   ��  �� Source# [  .+�5   
   �� $��M��6   $��	7,0,364,0q�6   $��29��60   $��29��6<   $	��Top=�6G    J� RenderTransformOrigin$ 0.862,0.276&�6_   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ PreviewMouseDown��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction  	   Command	 6,   �� *ModeButtonKeyDown+5        5      $ PreviewMouseUp��6!   . 5        	 6,   �� *ModeButtonKeyUp+5      5      �� 5   
   $��B��6   $��
7,61,364,0q�6   $��29��61   $��29��6=   $	��Top=�6H    5        5      $ PreviewMouseDown��6!   . 5        	 6,   �� *BacklightButtonKeyDown+5        5      $ PreviewMouseUp��6!   . 5         	 6,   �� *BacklightButtonKeyUp+5!      5#      �� 5$   
   $��S��6   $��
356,0,15,0q�6   $��29��61   $��29��6=   $	��Top=�6H    5%        5&      $ PreviewMouseDown��6!   . 5'        	 6,   �� *SettingsButtonKeyDown+5(        5)      $ PreviewMouseUp��6!   . 5*        	 6,   �� *SettingsButtonKeyUp+5+      5-      �� 5.   
   $��F��6   $��356,61,15,0q�6   $��29��62   $��29��6>   $	��Top=�6I    5/        50      $ PreviewMouseDown��6!   . 51        	 6,   �� *FunctionalButtonKeyDown+52        53      $ PreviewMouseUp��6!   . 54        	 6,   �� *FunctionalButtonKeyUp+55      57      !   WpfWatch.DisplaySimpleClock  58   
   
���   �$
��Left=�6�   $��41,0,0,0q�6�   $	��Top=�6�    6!   �� *VMSimpleClock+!   WpfWatch.DisplayUserControl
   	Backlight
 6G   �� # [   �� Path$ 	Backlight�y�6�   �� *	DisplayON+6�      WpfWatch.DisplayProClock  59   
   
���   �$
��Left=�6�   $��41,0,0,0q�6�   $	��Top=�6�    6   �� *
VMProClock+
 6A   �� # [  $ 	Backlight�y�6�   �� *	DisplayON+6�   	   WpfWatch.DisplayStopwatch	  5:   
   
���   �$
��Left=�6�   $��41,0,0,0q�6�   $	��Top=�6�    6   �� *VMStopwatch+
 6C   �� # [  $ 	Backlight�y�6�   �� *	DisplayON+6�   
   WpfWatch.DisplayTimer
  5;   
   
���   �$
��Left=�6�   $��41,0,0,0q�6�   $	��Top=�6�    6   �� *	VMTimer+
 6;   �� # [  $ 	Backlight�y�6�   �� *	DisplayON+6�   5<      5=      