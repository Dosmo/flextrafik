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
using ModelLayer;

//Klasse Eksempel
class Animal
{
    public string Firmanavn { get; set; }
    public int CVR { get; set; }
    public string Firmanavn2 { get; set; }
}

namespace ViewLayer
{
    public partial class MainWindow : Window
    {
        Controller _controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
            List<Firma> firmList = _controller.GetFirma();
            foreach (Firma firm in firmList)
            {
                FirmaList.Items.Add(firm);
            }
     
             
        }

    }
}
