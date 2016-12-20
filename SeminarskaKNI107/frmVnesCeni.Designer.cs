namespace SeminarskaKNI107
{
    partial class frmVnesCeni
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
            System.Windows.Forms.Label cena1Label;
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label proizvodIDLabel;
            System.Windows.Forms.Label sifraIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVnesCeni));
            this.cenaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cenaBindingSource2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cenaBindingSource2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cena1TextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox1 = new System.Windows.Forms.TextBox();
            this.proizvodIDTextBox1 = new System.Windows.Forms.TextBox();
            this.sifraIDTextBox = new System.Windows.Forms.TextBox();
            cena1Label = new System.Windows.Forms.Label();
            imeLabel = new System.Windows.Forms.Label();
            proizvodIDLabel = new System.Windows.Forms.Label();
            sifraIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cenaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaBindingSource2BindingNavigator)).BeginInit();
            this.cenaBindingSource2BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cena1Label
            // 
            cena1Label.AutoSize = true;
            cena1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cena1Label.Location = new System.Drawing.Point(67, 180);
            cena1Label.Name = "cena1Label";
            cena1Label.Size = new System.Drawing.Size(52, 20);
            cena1Label.TabIndex = 1;
            cena1Label.Text = "Цена:";
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imeLabel.Location = new System.Drawing.Point(67, 139);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(44, 20);
            imeLabel.TabIndex = 3;
            imeLabel.Text = "Име:";
            // 
            // proizvodIDLabel
            // 
            proizvodIDLabel.AutoSize = true;
            proizvodIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            proizvodIDLabel.Location = new System.Drawing.Point(67, 99);
            proizvodIDLabel.Name = "proizvodIDLabel";
            proizvodIDLabel.Size = new System.Drawing.Size(110, 20);
            proizvodIDLabel.TabIndex = 5;
            proizvodIDLabel.Text = "Производ ID:";
            // 
            // sifraIDLabel
            // 
            sifraIDLabel.AutoSize = true;
            sifraIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sifraIDLabel.Location = new System.Drawing.Point(67, 64);
            sifraIDLabel.Name = "sifraIDLabel";
            sifraIDLabel.Size = new System.Drawing.Size(89, 20);
            sifraIDLabel.TabIndex = 7;
            sifraIDLabel.Text = "Шифра ID:";
            // 
            // cenaBindingSource2
            // 
            this.cenaBindingSource2.DataSource = typeof(SeminarskaKNI107.Cena);
            // 
            // cenaBindingSource2BindingNavigator
            // 
            this.cenaBindingSource2BindingNavigator.AddNewItem = this.toolStripButton5;
            this.cenaBindingSource2BindingNavigator.BindingSource = this.cenaBindingSource2;
            this.cenaBindingSource2BindingNavigator.CountItem = this.toolStripLabel1;
            this.cenaBindingSource2BindingNavigator.DeleteItem = this.toolStripButton6;
            this.cenaBindingSource2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.cenaBindingSource2BindingNavigatorSaveItem});
            this.cenaBindingSource2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cenaBindingSource2BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.cenaBindingSource2BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.cenaBindingSource2BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.cenaBindingSource2BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.cenaBindingSource2BindingNavigator.Name = "cenaBindingSource2BindingNavigator";
            this.cenaBindingSource2BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.cenaBindingSource2BindingNavigator.Size = new System.Drawing.Size(553, 25);
            this.cenaBindingSource2BindingNavigator.TabIndex = 0;
            this.cenaBindingSource2BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Delete";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // cenaBindingSource2BindingNavigatorSaveItem
            // 
            this.cenaBindingSource2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cenaBindingSource2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cenaBindingSource2BindingNavigatorSaveItem.Image")));
            this.cenaBindingSource2BindingNavigatorSaveItem.Name = "cenaBindingSource2BindingNavigatorSaveItem";
            this.cenaBindingSource2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cenaBindingSource2BindingNavigatorSaveItem.Text = "Save Data";
            this.cenaBindingSource2BindingNavigatorSaveItem.Click += new System.EventHandler(this.cenaBindingSource2BindingNavigatorSaveItem_Click_1);
            // 
            // cena1TextBox
            // 
            this.cena1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cenaBindingSource2, "Cena1", true));
            this.cena1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cena1TextBox.Location = new System.Drawing.Point(216, 180);
            this.cena1TextBox.Name = "cena1TextBox";
            this.cena1TextBox.Size = new System.Drawing.Size(200, 26);
            this.cena1TextBox.TabIndex = 4;
            // 
            // imeTextBox1
            // 
            this.imeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cenaBindingSource2, "Ime", true));
            this.imeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeTextBox1.Location = new System.Drawing.Point(216, 139);
            this.imeTextBox1.Name = "imeTextBox1";
            this.imeTextBox1.Size = new System.Drawing.Size(200, 26);
            this.imeTextBox1.TabIndex = 3;
            // 
            // proizvodIDTextBox1
            // 
            this.proizvodIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cenaBindingSource2, "ProizvodID", true));
            this.proizvodIDTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proizvodIDTextBox1.Location = new System.Drawing.Point(216, 99);
            this.proizvodIDTextBox1.Name = "proizvodIDTextBox1";
            this.proizvodIDTextBox1.Size = new System.Drawing.Size(200, 26);
            this.proizvodIDTextBox1.TabIndex = 2;
            // 
            // sifraIDTextBox
            // 
            this.sifraIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cenaBindingSource2, "SifraID", true));
            this.sifraIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifraIDTextBox.Location = new System.Drawing.Point(216, 64);
            this.sifraIDTextBox.Name = "sifraIDTextBox";
            this.sifraIDTextBox.Size = new System.Drawing.Size(200, 26);
            this.sifraIDTextBox.TabIndex = 1;
            // 
            // frmVnesCeni
            // 
            this.ClientSize = new System.Drawing.Size(553, 270);
            this.Controls.Add(cena1Label);
            this.Controls.Add(this.cena1TextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox1);
            this.Controls.Add(proizvodIDLabel);
            this.Controls.Add(this.proizvodIDTextBox1);
            this.Controls.Add(sifraIDLabel);
            this.Controls.Add(this.sifraIDTextBox);
            this.Controls.Add(this.cenaBindingSource2BindingNavigator);
            this.Name = "frmVnesCeni";
            this.Text = "Внесување на Цени";
            this.Load += new System.EventHandler(this.frmVnesCeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cenaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaBindingSource2BindingNavigator)).EndInit();
            this.cenaBindingSource2BindingNavigator.ResumeLayout(false);
            this.cenaBindingSource2BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
     
       
      
     
       
   

     

       
 
        
       
      
       
    
        private System.Windows.Forms.BindingSource cenaBindingSource2;
        private System.Windows.Forms.BindingNavigator cenaBindingSource2BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton cenaBindingSource2BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cena1TextBox;
        private System.Windows.Forms.TextBox imeTextBox1;
        private System.Windows.Forms.TextBox proizvodIDTextBox1;
        private System.Windows.Forms.TextBox sifraIDTextBox;
    }
}