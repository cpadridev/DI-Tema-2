   M S B A M L   `   `   `  ????N  Jdi.tema2.ejercicio9, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:di.tema2.ejercicio9di.tema2.ejercicio9  5   	   $    di.tema2.ejercicio9.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   c _MaterialDesignThemes.MahApps, Version=0.2.3.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a=mat1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   /local!clr-namespace:di.tema2.ejercicio9   5   	   (  "MahApps.Metro.Controls.MetroWindow    ShowTitleBar  .     ShowCloseButton .     ShowMaxRestoreButton .     ShowMinButton .   ? Title$ 
MainWindow??5   	   $	??450??6   $	??800??6)   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??* ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   A? $	??550??6   $	??600??6   $??-200, -60, 0, 0q?6+   $??6??6D   ??5      ?? 5       ?? 
StartPoint$ 0,0.5&?6&    ?? EndPoint$ 1,0.5&?69   .??5      ? 	 ? Color$	 #FF9924??6#   
 ? Offset$	
 0.0Q?63   ? 5       $	 #FFC147??6#   $	
 1.0Q?63   5!      5#      ?? 5$   
   $??2??6   $??0, 10, 0, 0q?6"   $??2??67   .+?5%      ?? $??IES HENRI MATISSE??6   $??24(?61   $
??Bold"?6?   
???????$??50, 0, 0, 0q?6d   ?? 5&      $??Aplicación de Inventario??6   $??16(?68   
???????$??50, 0, 0, 0q?6Y   5'      ?? 5(   
   $??1??6   $??Iconos/user.png??6    $??90??69   $??0, 50, 0, 0q?6E   ?? 5)   
   $??1??6   $??1??6$   $??Center=?61   $??Introduce los datos??6N   
???????6i   ?? 5*   
   $??1??6   $??2??6"      MaterialDesignFilledTextBox#??[  6/   ???#F2F2F2.  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 25??6y   $??48??6?   $	??300??6?   .??6?   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 5+      ?? 5,       ?? Orientation$ 
Horizontal=?6   $??0, -5, 0, 0q?66   .+?5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Email=?6#   ?? 5.      $??10, 0, 0, 0q?6    $??Cuenta de Correo??65   5/      .??50   #   51      G? 52   
   $??1??6   $??3??6&    # MaterialDesignFilledPasswordBox#??[ 63   ???#F2F2F2$ 25??6?   $??48??6?   $	??300??6?    53      ?? 54      $ 
Horizontal=?6   $??0, -5, 0, 0q?66   .+?55        $
 Lock=?6#   ?? 56      $??10, 0, 0, 0q?6    $??Clave de Acceso??65   57      59      ?? 5:   
   $??1??6   $??4??6!   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25??6.   $	??200??6Q   $??Login??6]   ??5;      ?? 5<      $ 0,0.5&?6&   $ 1,0.5&?69   .??5=      ? $	 #FF9924??6#   $	
 0.0Q?63   ? 5>      $	 #FFC147??6#   $	
 1.0Q?63   5?      5A      ?? 5B   
   $??1??6   $??5??6%   $ 
Horizontal=?62   $??Center=?6K   $??0, -15, 0, 100q?6h   .+?5C      ?? $??Nuevo Usuario???6   $??Center=?6.   $??12(?6I   
???????6W   ?? 5D      $??
Registrate??6   $??12(?6*   ???#F4B245   MaterialDesignOutlinedButton#??[ 6M   
?????? 6?   5E      5F      5G      