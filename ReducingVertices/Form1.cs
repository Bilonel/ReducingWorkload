using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System;
using System.Windows.Forms.Integration;
using System.Windows.Media.Media3D;
using HelixToolkit;
using HelixToolkit.Wpf;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Security.Cryptography;

namespace ReducingVertices
{
    public partial class Form1 : Form
    {
        int NumberOfIteration = 1;
        float SlopeFactor = 0.05f;
        string modelPath;
        string modelName;
        string modelData;
        Model model;
        Dictionary<Button, Panel> buttonPanel = new Dictionary<Button, Panel>();
        Panel last;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            modelPath = dialog.FileName;
            modelName = dialog.SafeFileName;
            modelData = System.IO.File.ReadAllText(modelPath);

            createModel();
            //model.printVerts(textBox2);

        }
        private void createModel()
        {
            model = new Model(modelData, SlopeFactor);
            showButton.Enabled = true;

            buttonPanel.Add(runPanelButton, runPanel);
            runButton.Enabled = true;
            PanelButton_Click(runPanelButton, null);
        }
        private void runButton_Click(object sender, EventArgs e)
        {
            progressText.Text = "Running...";
            progressBar1.Value = 0;
            model.Run();
            modelData = model.Save();
            createNewWindow("out 0",modelData);
            Iteration();
            
            progressText.Text = "Done";
            progressBar1.Value = 100;
        }
        void Iteration()
        {
            string data = modelData;
            int count = 1;
            while(--NumberOfIteration>0)
            {
                model = new Model(data, SlopeFactor);
                model.Run();
                data = model.Save();
                createNewWindow("out " + (count++).ToString(), data);
            }
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
            panel1.Controls.Add(host);

            info.Text = "Vertex Count : " + model.vertices.Count.ToString() + Environment.NewLine
                + "Face Count : " + model.faces.Count.ToString();
        }

        bool clickedButton1 = false;
        bool clickedButton2 = false;
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            clickedButton1 = true;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            clickedButton1 = false;
        }
        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
           // ((Button)sender).Location = new System.Drawing.Point(51, ((Button)sender).Location.Y);
            if (!clickedButton1) return;
            float buttonPos = ((Button)sender).PointToScreen(((Button)sender).Location).Y+((Button)sender).Size.Height/2;
            float diff = MousePosition.Y - buttonPos;
            if (diff > -170)
            {
                dragButton((Button)sender, 5, true);
            }
            else if (diff < -190)
            {
                dragButton((Button)sender, -5, true);
            }
            else return;
            float value = (float)((Button)sender).Location.Y / (((Button)sender).Parent.Size.Height - ((Button)sender).Size.Height);
            value = (10-MathF.Round(value*10))/10;
            labelSlopeValue.Text = (value).ToString();
            SlopeFactor = value;
        }
        private void dragButton(Button btn,int amount,bool isVertical=true)
        {
            if(isVertical)
            {
                int newLocation = btn.Location.Y + amount;
                if (newLocation>=0 && newLocation<=btn.Parent.Size.Height-btn.Size.Height)
                    btn.Location = new System.Drawing.Point(btn.Location.X, newLocation);
            }
            else
            {
                int newLocation = btn.Location.X + amount;
                if (newLocation >= 0 && newLocation <= btn.Parent.Size.Width-btn.Size.Width)
                    btn.Location = new System.Drawing.Point(newLocation, btn.Location.Y);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            clickedButton2 = true;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            clickedButton2 = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!clickedButton2) return;
            float buttonPos = ((Button)sender).PointToScreen(((Button)sender).Location).Y + ((Button)sender).Size.Height / 2;
            Console.WriteLine(buttonPos);
            float diff = MousePosition.Y - buttonPos;
            if (diff > -170)
            {
                dragButton((Button)sender, 4, true);
            }
            else if (diff < -190)
            {
                dragButton((Button)sender, -4, true);
            }
            else return;
            float value = (float)((Button)sender).Location.Y / (((Button)sender).Parent.Size.Height - ((Button)sender).Size.Height);
            value = ((int)((1-value)*5))+1;
            labelIterationValue.Text = (value).ToString();
            NumberOfIteration = ((int)value);
        }
        private void PanelButton_Click(object sender, EventArgs e)
        {
            if (last != null) last.Visible = false;
            if(buttonPanel.ContainsKey((Button)sender))
            {
                buttonPanel[(Button)sender].Visible = true;
                last = buttonPanel[(Button)sender];
            }
        }
        int extraPanelCount = 0;
        private void createNewWindow(string name,string data)
        {
            Button newButton = new Button();
            newButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            newButton.Dock = System.Windows.Forms.DockStyle.Left;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            newButton.Location = new System.Drawing.Point(0, 0);
            newButton.Name = "PanelButton"+(extraPanelCount).ToString();
            newButton.Size = new System.Drawing.Size(148, 67);
            newButton.TabIndex = 0;
            newButton.Text = name;
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += new System.EventHandler(this.PanelButton_Click);
            newButton.SendToBack();
            panel6.Controls.Add(newButton);

            Panel newPanel = new Panel();
            newPanel.BackColor = System.Drawing.Color.LightGray;
            newPanel.Location = new System.Drawing.Point(550, 90);
            newPanel.Name = "outPanel";
            newPanel.Size = new System.Drawing.Size(696, 629);
            newPanel.TabIndex = 7;
            newPanel.Visible = false;
            this.Controls.Add(newPanel);

            Form newF = new outForm(data);
            newF.TopLevel = false;
            newF.Dock = DockStyle.Fill;
            newPanel.Controls.Add(newF);
            buttonPanel.Add(newButton, newPanel);
            newF.BringToFront();
            newF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}