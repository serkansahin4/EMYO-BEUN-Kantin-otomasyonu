namespace BeunKantin.WindowsFormUI
{
    partial class AdminAnasayfa
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.urunekle = new System.Windows.Forms.TabPage();
            this.kategoriekle = new System.Windows.Forms.TabPage();
            this.personelekle = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.urunler = new System.Windows.Forms.TabPage();
            this.satisraporu = new System.Windows.Forms.TabPage();
            this.uruniade = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.urunekle);
            this.tabControl1.Controls.Add(this.kategoriekle);
            this.tabControl1.Controls.Add(this.personelekle);
            this.tabControl1.ItemSize = new System.Drawing.Size(71, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(567, 509);
            this.tabControl1.TabIndex = 0;
            // 
            // urunekle
            // 
            this.urunekle.Location = new System.Drawing.Point(4, 34);
            this.urunekle.Name = "urunekle";
            this.urunekle.Padding = new System.Windows.Forms.Padding(3);
            this.urunekle.Size = new System.Drawing.Size(400, 471);
            this.urunekle.TabIndex = 0;
            this.urunekle.Text = "Ürün Ekle";
            this.urunekle.UseVisualStyleBackColor = true;
            // 
            // kategoriekle
            // 
            this.kategoriekle.Location = new System.Drawing.Point(4, 34);
            this.kategoriekle.Name = "kategoriekle";
            this.kategoriekle.Padding = new System.Windows.Forms.Padding(3);
            this.kategoriekle.Size = new System.Drawing.Size(400, 471);
            this.kategoriekle.TabIndex = 1;
            this.kategoriekle.Text = "Kategori Ekle";
            this.kategoriekle.UseVisualStyleBackColor = true;
            // 
            // personelekle
            // 
            this.personelekle.Location = new System.Drawing.Point(4, 34);
            this.personelekle.Name = "personelekle";
            this.personelekle.Size = new System.Drawing.Size(559, 471);
            this.personelekle.TabIndex = 2;
            this.personelekle.Text = "Personel Ekle";
            this.personelekle.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.urunler);
            this.tabControl2.Controls.Add(this.satisraporu);
            this.tabControl2.Controls.Add(this.uruniade);
            this.tabControl2.Location = new System.Drawing.Point(573, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(567, 509);
            this.tabControl2.TabIndex = 1;
            // 
            // urunler
            // 
            this.urunler.Location = new System.Drawing.Point(4, 25);
            this.urunler.Name = "urunler";
            this.urunler.Padding = new System.Windows.Forms.Padding(3);
            this.urunler.Size = new System.Drawing.Size(559, 480);
            this.urunler.TabIndex = 0;
            this.urunler.Text = "Stok Takibi";
            this.urunler.UseVisualStyleBackColor = true;
            // 
            // satisraporu
            // 
            this.satisraporu.Location = new System.Drawing.Point(4, 25);
            this.satisraporu.Name = "satisraporu";
            this.satisraporu.Padding = new System.Windows.Forms.Padding(3);
            this.satisraporu.Size = new System.Drawing.Size(559, 480);
            this.satisraporu.TabIndex = 1;
            this.satisraporu.Text = "Satış Raporları";
            this.satisraporu.UseVisualStyleBackColor = true;
            // 
            // uruniade
            // 
            this.uruniade.Location = new System.Drawing.Point(4, 25);
            this.uruniade.Name = "uruniade";
            this.uruniade.Size = new System.Drawing.Size(559, 480);
            this.uruniade.TabIndex = 2;
            this.uruniade.Text = "İade Edilen Ürünler";
            this.uruniade.UseVisualStyleBackColor = true;
            // 
            // AdminAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 515);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminAnasayfa";
            this.Text = "Admin Anasayfa";
            this.Load += new System.EventHandler(this.AdminAnasayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage urunekle;
        private System.Windows.Forms.TabPage kategoriekle;
        private System.Windows.Forms.TabPage personelekle;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage urunler;
        private System.Windows.Forms.TabPage satisraporu;
        private System.Windows.Forms.TabPage uruniade;
    }
}