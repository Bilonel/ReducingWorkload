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
            this.runButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outPanel = new System.Windows.Forms.Panel();
            this.runPanel = new System.Windows.Forms.Panel();
            this.valueLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.outPanel.SuspendLayout();
            this.runPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.BackColor = System.Drawing.Color.Transparent;
            this.uploadButton.BackgroundImage = global::ReducingVertices.Properties.Resources.upload;
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadButton.Location = new System.Drawing.Point(2, 4);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(133, 85);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.UseVisualStyleBackColor = false;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.Color.Transparent;
            this.runButton.BackgroundImage = global::ReducingVertices.Properties.Resources.run;
            this.runButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runButton.Enabled = false;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Location = new System.Drawing.Point(190, 552);
            this.runButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(301, 85);
            this.runButton.TabIndex = 1;
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackgroundImage = global::ReducingVertices.Properties.Resources.save;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(564, 603);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(133, 85);
            this.saveButton.TabIndex = 2;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.Transparent;
            this.showButton.BackgroundImage = global::ReducingVertices.Properties.Resources.show;
            this.showButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showButton.Enabled = false;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(427, 603);
            this.showButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(133, 85);
            this.showButton.TabIndex = 5;
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uploadButton);
            this.panel1.Location = new System.Drawing.Point(25, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 696);
            this.panel1.TabIndex = 6;
            // 
            // outPanel
            // 
            this.outPanel.Controls.Add(this.runPanel);
            this.outPanel.Controls.Add(this.showButton);
            this.outPanel.Controls.Add(this.saveButton);
            this.outPanel.Location = new System.Drawing.Point(534, 27);
            this.outPanel.Name = "outPanel";
            this.outPanel.Size = new System.Drawing.Size(699, 692);
            this.outPanel.TabIndex = 7;
            // 
            // runPanel
            // 
            this.runPanel.Controls.Add(this.label2);
            this.runPanel.Controls.Add(this.trackBar2);
            this.runPanel.Controls.Add(this.label3);
            this.runPanel.Controls.Add(this.label1);
            this.runPanel.Controls.Add(this.progressBar1);
            this.runPanel.Controls.Add(this.trackBar1);
            this.runPanel.Controls.Add(this.valueLabel);
            this.runPanel.Controls.Add(this.runButton);
            this.runPanel.Location = new System.Drawing.Point(0, 0);
            this.runPanel.Name = "runPanel";
            this.runPanel.Size = new System.Drawing.Size(699, 692);
            this.runPanel.TabIndex = 8;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.valueLabel.Location = new System.Drawing.Point(117, 355);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(65, 33);
            this.valueLabel.TabIndex = 3;
            this.valueLabel.Text = "0.05";
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackBar1.Location = new System.Drawing.Point(130, 99);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(64, 253);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(105, 653);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(479, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "SLOPE FACTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(359, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "ITERATION NUMBER";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.Gray;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.trackBar2.LargeChange = 3;
            this.trackBar2.Location = new System.Drawing.Point(462, 99);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(64, 253);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(449, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1261, 742);
            this.Controls.Add(this.outPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reducing Workload PrtTyp 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.outPanel.ResumeLayout(false);
            this.runPanel.ResumeLayout(false);
            this.runPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel outPanel;
        private System.Windows.Forms.Panel runPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label valueLabel;
    }
}