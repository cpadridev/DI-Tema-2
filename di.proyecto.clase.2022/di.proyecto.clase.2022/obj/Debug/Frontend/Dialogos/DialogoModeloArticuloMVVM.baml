   M S B A M L   `   `   `  ????  di.proyecto.clase.2022I    Cdi.proyecto.clase._2022.Frontend.Dialogos.DialogoModeloArticuloMVVM   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962ac _MaterialDesignThemes.MahApps, Version=0.2.3.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a=mat1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     ? 
ResizeMode$  NoResize=?5	   	   (  "MahApps.Metro.Controls.MetroWindow   ShowCloseButton .     ShowMaxRestoreButton .     ShowMinButton .   ? Title$ GESTIÓN MODELO ARTÍCULO??5   	    ? SizeToContent$ WidthAndHeight=?6)   .??5      ? $??20, 0, 20, 0q?6    ? ColumnDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6    ? RowDefinitions 5   
   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? $??2??6   $??Modelo Artículo??6(   $??42(?6?   $??0, 25, 0, 25q?6M   $??Center=?6c   ?? 5   
   -   5         ??Name$ 	txtNombre??5   N   $??1??6   $??30q?6   $	??200??6+   
????? ?	 ?? 	MaxLength$	 45??6?   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Nombre *??6?   ??6a   ?? *modeloArticulo.nombre+6?   ?? 5    
   -   5        $ txtMarca??5    ^   $??1??6   $??1??6   $??30q?6/   $	??200??6;   
????? ?$		 255??6?   $
 Marca *??6?   ??6p   ?? *modeloArticulo.marca+6?   ?? 5"   
   -   5        $ 	txtModelo??5"   P   $??2??6   $??30q?6    $	??200??6-   
????? ?$		 255??6?   $
 Modelo??6?   ??6c   ?? *modeloArticulo.modelo+6?   ?? 5$   
   -   5         ??Name$ cbxTipoModelo??5$   _   $??2??6   $??1??6    $??10q?60   $	??200??6<   
????? ? ?? 
IsEditable .  ?? 
IsReadOnly .  ?? Text$ Selecciona un tipo??6?    ?? DisplayMemberPath$ nombre??6  ??6v   ?? *
listaTipos+ ?? SelectedItem 6?   ?? *modeloArticulo.tipoarticulo+6  ?? 5&   
   -   5        $ txtDescripcion??5&     $??3??6   $??2??6   $??10, 30, 0, 10q?63    ?? TextWrapping$
 Wrap=?6v    !  MaterialDesignOutlinedTextBox#??[  6?   $	??400??6?   $??80??6?   .  (MaterialDesignThemes.Wpf.TextFieldAssist   TextFieldCornerRadius$ 25??6?   
????? ???6J   ?? *modeloArticulo.descripcion+.??67   ? 	Resources 5'      (  "MaterialDesignThemes.Wpf.SmartHint ?? 
TargetType ?? Property ?? Value??%V   '        ?? 5(      "  6   .?5)      ??  ? ??$ Center=?6<   5*      5+      .??6!   
 5,      ?? 5-      $??Descripción??6   
???????6/   .??5.   #   5/      ?? 51   
   $??4??6   $??2??6!   $+??%Los campos con un * son obligatorios.??65   $
??Bold"?6b   $??Center=?6t   ?? 53   
   $??5??6   $??2??6"    ?? Orientation$ 
Horizontal=?66   $??Center=?6O   $??0, 30, 0, 30q?6l   .+?54      ?? -   5        $??0, 0, 30, 0q?54      $??Guardar??6*    ?? 	IsDefault .    MaterialDesignOutlinedButton#??[ 6M   
??? ? ?
???????+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 25??6?   $??48??6?   $	??130??6?    ? Cursor$
 Hand??6?   ?? 55      -   5        $??30, 0, 0, 0q?55      $??Cancelar??6*    ?? IsCancel . #??[ 6M   
??? ? ?
???????$ 25??6?   $??48??6?   $	??130??6?   6?   56      57      58      