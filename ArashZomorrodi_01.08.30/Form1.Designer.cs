namespace ArashZomorrodi_01._08._30
{
    partial class MainForm
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
            this.myNewTextbox1 = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.myNewButton1 = new ArashZomorrodi_01._08._30.MyNewButton();
            this.SuspendLayout();
            // 
            // myNewTextbox1
            // 
            this.myNewTextbox1.Location = new System.Drawing.Point(82, 63);
            this.myNewTextbox1.Multiline = true;
            this.myNewTextbox1.Name = "myNewTextbox1";
            this.myNewTextbox1.Size = new System.Drawing.Size(243, 80);
            this.myNewTextbox1.TabIndex = 1;
            this.myNewTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myNewTextbox1_KeyPress);
            // 
            // myNewButton1
            // 
            this.myNewButton1.Location = new System.Drawing.Point(105, 209);
            this.myNewButton1.Name = "myNewButton1";
            this.myNewButton1.Size = new System.Drawing.Size(199, 71);
            this.myNewButton1.TabIndex = 0;
            this.myNewButton1.Text = "myNewButton1";
            this.myNewButton1.UseVisualStyleBackColor = true;
            this.myNewButton1.Click += new System.EventHandler(this.myNewButton1_Click);
            this.myNewButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myNewButton1_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 346);
            this.Controls.Add(this.myNewTextbox1);
            this.Controls.Add(this.myNewButton1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyNewButton myNewButton1;
        private MyNewTextbox myNewTextbox1;
    }
}

