   M S B A M L   `   `   `  ����M  IAppControl_Escolar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppControl_EscolarAppControl_Escolar  5          AppControl_Escolar.ucLog   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AppControl_Escolar     5      V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��355��5	      $	��270��6   .��5
      � .+�5   
   ��   �� RadiusY$  12��6    �� RadiusX$ 12��6!   ���	#FF2E2E2E6.   �� 5   
   $
��20 0q�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ AccountCircle=�6&   $	��100��6<   $	��100��6H   
�������$	��Top=�6i   $��Center=�6�   $��0,10,0,0q�6�   �� 5      $��Iniciar Sesión��6   
�������$��30(�6F   $��Center=�6T   $��Center=�6o   $��0q�6�   �� 5      $��Center=�6   $
��0,10q�66    �� Orientation$ 
Horizontal=�6D   .+�5        $ Account=�6*   $��Center=�69   $��0,15,0,0q�6T   
�������6f   �� 5      -   5         ��Name$ txtbUsuario��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Usuario��6/    %  !MaterialDesignFloatingHintTextBox#��[  6X   $	��200��6�   $��5q�6�   $��Center=�6�   
�������6�   5      �� 5      $��Center=�6   $ 
Horizontal=�67   .+�5        $	 Key=�6*   $��Center=�65   $��0,15,0,0q�6P   
�������6b   G� 5      -   5         G�Name$ txtbPassword��5      $ Contraseña��64    ) %MaterialDesignFloatingHintPasswordBox#��[ 6`   $	��200��6�   $��5q�6�   $��Center=�6�   
�������6�   5      �� 5      -   5         ��Name$ 
txtbOlvido��5      $��Olvidé mi contraseña��6,   $��11(�6H   ���	#FF51FD40$	��0 5q�6m   $��Right=�6z   �� 5      -   5         ��Name$ btnContinuar��5   �   $��Bottom=�6   $��Center=�60   $��	Continuar��6M   $	��130��6a   $
��0,10q�6m   $��18(�6{   ���	#FF3D96B86�   5      � 5   
   -   5        	 �Name$	 gRecuperarPassword��5   (   $	��210��6   $	��105��6   $y�	Collapsed=�6D   .+�5      �� $  10��6   $ 10��6%   ���	#FF74747462   �� 5      $
��10 5q�6   .+�5      �� $��Recuperar contraseña��6   $��2q�65   $��Center=�6@   $��10(�6]   
�������6k   �� 5      $#��Enviar contraseña al correo?��6   $��2q�6=   $��Center=�6H   �� 5       -   5        $ txtbDestinatario��5    +   
�������$��default@hotmail.com ��6E   $��2q�6a   $��Center=�6l   �� 5!      $ 
Horizontal=�6   $��Center=�66   $��5q�6S   .+�5"      �� -   5        $ 	btnEnviar��5"      $��25��60   $��25��6;   $��Center=�6G    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6b   $��2 2 3 2q�6�   ���	#FF3D96B8��6�   Z� .��5#        $
 Send=�62   $��14��6>   $��14��6J   $��Center=�6U   $��Center=�6p   5$      � 5%      $��30��6   �� 5&      -   5        $ btnCancelar��5&      $��25��62   $��25��6=   $��Center=�6I   #��[ 6d   $��2 2 3 2q�6�   ���	#FF3D96B8��6�   Z� .��5'        $ Cancel=�62   $��14��6@   $��14��6L   $��Center=�6W   $��Center=�6r   5(      5)      5*      5-      5/      50      