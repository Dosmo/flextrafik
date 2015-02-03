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
using ControllerLayer;

namespace ViewLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            FirmaList.Items.Add("LOL").SubItems.

            //ListFirmaer();

            
        }

        private void FirmaList_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        /*public void ListFirmaer()
        {
            Controller controller = new Controller();
            List<Firma> firmaListe = controller.GetFirma();
            

            FirmaList.Items.Add();
        }*/

    }
}
