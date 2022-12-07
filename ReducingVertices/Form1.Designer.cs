namespace ReducingVertices
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uploadButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showButton = new System.Windows.Forms.Button();
            this.runPanel = new System.Windows.Forms.Panel();
            this.progressText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelIterationValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.labelSlopeValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.runButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.runPanelButton = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.runPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.Transparent;
            this.uploadButton.BackgroundImage = global::ReducingVertices.Properties.Resources.upload;
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Location = new System.Drawing.Point(10, 9);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(133, 85);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Location = new System.Drawing.Point(25, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 696);
            this.panel1.TabIndex = 6;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Transparent;
            this.showButton.BackgroundImage = global::ReducingVertices.Properties.Resources.show;
            this.showButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showButton.Enabled = false;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(10, 605);
            this.showButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(133, 85);
            this.showButton.TabIndex = 5;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // runPanel
            // 
            this.runPanel.BackColor = System.Drawing.Color.Gray;
            this.runPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.runPanel.Controls.Add(this.progressText);
            this.runPanel.Controls.Add(this.panel2);
            this.runPanel.Controls.Add(this.panel3);
            this.runPanel.Controls.Add(this.progressBar1);
            this.runPanel.Controls.Add(this.runButton);
            this.runPanel.Location = new System.Drawing.Point(550, 90);
            this.runPanel.Name = "runPanel";
            this.runPanel.Size = new System.Drawing.Size(696, 629);
            this.runPanel.TabIndex = 8;
            this.runPanel.Visible = false;
            // 
            // progressText
            // 
            this.progressText.BackColor = System.Drawing.Color.Transparent;
            this.progressText.Location = new System.Drawing.Point(176, 576);
            this.progressText.Name = "progressText";
            this.progressText.Size = new System.Drawing.Size(464, 26);
            this.progressText.TabIndex = 13;
            this.progressText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.labelIterationValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(278, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 401);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::ReducingVertices.Properties.Resources.panel1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 309);
            this.panel5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ReducingVertices.Properties.Resources.point;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(52, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 50);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // labelIterationValue
            // 
            this.labelIterationValue.BackColor = System.Drawing.Color.Transparent;
            this.labelIterationValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelIterationValue.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIterationValue.ForeColor = System.Drawing.Color.Black;
            this.labelIterationValue.Location = new System.Drawing.Point(0, 353);
            this.labelIterationValue.Name = "labelIterationValue";
            this.labelIterationValue.Size = new System.Drawing.Size(157, 48);
            this.labelIterationValue.TabIndex = 3;
            this.labelIterationValue.Text = "1";
            this.labelIterationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "ITERATION NUMBER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelSlopeValue);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(45, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 401);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ReducingVertices.Properties.Resources.panel1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 309);
            this.panel4.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ReducingVertices.Properties.Resources.point;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(52, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 50);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button2_MouseUp);
            // 
            // labelSlopeValue
            // 
            this.labelSlopeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelSlopeValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSlopeValue.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSlopeValue.ForeColor = System.Drawing.Color.Black;
            this.labelSlopeValue.Location = new System.Drawing.Point(0, 353);
            this.labelSlopeValue.Name = "labelSlopeValue";
            this.labelSlopeValue.Size = new System.Drawing.Size(157, 48);
            this.labelSlopeValue.TabIndex = 3;
            this.labelSlopeValue.Text = "0.05";
            this.labelSlopeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Candara", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "SLOPE FACTOR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(157, 543);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(525, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Transparent;
            this.runButton.BackgroundImage = global::ReducingVertices.Properties.Resources.run;
            this.runButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runButton.Enabled = false;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Location = new System.Drawing.Point(40, 517);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(108, 85);
            this.runButton.TabIndex = 1;
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Goldenrod;
            this.panel6.Controls.Add(this.runPanelButton);
            this.panel6.Location = new System.Drawing.Point(550, 23);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(696, 67);
            this.panel6.TabIndex = 6;
            // 
            // runPanelButton
            // 
            this.runPanelButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.runPanelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.runPanelButton.FlatAppearance.BorderSize = 0;
            this.runPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runPanelButton.Location = new System.Drawing.Point(0, 0);
            this.runPanelButton.Name = "runPanelButton";
            this.runPanelButton.Size = new System.Drawing.Size(148, 67);
            this.runPanelButton.TabIndex = 0;
            this.runPanelButton.Text = "RUN";
            this.runPanelButton.UseVisualStyleBackColor = false;
            this.runPanelButton.Click += new System.EventHandler(this.PanelButton_Click);
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(158, 605);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(305, 85);
            this.info.TabIndex = 6;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1261, 742);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.runPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reducing Workload PrtTyp 1.0";
            this.panel1.ResumeLayout(false);
            this.runPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel runPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelSlopeValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelIterationValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button runPanelButton;
        private System.Windows.Forms.Label progressText;
        private System.Windows.Forms.Label info;
    }
}