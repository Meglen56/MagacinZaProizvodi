namespace SeminarskaKNI107
{
    partial class frmVnesProizCeni
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
            System.Windows.Forms.Label opisLabel;
            System.Windows.Forms.Label proizvodIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVnesProizCeni));
            this.proizvodCenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodCenaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.proizvodCenaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.proizvodIDTextBox = new System.Windows.Forms.TextBox();
            imeLabel = new System.Windows.Forms.Label();
            opisLabel = new System.Windows.Forms.Label();
            proizvodIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingNavigator)).BeginInit();
            this.proizvodCenaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imeLabel.Location = new System.Drawing.Point(108, 120);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(44, 20);
            imeLabel.TabIndex = 2;
            imeLabel.Text = "Име:";
            // 
            // opisLabel
            // 
            opisLabel.AutoSize = true;
            opisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            opisLabel.Location = new System.Drawing.Point(108, 170);
            opisLabel.Name = "opisLabel";
            opisLabel.Size = new System.Drawing.Size(51, 20);
            opisLabel.TabIndex = 4;
            opisLabel.Text = "Опис:";
            // 
            // proizvodIDLabel
            // 
            proizvodIDLabel.AutoSize = true;
            proizvodIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            proizvodIDLabel.Location = new System.Drawing.Point(108, 68);
            proizvodIDLabel.Name = "proizvodIDLabel";
            proizvodIDLabel.Size = new System.Drawing.Size(110, 20);
            proizvodIDLabel.TabIndex = 6;
            proizvodIDLabel.Text = "Производ ID:";
            // 
            // proizvodCenaBindingSource
            // 
            this.proizvodCenaBindingSource.DataSource = typeof(SeminarskaKNI107.ProizvodCena);
            // 
            // proizvodCenaBindingNavigator
            // 
            this.proizvodCenaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proizvodCenaBindingNavigator.BindingSource = this.proizvodCenaBindingSource;
            this.proizvodCenaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proizvodCenaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proizvodCenaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.proizvodCenaBindingNavigatorSaveItem});
            this.proizvodCenaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proizvodCenaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proizvodCenaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proizvodCenaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proizvodCenaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proizvodCenaBindingNavigator.Name = "proizvodCenaBindingNavigator";
            this.proizvodCenaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proizvodCenaBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.proizvodCenaBindingNavigator.TabIndex = 0;
            this.proizvodCenaBindingNavigator.Text = "bindingNavigator1";
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
            // proizvodCenaBindingNavigatorSaveItem
            // 
            this.proizvodCenaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proizvodCenaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvodCenaBindingNavigatorSaveItem.Image")));
            this.proizvodCenaBindingNavigatorSaveItem.Name = "proizvodCenaBindingNavigatorSaveItem";
            this.proizvodCenaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proizvodCenaBindingNavigatorSaveItem.Text = "Save Data";
            this.proizvodCenaBindingNavigatorSaveItem.Click += new System.EventHandler(this.proizvodCenaBindingNavigatorSaveItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodCenaBindingSource, "Ime", true));
            this.imeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeTextBox.Location = new System.Drawing.Point(238, 114);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(273, 26);
            this.imeTextBox.TabIndex = 2;
            // 
            // opisTextBox
            // 
            this.opisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodCenaBindingSource, "Opis", true));
            this.opisTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisTextBox.Location = new System.Drawing.Point(238, 168);
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(273, 26);
            this.opisTextBox.TabIndex = 3;
            // 
            // proizvodIDTextBox
            // 
            this.proizvodIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proizvodCenaBindingSource, "ProizvodID", true));
            this.proizvodIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proizvodIDTextBox.Location = new System.Drawing.Point(238, 66);
            this.proizvodIDTextBox.Name = "proizvodIDTextBox";
            this.proizvodIDTextBox.Size = new System.Drawing.Size(273, 26);
            this.proizvodIDTextBox.TabIndex = 1;
            // 
            // frmVnesProizCeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 296);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(opisLabel);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(proizvodIDLabel);
            this.Controls.Add(this.proizvodIDTextBox);
            this.Controls.Add(this.proizvodCenaBindingNavigator);
            this.Name = "frmVnesProizCeni";
            this.Text = "Опис и цена на производи";
            this.Load += new System.EventHandler(this.frmVnesProizCeni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingNavigator)).EndInit();
            this.proizvodCenaBindingNavigator.ResumeLayout(false);
            this.proizvodCenaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proizvodCenaBindingSource;
        private System.Windows.Forms.BindingNavigator proizvodCenaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton proizvodCenaBindingNavigatorSaveItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.TextBox proizvodIDTextBox;
    }
}