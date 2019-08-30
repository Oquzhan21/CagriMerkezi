namespace CagriMerkeziV._1
{
    partial class GorusmeSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorusmeSil));
            this.btnSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(12, 145);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 59);
            this.btnSil.TabIndex = 0;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(95, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DisplayMember = "ID";
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(13, 83);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(157, 21);
            this.cmbMusteri.TabIndex = 2;
            this.cmbMusteri.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "MÜŞTERİ SEÇİNİZ!";
            // 
            // GorusmeSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GorusmeSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GorusmeSil";
            this.Load += new System.EventHandler(this.GorusmeSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label1;
    }
}