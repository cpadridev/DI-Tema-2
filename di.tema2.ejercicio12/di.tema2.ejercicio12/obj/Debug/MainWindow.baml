   M S B A M L   `   `   `  ????O  Kdi.tema2.ejercicio12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:di.tema2.ejercicio12di.tema2.ejercicio12  5   	   %    di.tema2.ejercicio12.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   c _MaterialDesignThemes.MahApps, Version=0.2.3.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a=mat1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   0local"clr-namespace:di.tema2.ejercicio12   5   	     ? WindowStyle$
  None=?5
   	    ? AllowsTransparency . 
?????? (  "MahApps.Metro.Controls.MetroWindow   ShowTitleBar .     ShowCloseButton .     ShowMaxRestoreButton .     ShowMinButton .   ? Title$ 
MainWindow??5   	   $	??450??6   $	??800??6)   .??5      ? ???#DE243A$??30q?6     ? ColumnDefinitions 5   
   ?? 5   
   $??* ?6   ?? 5   
   $??* ?6   .+?5   
   ? $??25, 40, 0, 0q?6    ? RowDefinitions 5      ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    ?? 5      $
??Auto ?6    .+?5      ?? $??Bienvenidos !??6   
???????$??32(?6@   $
??Bold"?6N   ?? 5      $??INVENTARIO MATISSE??6   $??1??62   
???????$??16(?6R   $??0, 20, 0, 0q?6`   ?? 5       $!??Iconos/logo-ies-matisse.png??6   $??2??69   $	??100??6F   $	??100??6S   $
??Left=?6_   $??-20, 150, 0, 0q?6z   ?? 5!      $??IES HENRI MATISSE??6   $??3??61   
???????6>   5"      ? 5#   
   $??1??6   
???????$??25, -25, 45, -25q?62    5$      ?? 5%      $
??Auto ?6    ?? 5&      $
??Auto ?6    ?? 5'      $
??Auto ?6    ?? 5(      $
??Auto ?6    ?? 5)      $
??Auto ?6    ?? 5*      $
??Auto ?6    .+?5,      ?? $??LOGIN??6   $??24(?6%   $??Center=?63   $??0,40,0,0q?6P   ???#e243566b   ?? 5-      $??1??6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Nombre usuario??6#   $??0,30,0,0q?6H   $	??200??6Z   
???????$??0, 5, 0, 10q?6y   ?? 5.      $??2??6   $	 Clave acceso??6#   $??0,30,0,0q?6F   $	??200??6X   
???????$??0, 5, 0, 10q?6w   ?? 5/      $??3??6   $??LOGIN??6"   $??0,35,0,0q?62   $	??200??6D   
 ? Cursor$

 Hand??6P   ?? 50      $??4??6   $??¿TIENES CUENTA???6"       MaterialDesignOutlinedButton#??[  6<   
???????$??0,35,0,0q?6?   $	??200??6?   $

 Hand??6?   ?? 51      $??5??6   $!??¿Olvidaste la Contraseña???6"   #??[  6F   
?????? $??0,35,0,0q?6?   $	??200??6?   $

 Hand??6?   52      53      54      