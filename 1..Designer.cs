namespace WindowsFormsApplication6
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
            this.directory = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.floder = new System.Windows.Forms.Button();
            this.files = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directory
            // 
            this.directory.Location = new System.Drawing.Point(630, 134);
            this.directory.Name = "directory";
            this.directory.Size = new System.Drawing.Size(79, 31);
            this.directory.TabIndex = 0;
            this.directory.Text = "Get Directory";
            this.directory.UseVisualStyleBackColor = true;
            this.directory.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(437, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(632, 225);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // floder
            // 
            this.floder.Location = new System.Drawing.Point(732, 134);
            this.floder.Name = "floder";
            this.floder.Size = new System.Drawing.Size(79, 31);
            this.floder.TabIndex = 2;
            this.floder.Text = "Get folder";
            this.floder.UseVisualStyleBackColor = true;
            this.floder.Click += new System.EventHandler(this.button2_Click);
            // 
            // files
            // 
            this.files.Location = new System.Drawing.Point(845, 134);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(79, 31);
            this.files.TabIndex = 3;
            this.files.Text = "Get Files";
            this.files.UseVisualStyleBackColor = true;
            this.files.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 675);
            this.Controls.Add(this.files);
            this.Controls.Add(this.floder);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.directory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button directory;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button floder;
        private System.Windows.Forms.Button files;
    }
}

