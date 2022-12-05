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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadButton
            // 
            this.uploadButton.BackgroundImage = global::ReducingVertices.Properties.Resources.upload;
            this.uploadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uploadButton.Location = new System.Drawing.Point(12, 12);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(169, 83);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // runButton
            // 
            this.runButton.BackgroundImage = global::ReducingVertices.Properties.Resources.run;
            this.runButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(12, 111);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(169, 83);
            this.runButton.TabIndex = 1;
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImage = global::ReducingVertices.Properties.Resources.save;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(12, 209);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(169, 83);
            this.saveButton.TabIndex = 2;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(747, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 426);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(729, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 426);
            this.textBox2.TabIndex = 4;
            // 
            // showButton
            // 
            this.showButton.BackgroundImage = global::ReducingVertices.Properties.Resources.show;
            this.showButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showButton.Enabled = false;
            this.showButton.Location = new System.Drawing.Point(12, 310);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(169, 83);
            this.showButton.TabIndex = 5;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.uploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button showButton;
    }
}