   M S B A M L   `   `   `  ????Q  Mdi.repaso.navidad.2021, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:di.repaso.navidad._2021di.repaso.navidad._2021  5   	   (    "di.repaso.navidad._2021.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   c _MaterialDesignThemes.MahApps, Version=0.2.5.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a=mat1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   3local%clr-namespace:di.repaso.navidad._2021   5   	     ? WindowState$  	Maximized=?5	       ? Title$ REPASO NAVIDAD??5
   	   $	??450??6    $	??800??6-   (  "MahApps.Metro.Controls.MetroWindow   RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@?5      ?? ??6   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$
 User=?5      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??1* ?6   ?? 5      $??9* ?6   .+?5   
   *  $MahApps.Metro.Controls.HamburgerMenu  -   5          Name$ hamMenuPrincipal??5      
???????   DisplayMode$ CompactInline=?5         MenuItemTemplateIcon   ItemTemplate# [  5         OptionsItemTemplate# [  5      $??2??5      $??
0,0,-0.4,0q?6!   	   ItemsSource	 5      8  2MahApps.Metro.Controls.HamburgerMenuItemCollection  5      2  ,MahApps.Metro.Controls.HamburgerMenuIconItem  5      .  (MahApps.Metro.Controls.HamburgerMenuItem
   Label$
 GESTION OFICINAS??6P   2  ,MahApps.Metro.Controls.HamburgerMenuItemBase
   Tag$ GESTION OFICINAS??5   0      Icon 5   0     $
 City=?5   0     5       $
 GESTION EMPLEADOS??6[   $ GESTION EMPLEADOS??5!   0    5    0     $ CustomerService=?5!   0     5"      $
 GESTION PRODUCTOS??6R   $ GESTION PRODUCTOS??5#   0    5"   0     $ Flower=?5#   0     5$      $
 GESTION PEDIDOS??6Q   $ GESTION PEDIDOS??5%   0    5$   0     $ Email=?5%   0     5&      $
 GESTION CLIENTES??6U   $ GESTION CLIENTES??5'   0    5&   0     $ 	UserBadge=?5'   0   5(         OptionsItemsSource 5+        5,        5-      $
 Ayuda??6P    60     $
 Help=?5.      5/      51      52      53      