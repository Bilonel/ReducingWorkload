using HelixToolkit.Wpf;
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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlLibrary
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(string path)
        {
            InitializeComponent();
            load3dModel(path);
        }
        public void load3dModel(string path)
        {
            ObjReader CurrentHelixObjReader = new ObjReader();
            // Model3DGroup MyModel = CurrentHelixObjReader.Read(@"D:\3DModel\dinosaur_FBX\dinosaur.fbx");
            Model3DGroup MyModel = CurrentHelixObjReader.Read(path);
            DirectionalLight newL = new DirectionalLight(Color.FromRgb(255, 215, 215), new Vector3D(-5, -5, -15));
            MyModel.Children.Add(newL);
            model.Content = MyModel;

        }
    }
}