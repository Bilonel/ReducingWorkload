using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace ReducingVertices
{
    public partial class outForm : Form
    {
        string data="";
        string tempModelPath=Environment.CurrentDirectory+"/test.obj";
        ElementHost host;
        public outForm(string data)
        {
            if (string.IsNullOrEmpty(data)) { throw new Exception("DATA COULDN'T LOAD"); return; }
            this.data = data;
            InitializeComponent();
        }

        private void outForm_Load(object sender, EventArgs e)
        {
            ShowButton.Enabled = false;
            SaveButton.Enabled = false;

            System.IO.File.WriteAllText(tempModelPath, data); // Save DATA To Template Obj

            host = new ElementHost();
            host.Dock = DockStyle.Fill;

            // Create the WPF UserControl.
            WpfControlLibrary.UserControl1 uc = new WpfControlLibrary.UserControl1(tempModelPath);

            // Assign the WPF UserControl to the ElementHost control's Child property.
            host.Child = uc;
            if (host.Child != null) SaveButton.Enabled=ShowButton.Enabled = true;
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (this.Controls.IndexOf(host) < 0) // IF IS NOT EXIST
            {
                this.Controls.Add(host);
                info.Text = "Vertex Count : " + data.ToList<char>().FindAll(x=>x=='v').Count.ToString() + Environment.NewLine
                + "Face Count : " + data.ToList<char>().FindAll(x => x == 'f').Count.ToString();
            }
            else
            {
                this.Controls.Remove(host);
                info.Text = "";
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Object Dosyası |*.obj";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            string path = dialog.FileName;
            System.IO.File.WriteAllText(path, data);
        }

    }
}
