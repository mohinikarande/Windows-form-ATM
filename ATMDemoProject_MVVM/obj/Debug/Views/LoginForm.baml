   M S B A M L   `   `   `  ????N  JATMDemoProject_MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ATMDemoProject_MVVM.ViewsATMDemoProject_MVVM.Views  5   	   M+clr-namespace:ATMDemoProject_MVVM.ViewModelATMDemoProject_MVVM.ViewModel  5   	   )    #ATMDemoProject_MVVM.Views.LoginForm   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:ATMDemoProject_MVVM.Views     5   	   :vm+clr-namespace:ATMDemoProject_MVVM.ViewModel     5   	     ? Title$  	LoginForm??5	   	   $	??450??6   $	??800??6(    ? WindowState$ 	Maximized=?64   
????  ?
???????$??22(?6w    ? 	Resources 5
      4   .ATMDemoProject_MVVM.ViewModel.ATMInfoViewModel   usViewModelObj??%   &	          5   
   6   5      .??5      ?  ? DataContext# [  6    ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6    ? ColumnDefinitions 5   
   ?? 5      $	??300 ?6   ?? 5      $	??300 ?6   .+?5   
   ?? $??0??6   $??Welcome To ATM??6   $??Center=?66   $??Center=?6S   
???????6n   ?? 5   
   $??1??6   $??
CardNumber??6   $
??Left=?62   $??50??6T   $??Center=?6a   $??20(?6?   
???????6?   ?? 5   
   $??2??6   $	??Pin??6   $
??Left=?6+   $??50??6M   $??Center=?6Z   $??20(?6|   
???????6?   ?? 5   
   -   5        $??txtCardNumber??5      $??1??6'   $??1??64   ??6D   ?? *UI_CardNumber+ ?? UpdateSourceTrigger$ PropertyChanged=??? 5   
   -   5        $??txtPinNumber??5      $??2??6&   $??1??63   ??6C   ?? *UI_Pin+$ PropertyChanged=??? 5   
   -   5        $??btnLogin??5      $??3??6"   $??1??6/   $??Login??6?   $??Center=?6O   $??Bottom=?6l   
???????
??? ? ???6?   ?? *LoginCommand+$ PropertyChanged=?5      5       