using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using HelixToolkit;
using HelixToolkit.Wpf;

namespace ReducingVertices
{
    public partial class Form1 : Form
    {
        string modelPath;
        string modelName;
        string modelData;
        Model model;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Object Dosyası |*.obj";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            modelPath = dialog.FileName;
            modelName = dialog.SafeFileName;
            modelData = System.IO.File.ReadAllText(modelPath);

            textBox1.Text = modelData;
            createModel();
            //model.printVerts(textBox2);
        }
        private void createModel()
        {
            model = new Model(modelData);
            runButton.Enabled = true;
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            model.Run();
            model.printFaces(textBox1);
            saveButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        int count = 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
            string data = model.Save();
            textBox2.Text = data;
            System.IO.File.WriteAllText(modelPath.Insert(modelPath.Length - 4, "_copy"), data);
            showButton.Enabled = true;
            if (count-- > 0) restart();
        }
        void restart()
        {
            modelPath = modelPath.Insert(modelPath.Length - 4, "_copy");
            modelData = System.IO.File.ReadAllText(modelPath);
            createModel();
            runButton_Click(null, null);
            saveButton_Click(null, null);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ElementHost host = new ElementHost();
            host.Dock = DockStyle.Fill;

            // Create the WPF UserControl.
            WpfControlLibrary.UserControl1 uc =
                new WpfControlLibrary.UserControl1(modelPath);

            // Assign the WPF UserControl to the ElementHost control's
            // Child property.
            host.Child = uc;

            // Add the ElementHost control to the form's
            // collection of child controls.
            this.Controls.Add(host);
        }
    }
}