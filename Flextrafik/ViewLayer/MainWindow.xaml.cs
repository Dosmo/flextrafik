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
        public MainWindow()
        {
            InitializeComponent();

            FirmaList.Items.Add(new Animal() { Firmanavn = "FirmaNavn1", CVR = 14253698, Firmanavn2 = "FirmaNavn2_1" });
            FirmaList.Items.Add(new Animal() { Firmanavn = "FirmaNavn2", CVR = 85479635, Firmanavn2 = "FirmaNavn2_2" });
            FirmaList.Items.Add(new Animal() { Firmanavn = "FirmaNavn3", CVR = 25478569, Firmanavn2 = "FirmaNavn2_3" });
        }
    }
}
