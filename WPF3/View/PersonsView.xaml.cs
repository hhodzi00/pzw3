using System;
using System.Collections.Generic;
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
using WPF3.ViewModel;


namespace PZW_3.View
{
    public partial class PersonsView : UserControl
    {
        public PersonsView()
        {
            InitializeComponent();

            this.DataContext = new PersonViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
