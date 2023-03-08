using JurnalDB.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JurnalDB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDBContext _db = new AppDBContext();
        public MainWindow()
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            CultureInfo.CurrentUICulture = new CultureInfo("ru-RU");
            Language = XmlLanguage.GetLanguage("ru-RU");

            InitializeComponent();
        }

        ~MainWindow() { _db.Dispose(); }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            


            List<Student> students = await _db.Students.ToListAsync();
            studentsDataGrid.ItemsSource = students;
            visitsDataGrid.ItemsSource = await _db.Visits
                .Include(visit => visit.Student)
                .ToListAsync();

            List<Group> groups = await _db.Groups.ToListAsync();
            groupsDataGrid.ItemsSource = groups;
            studentGroupComboBox.Items.Clear();
            studentGroupComboBox.ItemsSource = groups;

           
        }

        private async void studentsDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                Name = "",
                Email = "",
                Birthday = DateTime.Now,
            };

            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
            e.NewItem = student;
        }

        private async void dataGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            await _db.SaveChangesAsync();
        }

        private async void visitsDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            if (studentsDataGrid.SelectedItem is null)
            {
                MessageBox.Show("Выберите студента", "Внимание", MessageBoxButton.OK);
                return;
            }
            var visit = new Visit()
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Student = (Student)studentsDataGrid.SelectedItem,
                //Subject = (Subject)subjectsDataGrid.SelectedItem
            };

            await _db.Visits.AddAsync(visit);
            await _db.SaveChangesAsync();
            e.NewItem = visit;
        }

        private async void visitsDataGrid_PreviewCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Command == DataGrid.DeleteCommand)
            {
                var selectedItem = visitsDataGrid.SelectedItem as Visit;
                _db.Remove(selectedItem!);
                await _db.SaveChangesAsync();
                e.CanExecute = true;
            }
        }

        private async void groupsDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {

            var group = new Group()
            {
                Id = Guid.NewGuid(),
                Name = ""
                
            };

            await _db.Groups.AddAsync(group);
            await _db.SaveChangesAsync();
            e.NewItem = group;
        }

        private void groupsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Group selectedGroup = (Group)groupsDataGrid.SelectedItem;
            _db.Entry(selectedGroup)
                .Collection(it => it.Students)
                .LoadAsync();
            studentsDataGrid.ItemsSource = selectedGroup.Students;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student
            {
                Id = Guid.NewGuid(),
                Name = studentNameTextBox.Text,
                Email = studentEmailTextBox.Text,
                Birthday = studentBirthdayDatePicker.SelectedDate.GetValueOrDefault(), 
                Group = (Group)studentGroupComboBox.SelectedItem,
            };
            await _db.Students.AddAsync(student);
            await _db.SaveChangesAsync();
        }
    }
}