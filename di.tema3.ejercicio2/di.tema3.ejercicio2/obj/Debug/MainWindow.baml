   M S B A M L   `   `   `  ????N  Jdi.tema3.ejercicio2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:di.tema3.ejercicio2di.tema3.ejercicio2  5   	   $    di.tema3.ejercicio2.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   c _MaterialDesignThemes.MahApps, Version=0.2.3.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_	 [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a=mat1http://materialdesigninxaml.net/winfx/xaml/themes  	 5   	   /local!clr-namespace:di.tema3.ejercicio2  	 5   	   M
 IFluent, Version=9.0.0.0, Culture=neutral, PublicKeyToken=3e436e32a8c5546ffluenturn:fluent-ribbon 
 5	   	     ? Icon$  Iconos/matisse.png??5   	    ? Title$ INVENTARIO MATISSE??5   	   $	??450??6$   $	??800??61   (  "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@?5      ?? .??5      ' 	 !MaterialDesignThemes.Wpf.PackIcon     Kind$ Account=?6   5      5      .??5      ? .+?5   
    
 Fluent.Ribbon     QuickAccessItems 5        
 Fluent.QuickAccessMenuItem  5       m? 	IsChecked . 5         Menu 5       
 Fluent.Backstage  5         Content. 5        
 Fluent.BackstageTabControl  .@?5        
 Fluent.BackstageTabItem     Header$ Opciones??62   5!      5"      	   Tabs.	 5$      	 
 Fluent.RibbonTabItem	  
 	  Header$
 	PRESTAMOS??6#    	  Groups. 5%      
 
 Fluent.RibbonGroupBox
  $??Operaciones??6(   .@?5&       
 Fluent.Button     	LargeIcon$ Iconos/salida.png??6$      Header$ Salida??6B     5'      $ Iconos/devolucion.png??6$   $ Devolución??6F   5(      
  5*      $??
Búsquedas??6(   .@?5+      ?? $??Por número de serie??6    $
??Bold"?6;   $??Center=?6M    
 Fluent.TextBox  5,      $	??150??6%   $??0,0,10,0q?61   5-      
  5/      $??Listados??6(   .@?50        $ Iconos/pendientes.png??6$   $ 
Pendientes??6F   ???#FF54156Z   51      52      	  54      $
 
ARTÍCULOS??6#   . 55      
  $??
Artículos??6(   .@?56        $ Iconos/addarticulo.png??6$   $ Nuevo??6G     57      $ Iconos/gesarticulo.png??6$   $ Editar??6G     58      $ Iconos/listado.png??6$   $ Listado??6C   ???#00008B6T   59      
  5;      $??Modelo Artículo??6(   .@?5<        $ Iconos/iconmodelo.png??6$   $ Nuevo??6F     5=      $ Iconos/caja.png??6$   $ Editar??6@     5>      $ Iconos/listamodelos.png??6$   $ Listado??6H   5?      5@      	  5B      $
 ADMINISTRACIÓN??6#   . 5C      
  $??
Artículos??6,   .@?5D        $ Iconos/adduser.png??6$   $ Nuevo??6C     5E      $ Iconos/gesusuario.png??6$   $ Editar??6F     5F      $ Iconos/resetclave.png??6$   $ Contraseñas??6F     5G      $ Iconos/listausuarios.png??6$   $ Listado??6I   5H      
  5J      $??Modelo Artículo??6,   .@?5K        $ Iconos/papelera.png??6(   $ Articulo??6H   ???#8B00006Z     5L      $ Iconos/papelera2.png??6(   $ Modelo??6I   ???#FF00006Y     5M      $ Iconos/usuario.png??6(   $ Usuario??6G   ???#FF45006X   5N      
  5P      $??STOCK??6(   .@?5Q        $ Iconos/stock.png??6$   5R      5S      	  5U      $
 
INVENTARIO??6#   . 5V      
  $??Espacios??6(   .@?5W        $ Iconos/espacio.png??6$   $ Espacios??6C     5X      $ Iconos/check.png??6$   $ Chequeo??6A     5Y      $ Iconos/espacios.png??6$   $ 
Inventario??6D   5Z      5[      	  5]      $
 INFORMACIÓN??6#   . 5^      
  $??Informes??6(   .@?5_        $ Iconos/informe.png??6$   $ Informe??6C   5`      
  5b      $??	Gráficos??6(   .@?5c        $ Iconos/charts.png??6$   $ Charts??6B   5d      5e      5f      5g      5h      