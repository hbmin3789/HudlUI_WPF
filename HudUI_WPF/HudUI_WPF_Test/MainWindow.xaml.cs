using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HudUI_WPF_Test
{
    public class Person : BindableBase
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }

    public class ViewModel : BindableBase
    {
        private ObservableCollection<Person> _personList = new ObservableCollection<Person>();
        public ObservableCollection<Person> PersonList
        {
            get => _personList;
            set => SetProperty(ref _personList, value);
        }

        public ViewModel()
        {
            for(int i = 0; i < 20; i++)
            {
                PersonList.Add(new Person() { Name = "person" + i.ToString() });
            }
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
        }
    }
}
