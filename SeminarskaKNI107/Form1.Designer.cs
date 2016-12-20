namespace SeminarskaKNI107
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuVnes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProizv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProizvCeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzv = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzvProiz = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzvCeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzvProizCeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPres = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKalk = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIzl = new System.Windows.Forms.ToolStripMenuItem();
            this.целосенПриказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ситеСпецификацииНаПроизводотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magacinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCas = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVnes,
            this.mnuIzv,
            this.mnuPres,
            this.mnuIzl,
            this.целосенПриказToolStripMenuItem,
            this.chatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuVnes
            // 
            this.mnuVnes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProizv,
            this.mnuCeni,
            this.mnuProizvCeni});
            this.mnuVnes.Name = "mnuVnes";
            this.mnuVnes.Size = new System.Drawing.Size(45, 20);
            this.mnuVnes.Text = "Внес";
            // 
            // mnuProizv
            // 
            this.mnuProizv.Name = "mnuProizv";
            this.mnuProizv.Size = new System.Drawing.Size(175, 22);
            this.mnuProizv.Text = "Производи";
            this.mnuProizv.Click += new System.EventHandler(this.mnuProizv_Click);
            // 
            // mnuCeni
            // 
            this.mnuCeni.Name = "mnuCeni";
            this.mnuCeni.Size = new System.Drawing.Size(175, 22);
            this.mnuCeni.Text = "Цени";
            this.mnuCeni.Click += new System.EventHandler(this.mnuCeni_Click);
            // 
            // mnuProizvCeni
            // 
            this.mnuProizvCeni.Name = "mnuProizvCeni";
            this.mnuProizvCeni.Size = new System.Drawing.Size(175, 22);
            this.mnuProizvCeni.Text = "Производи - Опис";
            this.mnuProizvCeni.Click += new System.EventHandler(this.mnuProizvCeni_Click);
            // 
            // mnuIzv
            // 
            this.mnuIzv.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIzvProiz,
            this.mnuIzvCeni,
            this.mnuIzvProizCeni});
            this.mnuIzv.Name = "mnuIzv";
            this.mnuIzv.Size = new System.Drawing.Size(70, 20);
            this.mnuIzv.Text = "Извештај";
            // 
            // mnuIzvProiz
            // 
            this.mnuIzvProiz.Name = "mnuIzvProiz";
            this.mnuIzvProiz.Size = new System.Drawing.Size(172, 22);
            this.mnuIzvProiz.Text = "производи";
            this.mnuIzvProiz.Click += new System.EventHandler(this.mnuIzvProiz_Click);
            // 
            // mnuIzvCeni
            // 
            this.mnuIzvCeni.Name = "mnuIzvCeni";
            this.mnuIzvCeni.Size = new System.Drawing.Size(172, 22);
            this.mnuIzvCeni.Text = "ценa";
            this.mnuIzvCeni.Click += new System.EventHandler(this.mnuIzvCeni_Click);
            // 
            // mnuIzvProizCeni
            // 
            this.mnuIzvProizCeni.Name = "mnuIzvProizCeni";
            this.mnuIzvProizCeni.Size = new System.Drawing.Size(172, 22);
            this.mnuIzvProizCeni.Text = "производ со опис";
            this.mnuIzvProizCeni.Click += new System.EventHandler(this.mnuIzvProizCeni_Click);
            // 
            // mnuPres
            // 
            this.mnuPres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKalk});
            this.mnuPres.Name = "mnuPres";
            this.mnuPres.Size = new System.Drawing.Size(64, 20);
            this.mnuPres.Text = "Додаток";
            // 
            // mnuKalk
            // 
            this.mnuKalk.Name = "mnuKalk";
            this.mnuKalk.Size = new System.Drawing.Size(138, 22);
            this.mnuKalk.Text = "Калкулатор";
            this.mnuKalk.Click += new System.EventHandler(this.mnuKalk_Click);
            // 
            // mnuIzl
            // 
            this.mnuIzl.Name = "mnuIzl";
            this.mnuIzl.Size = new System.Drawing.Size(51, 20);
            this.mnuIzl.Text = "Излез";
            this.mnuIzl.Click += new System.EventHandler(this.mnuIzl_Click);
            // 
            // целосенПриказToolStripMenuItem
            // 
            this.целосенПриказToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ситеСпецификацииНаПроизводотToolStripMenuItem});
            this.целосенПриказToolStripMenuItem.Name = "целосенПриказToolStripMenuItem";
            this.целосенПриказToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.целосенПриказToolStripMenuItem.Text = "Целосен приказ";
            this.целосенПриказToolStripMenuItem.Click += new System.EventHandler(this.целосенПриказToolStripMenuItem_Click);
            // 
            // ситеСпецификацииНаПроизводотToolStripMenuItem
            // 
            this.ситеСпецификацииНаПроизводотToolStripMenuItem.Name = "ситеСпецификацииНаПроизводотToolStripMenuItem";
            this.ситеСпецификацииНаПроизводотToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.ситеСпецификацииНаПроизводотToolStripMenuItem.Text = "Сите спецификации на производот";
            this.ситеСпецификацииНаПроизводотToolStripMenuItem.Click += new System.EventHandler(this.ситеСпецификацииНаПроизводотToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.magacinToolStripMenuItem});
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // magacinToolStripMenuItem
            // 
            this.magacinToolStripMenuItem.Name = "magacinToolStripMenuItem";
            this.magacinToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.magacinToolStripMenuItem.Text = "Magacin";
            this.magacinToolStripMenuItem.Click += new System.EventHandler(this.magacinToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(504, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCas.Location = new System.Drawing.Point(715, 4);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(64, 18);
            this.lblCas.TabIndex = 3;
            this.lblCas.Text = "00:00:00";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 547);
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Магацин";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuVnes;
        private System.Windows.Forms.ToolStripMenuItem mnuIzv;
        private System.Windows.Forms.ToolStripMenuItem mnuPres;
        private System.Windows.Forms.ToolStripMenuItem mnuIzl;
        private System.Windows.Forms.ToolStripMenuItem mnuProizv;
        private System.Windows.Forms.ToolStripMenuItem mnuCeni;
        private System.Windows.Forms.ToolStripMenuItem mnuProizvCeni;
        private System.Windows.Forms.ToolStripMenuItem mnuIzvProiz;
        private System.Windows.Forms.ToolStripMenuItem mnuIzvCeni;
        private System.Windows.Forms.ToolStripMenuItem mnuIzvProizCeni;
        private System.Windows.Forms.ToolStripMenuItem mnuKalk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.ToolStripMenuItem целосенПриказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ситеСпецификацииНаПроизводотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magacinToolStripMenuItem;
    }
}

