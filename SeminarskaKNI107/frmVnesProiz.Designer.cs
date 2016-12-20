namespace SeminarskaKNI107
{
    partial class frmVnesProiz
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label kategorijaLabel;
            System.Windows.Forms.Label kolicinaLabel;
            System.Windows.Forms.Label proizvodIDLabel;
            System.Windows.Forms.Label proizvoditelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVnesProiz));
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proizvodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.kategorijaTextBox = new System.Windows.Forms.TextBox();
            this.kolicinaTextBox = new System.Windows.Forms.TextBox();
            this.proizvodIDTextBox = new System.Windows.Forms.TextBox();
            this.proizvoditelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            imeLabel = new System.Windows.Forms.Label();
            kategorijaLabel = new System.Windows.Forms.Label();
            kolicinaLabel = new System.Windows.Forms.Label();
            proizvodIDLabel = new System.Windows.Forms.Label();
            proizvoditelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingNavigator)).BeginInit();
            this.proizvodBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            imeLabel.Location = new System.Drawing.Point(53, 126);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(44, 20);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Име:";
            // 
            // kategorijaLabel
            // 
            kategorijaLabel.AutoSize = true;
            kategorijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kategorijaLabel.Location = new System.Drawing.Point(53, 178);
            kategorijaLabel.Name = "kategorijaLabel";
            kategorijaLabel.Size = new System.Drawing.Size(96, 20);
            kategorijaLabel.TabIndex = 3;
            kategorijaLabel.Text = "Категорија:";
            // 
            // kolicinaLabel
            // 
            kolicinaLabel.AutoSize = true;
            kolicinaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kolicinaLabel.Location = new System.Drawing.Point(53, 228);
            kolicinaLabel.Name = "kolicinaLabel";
            kolicinaLabel.Size = new System.Drawing.Size(87, 20);
            kolicinaLabel.TabIndex = 5;
            kolicinaLabel.Text = "Количина:";
            // 
            // proizvodIDLabel
            // 
            proizvodIDLabel.AutoSize = true;
            proizvodIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            proizvodIDLabel.Location = new System.Drawing.Point(53, 73);
            proizvodIDLabel.Name = "proizvodIDLabel";
            proizvodIDLabel.Size = new System.Drawing.Size(110, 20);
            proizvodIDLabel.TabIndex = 7;
            proizvodIDLabel.Text = "Производ ID:";
            // 
            // proizvoditelLabel
            // 
            proizvoditelLabel.AutoSize = true;
            proizvoditelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            proizvoditelLabel.Location = new System.Drawing.Point(53, 271);
            proizvoditelLabel.Name = "proizvoditelLabel";
            proizvoditelLabel.Size = new System.Drawing.Size(126, 20);
            proizvoditelLabel.TabIndex = 9;
            proizvoditelLabel.Text = "Производител:";
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataSource = typeof(SeminarskaKNI107.Proizvod);
            // 
            // proizvodBindingNavigator
            // 
            this.proizvodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proizvodBindingNavigator.BindingSource = this.proizvodBindingSource;
            this.proizvodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proizvodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proizvodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.proizvodBindingNavigatorSaveItem});
            this.proizvodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proizvodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proizvodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proizvodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proizvodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proizvodBindingNavigator.Name = "proizvodBindingNavigator";
            this.proizvodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proizvodBindingNavigator.Size = new System.Drawing.Size(763, 25);
            this.proizvodBindingNavigator.TabIndex = 0;
            this.proizvodBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // proizvodBindingNavigatorSaveItem
            // 
            this.proizvodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proizvodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvodBindingNavigatorSaveItem.Image")));
            this.proizvodBindingNavigatorSaveItem.Name = "proizvodBindingNavigatorSaveItem";
            this.proizvodBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proizvodBindingNavigatorSaveItem.Text = "Save Data";
            this.proizvodBindingNavigatorSaveItem.Click += new System.EventHandler(this.proizvodBindingNavigatorSaveItem_Click);
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "Ime", true));
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.imeTextBox.Location = new System.Drawing.Point(258, 126);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(305, 26);
            this.imeTextBox.TabIndex = 2;
            // 
            // kategorijaTextBox
            // 
            this.kategorijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "Kategorija", true));
            this.kategorijaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kategorijaTextBox.Location = new System.Drawing.Point(258, 178);
            this.kategorijaTextBox.Name = "kategorijaTextBox";
            this.kategorijaTextBox.Size = new System.Drawing.Size(305, 26);
            this.kategorijaTextBox.TabIndex = 3;
            // 
            // kolicinaTextBox
            // 
            this.kolicinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "Kolicina", true));
            this.kolicinaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kolicinaTextBox.Location = new System.Drawing.Point(258, 228);
            this.kolicinaTextBox.Name = "kolicinaTextBox";
            this.kolicinaTextBox.Size = new System.Drawing.Size(305, 26);
            this.kolicinaTextBox.TabIndex = 4;
            // 
            // proizvodIDTextBox
            // 
            this.proizvodIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "ProizvodID", true));
            this.proizvodIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proizvodIDTextBox.Location = new System.Drawing.Point(258, 73);
            this.proizvodIDTextBox.Name = "proizvodIDTextBox";
            this.proizvodIDTextBox.Size = new System.Drawing.Size(305, 26);
            this.proizvodIDTextBox.TabIndex = 1;
            // 
            // proizvoditelTextBox
            // 
            this.proizvoditelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodBindingSource, "Proizvoditel", true));
            this.proizvoditelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proizvoditelTextBox.Location = new System.Drawing.Point(258, 271);
            this.proizvoditelTextBox.Name = "proizvoditelTextBox";
            this.proizvoditelTextBox.Size = new System.Drawing.Size(305, 26);
            this.proizvoditelTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Лап топ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Апарати";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Телевизори";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Останато";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(594, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 218);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Достапни категории";
            // 
            // frmVnesProiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 352);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(kategorijaLabel);
            this.Controls.Add(this.kategorijaTextBox);
            this.Controls.Add(kolicinaLabel);
            this.Controls.Add(this.kolicinaTextBox);
            this.Controls.Add(proizvodIDLabel);
            this.Controls.Add(this.proizvodIDTextBox);
            this.Controls.Add(proizvoditelLabel);
            this.Controls.Add(this.proizvoditelTextBox);
            this.Controls.Add(this.proizvodBindingNavigator);
            this.Name = "frmVnesProiz";
            this.Text = "Внесување на производи";
            this.Load += new System.EventHandler(this.frmVnesProiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingNavigator)).EndInit();
            this.proizvodBindingNavigator.ResumeLayout(false);
            this.proizvodBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private System.Windows.Forms.BindingNavigator proizvodBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton proizvodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox kategorijaTextBox;
        private System.Windows.Forms.TextBox kolicinaTextBox;
        private System.Windows.Forms.TextBox proizvodIDTextBox;
        private System.Windows.Forms.TextBox proizvoditelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}