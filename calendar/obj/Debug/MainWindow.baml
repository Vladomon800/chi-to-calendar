   M S B A M L   `   `   `  ????C  ?calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:calendarcalendar  5   	       calendar.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:calendar     5   	   -   5          ? WindowState$  	Maximized=?5   	    ? Title$ 
MainWindow??5	   	   $
??1080??6   $
??1920??6*   .??5
      ? .+?5   
    ? -   5        $??OneDayCalendarView??5        ? Source$ OneDayCalendarGrid.xaml??6*   $??0,0,-3,0q?6K   $??Right=?6]   $??Bottom=?6y   $	??982??6?   $
??1658??6?   ?? 5   
   -   5         ??Name$ CalendarView??5      $??Right=?6)   $??	0,15,10,0q?6E   $	??Top=?6X    ?? SelectedIndex$ 0??6p   $??92??6?   .@?5      ?? -   5         ??Name$ CalendarViewDay??5      $??День??64   6C   ?? 5      -   5        $ CalendarViewWeek??5      $??Неделя??65   6F   ?? 5      -   5        $ CalendarViewMonth??5      $??
Месяц??66   6F   ?? 5      -   5        $ CalendarViewYear??5      $??Год??65   6C   ?? 5      -   5        $ CalendarViewTable??5      $??Расписание??66   6K   ?? 5      -	   5        $ CalendarView4Days??5      $??4 дня??66   6F   5      ?? 5   
   -
   5         ??Name$ settings_image??5      $??Right=?6[   $??25??6w   $??
0,15,120,0q?6?   $	??Top=?6?   $??23??6?   $??images/settings.png??6?   ?? 5   
   -   5         ??Name$ settings_listbox??5      $y?Hidden=?6,   $??Right=?6@   $??86??6\   $	??Top=?6h   $	??159??6?    ?? SelectionMode$ Single=?6?   $??0,0,10,0q?6?   .@?5      ?? $??Настройка??6   ?? 5      $??Корзина??6   ?? 5      -   5        	 ??Name$	 ViewAndColor??5      $,??&Представление и цвет??60   6P   ?? 5      $??Распечатать??6   5      ?? 5   
   -   5        
 ??Name$
 CreateCalendar??5      $??	21,0,0,41q?6)   $??15(?6<   
???????$
??Left=?6z   $??Bottom=?6?   $??42??6?   $	??161??6?   $'??!Создать календарь??6?   ?? 5   
   -   5         ??Name$ 	Calendars??5      $??21,556,1730,88q?6&   ?? 5   
   $??Мои календари??6   $??Center=?6(   $
??Left=?6L   $??
21,511,0,0q?6g   $	??Top=?6{   $	??161??6?   ?? 5   
   -   5        $??Сегодня??5      $
??Left=?6#   $??324,13,0,982q?6>   $??90??6T   6_   5      5       