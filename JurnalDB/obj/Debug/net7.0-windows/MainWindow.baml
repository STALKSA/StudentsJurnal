   M S B A M L   `   `   `  ????  JurnalDB    JurnalDB.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          ? Title$  
MainWindow??5   	   $	??677??6   $
??1006??6)   .??5	      ? $	??NaN??6   $??10,-19,10,71q?6   .+?5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ visitsDataGrid??5
      $	??NaN??6+   $??33,477,33,-58q?68   $	??NaN??6O   5        5   
   -   5        $ groupsDataGrid??5      $??10,40,590,345q?6+   5      ?? 5   
   $
??Left=?6   $	??340??6.   $??Студенты??5      $??
415,40,0,0q?6%   $	??Top=?5      $	??561??6+   .??5      ]? -   5         ]?Name$ loadingStackPanel??5      $??Stretch=?5      $	??Top=?5      .+?5      ?? .+?5        -   5        $ studentsDataGrid??5      $	??171??69   $	??NaN??6F      AutoGenerateColumns$ False??5         CanUserAddRows$ False??5         Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя??5"   %      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 5#   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5!   1   ?? *Name+5#   %     5$      $ День рождения??5%   %   $	 120 5&   %    5$   1   ?? *
Birthdat+5&   %     5'      $ Мэил??5(   %   $	 110 5)   %    5'   1   ?? *Email+5)   %     5*      $  Группа??5+   %   $	 110 5,   %   	   
IsReadOnly$
	 True??5-   %    5*   1   ?? *Group+5-   %     5.      $$ Кол-во посещений??5/   %   $	 200 50   %   $
	 True??51   %    5.   1   ?? *
VisitCount+51   %   54      ? 55      
 ? Orientation$
 
Horizontal=?6    .+?56      ??  ?? Orientation$ 
Horizontal=?6%   .+?57      ?? $??16(?6$   .??62   Имя67   ?? 58      -   5         ??Name$ studentNameTextBox??58   &   $	??7,3q?59       ?? TextWrapping$
 Wrap=?5:      $?? ??61   $	??120??69   5<      ?? 5=      $ 
Horizontal=?6%   .+?5>      ?? $??16(?6$   .??62   Дата рождения6A   (  "System.Windows.Controls.DatePicker  5?      -   5        $??studentBirthdayDatePicker??5?   )   $??16(?6J   6Z   5@      ?? 5A      $ 
Horizontal=?6%   .+?5B      ?? $??16(?6$   .??62   Email69   ?? 5C      -   5        $ studentEmailTextBox??5C   &   $	??7,3q?5D      $
 Wrap=?5E      $?? ??61   $	??120??69   5G      ?? 5H      $ 
Horizontal=?6%   .+?5I      ?? $??16(?6$   $	??7,3q?62   .??6?   Группа6G   ?? 5J      -	   5         ??Name$ studentGroupComboBox??5J   '   $	??7,3q?6E   $	??100??6R   $??16(?6^    ?? DisplayMemberPath$  ??5K   '   5L      5M      5N      ? 5Q       ? ColumnDefinitions 5R      ?? 5S      ?? 5T      .+?5V      ?? $??0??6   $+??%Сохранить изменения??5W      $??40??5X      $??0,0,4,0q?6)   ?? 5Z      -
   5        $??1??5Z      $(??"добавить как новый??5[      $??40??5\      $??Stretch=?5]      6;   5_      5`      5b      5d      5f      5g      