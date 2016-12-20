namespace SeminarskaKNI107
{
    partial class frmIzvProizvCen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvProizvCen));
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
            this.cmbOpis = new System.Windows.Forms.ComboBox();
            this.proizvodCenaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodavnicaDataSet = new SeminarskaKNI107.ProdavnicaDataSet();
            this.proizvodCenaTableAdapter = new SeminarskaKNI107.ProdavnicaDataSetTableAdapters.ProizvodCenaTableAdapter();
            this.proizvodCenaDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.proizvodCenaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingNavigator)).BeginInit();
            this.proizvodCenaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // proizvodCenaBindingNavigator
            // 
            this.proizvodCenaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
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
            this.proizvodCenaBindingNavigator.Size = new System.Drawing.Size(810, 25);
            this.proizvodCenaBindingNavigator.TabIndex = 0;
            this.proizvodCenaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            this.bindingNavigatorDeleteItem.Enabled = false;
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
            this.proizvodCenaBindingNavigatorSaveItem.Enabled = false;
            this.proizvodCenaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proizvodCenaBindingNavigatorSaveItem.Image")));
            this.proizvodCenaBindingNavigatorSaveItem.Name = "proizvodCenaBindingNavigatorSaveItem";
            this.proizvodCenaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proizvodCenaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // cmbOpis
            // 
            this.cmbOpis.DataSource = this.proizvodCenaBindingSource;
            this.cmbOpis.DisplayMember = "Ime";
            this.cmbOpis.FormattingEnabled = true;
            this.cmbOpis.Location = new System.Drawing.Point(213, 41);
            this.cmbOpis.Name = "cmbOpis";
            this.cmbOpis.Size = new System.Drawing.Size(153, 21);
            this.cmbOpis.TabIndex = 2;
            this.cmbOpis.ValueMember = "ProizvodID";
            this.cmbOpis.SelectedValueChanged += new System.EventHandler(this.cmbOpis_SelectedValueChanged);
            // 
            // proizvodCenaBindingSource
            // 
            this.proizvodCenaBindingSource.DataMember = "ProizvodCena";
            this.proizvodCenaBindingSource.DataSource = this.prodavnicaDataSet;
            // 
            // prodavnicaDataSet
            // 
            this.prodavnicaDataSet.DataSetName = "ProdavnicaDataSet";
            this.prodavnicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvodCenaTableAdapter
            // 
            this.proizvodCenaTableAdapter.ClearBeforeFill = true;
            // 
            // proizvodCenaDataGridView
            // 
            this.proizvodCenaDataGridView.AllowUserToAddRows = false;
            this.proizvodCenaDataGridView.AllowUserToDeleteRows = false;
            this.proizvodCenaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodCenaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.proizvodCenaDataGridView.Location = new System.Drawing.Point(43, 93);
            this.proizvodCenaDataGridView.Name = "proizvodCenaDataGridView";
            this.proizvodCenaDataGridView.Size = new System.Drawing.Size(666, 220);
            this.proizvodCenaDataGridView.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Внеси име на производ:";
            // 
            // proizvodCenaBindingSource1
            // 
            this.proizvodCenaBindingSource1.DataSource = typeof(SeminarskaKNI107.ProizvodCena);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Opis";
            this.dataGridViewTextBoxColumn3.HeaderText = "Опис";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 360;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Име";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProizvodID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ПроизводID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // frmIzvProizvCen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proizvodCenaDataGridView);
            this.Controls.Add(this.cmbOpis);
            this.Controls.Add(this.proizvodCenaBindingNavigator);
            this.Name = "frmIzvProizvCen";
            this.Text = "Извештај - производ  со опис";
            this.Load += new System.EventHandler(this.frmIzvProizvCen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingNavigator)).EndInit();
            this.proizvodCenaBindingNavigator.ResumeLayout(false);
            this.proizvodCenaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodavnicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodCenaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ComboBox cmbOpis;
        private ProdavnicaDataSet prodavnicaDataSet;
        private ProdavnicaDataSetTableAdapters.ProizvodCenaTableAdapter proizvodCenaTableAdapter;
        private System.Windows.Forms.BindingSource proizvodCenaBindingSource;
        private System.Windows.Forms.DataGridView proizvodCenaDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource proizvodCenaBindingSource1;
    }
}