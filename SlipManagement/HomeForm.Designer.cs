namespace SlipManagement
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.SlipsButton = new System.Windows.Forms.Button();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.SetupButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SlipsButton
            // 
            this.SlipsButton.Location = new System.Drawing.Point(17, 213);
            this.SlipsButton.Name = "SlipsButton";
            this.SlipsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SlipsButton.Size = new System.Drawing.Size(225, 45);
            this.SlipsButton.TabIndex = 0;
            this.SlipsButton.Text = "Slips";
            this.SlipsButton.UseVisualStyleBackColor = true;
            this.SlipsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.Location = new System.Drawing.Point(17, 264);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeesButton.Size = new System.Drawing.Size(225, 45);
            this.EmployeesButton.TabIndex = 1;
            this.EmployeesButton.Text = "Emplaoyes";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            // 
            // SetupButton
            // 
            this.SetupButton.Location = new System.Drawing.Point(17, 315);
            this.SetupButton.Name = "SetupButton";
            this.SetupButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SetupButton.Size = new System.Drawing.Size(225, 45);
            this.SetupButton.TabIndex = 2;
            this.SetupButton.Text = "Setup";
            this.SetupButton.UseVisualStyleBackColor = true;
            this.SetupButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(17, 366);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuitButton.Size = new System.Drawing.Size(225, 45);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.ProfileButton);
            this.splitContainer1.Panel1.Controls.Add(this.EmployeesButton);
            this.splitContainer1.Panel1.Controls.Add(this.QuitButton);
            this.splitContainer1.Panel1.Controls.Add(this.SetupButton);
            this.splitContainer1.Panel1.Controls.Add(this.SlipsButton);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProfileButton
            // 
            this.ProfileButton.Location = new System.Drawing.Point(17, 15);
            this.ProfileButton.Name = "ProfileButton";
            this.ProfileButton.Size = new System.Drawing.Size(225, 130);
            this.ProfileButton.TabIndex = 1;
            this.ProfileButton.Text = "button1";
            this.ProfileButton.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HomeForm";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SlipsButton;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button SetupButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ProfileButton;
    }
}

