   M S B A M L   `   `   `  ����[  WGarcia Bernardo_PRG_III (A)_Ex_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Garcia_Bernardo_PRG_III__A__Ex_1 Garcia_Bernardo_PRG_III__A__Ex_1  5   	   1    +Garcia_Bernardo_PRG_III__A__Ex_1.MainWindow   5   	   W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Garcia_Bernardo_PRG_III__A__Ex_1     5   	     � Title$  
MainWindow��5   	   $	��532��6   $
��1107��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ lstShow��5
      $��400,10,371,10q�6N   �� 5   
   -   5         ��Name$ btnAñadirP��5      $��AÑADIR PARQUE��6%   $
��Left=�6=   $��
116,64,0,0q�6X   $	��Top=�6l   $��35��6�   $	��182��6�   6�   �� 5   
   $
��Left=�6   $��	40,10,0,0q�6/   $
��Wrap=�6B   $��Nombre del Parque:��6V   $	��Top=�6p   $��14(�6�   �� 5   
   -   5         ��Name$ 
txbNombreP��5      $
��Left=�6&   $��
190,10,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��170��6�   $��26��6�   �� 5   
   $
��Left=�6   $��
40,242,0,0q�6/   $
��Wrap=�6C   $��Capacidad Juegos:��6W   $	��Top=�6p   �� 5   
   $
��Left=�6   $��
40,197,0,0q�6/   $
��Wrap=�6C   $��Nombre Atraccion:��6W   $	��Top=�6p   �� 5   
   -   5        $ txbCapacidad��5      $
��Left=�6(   $��189,237,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��171��6�   $��26��6�   �� 5   
   -   5        $ 
txbNombreA��5      $
��Left=�6&   $��189,197,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��171��6�   $��24��6�   �� 5   
   -   5        $ btnRegistrarJ��5      $��AÑADIR JUEGO��6(   $
��Left=�6?   $��116,296,0,0q�6Z   $	��Top=�6o   $��35��6�   $	��182��6�   6�   �� 5   
   -   5         ��Name$ 
cmbParques��5      $
��Left=�6'   $��115,142,0,0q�6B   $	��Top=�6W   $	��244��6o   $��28��6{   �� 5   
   $
��Left=�6   $��
40,147,0,0q�6/   $
��Wrap=�6C   $��PARQUE:��6W   $	��Top=�6f   $��14(�6~   �� 5   
   -   5        $ btnEliminarJ��5      $��ELIMINAR JUEGO��6'   $
��Left=�6@   $��115,418,0,0q�6[   $	��Top=�6p   $��35��6�   $	��182��6�   6�   �� 5   
   $
��Left=�6   $��
40,374,0,0q�6/   $
��Wrap=�6C   $��Juego a Eliminar:��6W   $	��Top=�6p   �� 5   
   -	   5        $ txbEliminarJ��5      $
��Left=�6(   $��189,369,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $	��170��6�   $��26��6�   �� 5   
   $
��Left=�6   $��
95,458,0,0q�6/   $
��Wrap=�6C   $*��$*Primero marque el parque en el CMB*��6W   $	��Top=�6�   $
��Bold"�6�   
���  ��6�   	� 5   
   -
   5         	�Name$ rdParque��5      $��Parque��6(   $
��Left=�69   $��
880,26,0,0q�6T   $	��Top=�6h   $��14(�6�   	� 5   
   -   5        $ rdJuego��5      $��
Atracción��6'   $
��Left=�6;   $��
880,55,0,0q�6V   $	��Top=�6j   $��14(�6�   �� 5   
   -   5        $ 	btnBuscar��5      $��BUSCAR��6$   $
��Left=�65   $��760,205,0,0q�6P   $	��Top=�6e   $��35��6}   $	��318��6�   6�   �� 5   
   $
��Left=�6   $��
760,38,0,0q�6/   $
��Wrap=�6C   $��Buscar:��6W   $	��Top=�6f   $��18(�6~   �� 5   
   -   5        $ txbBusqueda��5      $
��Left=�6'   $��760,109,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��318��6�   $��28��6�   �� 5   
   $
��Left=�6   $��876,156,0,0q�6/   $
��Wrap=�6D   $��Ingrese el Dato��6X   $	��Top=�6o   $
��Bold"�6�   
���  ��6�   �� 5   
   -   5        $ 	btnCerrar��5      $��CERRAR��6$   $��760,431,29,0q�65   $	��Top=�6K   $��35��6c   $	��318��6o   6{   �� 5    
   -   5        $ btnReset��5       $��RESET DATOS��6#   $��760,314,29,0q�69   $	��Top=�6O   $��34��6g   $	��318��6s   6   5"      5#      