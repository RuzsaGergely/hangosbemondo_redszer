
namespace Hangosbemondo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_sorrend = new System.Windows.Forms.ListBox();
            this.btn_sorrend_fel = new System.Windows.Forms.Button();
            this.btn_sorrend_le = new System.Windows.Forms.Button();
            this.btn_sorrend_torol = new System.Windows.Forms.Button();
            this.cb_hozzaadasi_lista = new System.Windows.Forms.ComboBox();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_lejatszas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rendszerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összeállításMentéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összeállításBetöltéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurációsFájlBetöltéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ofd_konfig = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_sorrend
            // 
            this.lb_sorrend.FormattingEnabled = true;
            this.lb_sorrend.ItemHeight = 16;
            this.lb_sorrend.Location = new System.Drawing.Point(12, 21);
            this.lb_sorrend.Name = "lb_sorrend";
            this.lb_sorrend.Size = new System.Drawing.Size(366, 260);
            this.lb_sorrend.TabIndex = 0;
            // 
            // btn_sorrend_fel
            // 
            this.btn_sorrend_fel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sorrend_fel.BackgroundImage")));
            this.btn_sorrend_fel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sorrend_fel.Location = new System.Drawing.Point(398, 59);
            this.btn_sorrend_fel.Name = "btn_sorrend_fel";
            this.btn_sorrend_fel.Size = new System.Drawing.Size(50, 50);
            this.btn_sorrend_fel.TabIndex = 1;
            this.btn_sorrend_fel.UseVisualStyleBackColor = true;
            this.btn_sorrend_fel.Click += new System.EventHandler(this.btn_sorrend_fel_Click);
            // 
            // btn_sorrend_le
            // 
            this.btn_sorrend_le.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sorrend_le.BackgroundImage")));
            this.btn_sorrend_le.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sorrend_le.Location = new System.Drawing.Point(398, 198);
            this.btn_sorrend_le.Name = "btn_sorrend_le";
            this.btn_sorrend_le.Size = new System.Drawing.Size(50, 50);
            this.btn_sorrend_le.TabIndex = 2;
            this.btn_sorrend_le.UseVisualStyleBackColor = true;
            this.btn_sorrend_le.Click += new System.EventHandler(this.btn_sorrend_le_Click);
            // 
            // btn_sorrend_torol
            // 
            this.btn_sorrend_torol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sorrend_torol.BackgroundImage")));
            this.btn_sorrend_torol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sorrend_torol.Location = new System.Drawing.Point(398, 129);
            this.btn_sorrend_torol.Name = "btn_sorrend_torol";
            this.btn_sorrend_torol.Size = new System.Drawing.Size(50, 50);
            this.btn_sorrend_torol.TabIndex = 3;
            this.btn_sorrend_torol.UseVisualStyleBackColor = true;
            this.btn_sorrend_torol.Click += new System.EventHandler(this.btn_sorrend_torol_Click);
            // 
            // cb_hozzaadasi_lista
            // 
            this.cb_hozzaadasi_lista.FormattingEnabled = true;
            this.cb_hozzaadasi_lista.Location = new System.Drawing.Point(12, 31);
            this.cb_hozzaadasi_lista.Name = "cb_hozzaadasi_lista";
            this.cb_hozzaadasi_lista.Size = new System.Drawing.Size(334, 24);
            this.cb_hozzaadasi_lista.TabIndex = 4;
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Location = new System.Drawing.Point(361, 28);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(96, 29);
            this.btn_hozzaad.TabIndex = 5;
            this.btn_hozzaad.Text = "Hozzáadás";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.btn_hozzaad_Click);
            // 
            // btn_lejatszas
            // 
            this.btn_lejatszas.Location = new System.Drawing.Point(164, 448);
            this.btn_lejatszas.Name = "btn_lejatszas";
            this.btn_lejatszas.Size = new System.Drawing.Size(151, 54);
            this.btn_lejatszas.TabIndex = 6;
            this.btn_lejatszas.Text = "Lejátszás (F1)";
            this.btn_lejatszas.UseVisualStyleBackColor = true;
            this.btn_lejatszas.Click += new System.EventHandler(this.btn_lejatszas_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rendszerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rendszerToolStripMenuItem
            // 
            this.rendszerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.összeállításMentéseToolStripMenuItem,
            this.összeállításBetöltéseToolStripMenuItem,
            this.konfigurációsFájlBetöltéseToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.rendszerToolStripMenuItem.Name = "rendszerToolStripMenuItem";
            this.rendszerToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.rendszerToolStripMenuItem.Text = "Rendszer";
            // 
            // összeállításMentéseToolStripMenuItem
            // 
            this.összeállításMentéseToolStripMenuItem.Name = "összeállításMentéseToolStripMenuItem";
            this.összeállításMentéseToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.összeállításMentéseToolStripMenuItem.Text = "Összeállítás mentése";
            this.összeállításMentéseToolStripMenuItem.Click += new System.EventHandler(this.összeállításMentéseToolStripMenuItem_Click);
            // 
            // összeállításBetöltéseToolStripMenuItem
            // 
            this.összeállításBetöltéseToolStripMenuItem.Name = "összeállításBetöltéseToolStripMenuItem";
            this.összeállításBetöltéseToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.összeállításBetöltéseToolStripMenuItem.Text = "Összeállítás betöltése";
            this.összeállításBetöltéseToolStripMenuItem.Click += new System.EventHandler(this.összeállításBetöltéseToolStripMenuItem_Click);
            // 
            // konfigurációsFájlBetöltéseToolStripMenuItem
            // 
            this.konfigurációsFájlBetöltéseToolStripMenuItem.Name = "konfigurációsFájlBetöltéseToolStripMenuItem";
            this.konfigurációsFájlBetöltéseToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.konfigurációsFájlBetöltéseToolStripMenuItem.Text = "Konfigurációs fájl betöltése";
            this.konfigurációsFájlBetöltéseToolStripMenuItem.Click += new System.EventHandler(this.konfigurációsFájlBetöltéseToolStripMenuItem_Click);
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_sorrend);
            this.groupBox1.Controls.Add(this.btn_sorrend_le);
            this.groupBox1.Controls.Add(this.btn_sorrend_torol);
            this.groupBox1.Controls.Add(this.btn_sorrend_fel);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 299);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorrend szerkesztő";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_hozzaadasi_lista);
            this.groupBox2.Controls.Add(this.btn_hozzaad);
            this.groupBox2.Location = new System.Drawing.Point(12, 355);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 76);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hozzáadás";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(497, 514);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_lejatszas);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hangosbemondó rendszer - by RuzGer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_sorrend;
        private System.Windows.Forms.Button btn_sorrend_fel;
        private System.Windows.Forms.Button btn_sorrend_le;
        private System.Windows.Forms.Button btn_sorrend_torol;
        private System.Windows.Forms.ComboBox cb_hozzaadasi_lista;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_lejatszas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rendszerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összeállításMentéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összeállításBetöltéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurációsFájlBetöltéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog ofd_konfig;
    }
}

