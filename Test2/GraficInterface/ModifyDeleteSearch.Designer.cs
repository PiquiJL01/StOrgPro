namespace StOrgPro.CommonMenus
{
    partial class ModifyDeleteFormulary
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
            this.CBox = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.numUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblSelect = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.checkBoxUserPermit = new System.Windows.Forms.CheckBox();
            this.checkBoxCatalogPermit = new System.Windows.Forms.CheckBox();
            this.checkBoxStoragePermit = new System.Windows.Forms.CheckBox();
            this.checkBoxInventoryPermit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // CBox
            // 
            this.CBox.FormattingEnabled = true;
            this.CBox.Location = new System.Drawing.Point(500, 33);
            this.CBox.Margin = new System.Windows.Forms.Padding(2);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(206, 21);
            this.CBox.TabIndex = 0;
            this.CBox.SelectedIndexChanged += new System.EventHandler(this.CBoxSelect_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(9, 18);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(356, 414);
            this.dataGrid.TabIndex = 1;
            // 
            // numUpDown1
            // 
            this.numUpDown1.Enabled = false;
            this.numUpDown1.Location = new System.Drawing.Point(650, 67);
            this.numUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown1.Name = "numUpDown1";
            this.numUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numUpDown1.TabIndex = 2;
            this.numUpDown1.Visible = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(384, 37);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(63, 13);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Seleccione ";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Enabled = false;
            this.BtnAceptar.Location = new System.Drawing.Point(491, 391);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(110, 41);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Visible = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(605, 391);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 41);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Enabled = false;
            this.txtBox1.Location = new System.Drawing.Point(500, 131);
            this.txtBox1.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(206, 20);
            this.txtBox1.TabIndex = 6;
            this.txtBox1.Visible = false;
            // 
            // txtBox2
            // 
            this.txtBox2.Enabled = false;
            this.txtBox2.Location = new System.Drawing.Point(500, 160);
            this.txtBox2.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(206, 20);
            this.txtBox2.TabIndex = 7;
            this.txtBox2.Visible = false;
            // 
            // txtBox3
            // 
            this.txtBox3.Enabled = false;
            this.txtBox3.Location = new System.Drawing.Point(500, 192);
            this.txtBox3.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox3.Multiline = true;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(206, 86);
            this.txtBox3.TabIndex = 8;
            this.txtBox3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // numUpDown2
            // 
            this.numUpDown2.Enabled = false;
            this.numUpDown2.Location = new System.Drawing.Point(650, 100);
            this.numUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numUpDown2.Name = "numUpDown2";
            this.numUpDown2.Size = new System.Drawing.Size(56, 20);
            this.numUpDown2.TabIndex = 13;
            this.numUpDown2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // btnInventory
            // 
            this.btnInventory.Enabled = false;
            this.btnInventory.Location = new System.Drawing.Point(500, 308);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(206, 48);
            this.btnInventory.TabIndex = 15;
            this.btnInventory.Text = "Gestionar Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Visible = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // checkBoxUserPermit
            // 
            this.checkBoxUserPermit.AutoSize = true;
            this.checkBoxUserPermit.Enabled = false;
            this.checkBoxUserPermit.Location = new System.Drawing.Point(501, 196);
            this.checkBoxUserPermit.Name = "checkBoxUserPermit";
            this.checkBoxUserPermit.Size = new System.Drawing.Size(179, 17);
            this.checkBoxUserPermit.TabIndex = 16;
            this.checkBoxUserPermit.Text = "Permiso para Gestionar Usuarios";
            this.checkBoxUserPermit.UseVisualStyleBackColor = true;
            this.checkBoxUserPermit.Visible = false;
            // 
            // checkBoxCatalogPermit
            // 
            this.checkBoxCatalogPermit.AutoSize = true;
            this.checkBoxCatalogPermit.Enabled = false;
            this.checkBoxCatalogPermit.Location = new System.Drawing.Point(501, 220);
            this.checkBoxCatalogPermit.Name = "checkBoxCatalogPermit";
            this.checkBoxCatalogPermit.Size = new System.Drawing.Size(191, 17);
            this.checkBoxCatalogPermit.TabIndex = 17;
            this.checkBoxCatalogPermit.Text = "Permiso para Gestionar el Catalogo";
            this.checkBoxCatalogPermit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCatalogPermit.UseVisualStyleBackColor = true;
            this.checkBoxCatalogPermit.Visible = false;
            // 
            // checkBoxStoragePermit
            // 
            this.checkBoxStoragePermit.AutoSize = true;
            this.checkBoxStoragePermit.Enabled = false;
            this.checkBoxStoragePermit.Location = new System.Drawing.Point(501, 244);
            this.checkBoxStoragePermit.Name = "checkBoxStoragePermit";
            this.checkBoxStoragePermit.Size = new System.Drawing.Size(190, 17);
            this.checkBoxStoragePermit.TabIndex = 18;
            this.checkBoxStoragePermit.Text = "Permiso para Gestionar Almacenes";
            this.checkBoxStoragePermit.UseVisualStyleBackColor = true;
            this.checkBoxStoragePermit.Visible = false;
            // 
            // checkBoxInventoryPermit
            // 
            this.checkBoxInventoryPermit.AutoSize = true;
            this.checkBoxInventoryPermit.Enabled = false;
            this.checkBoxInventoryPermit.Location = new System.Drawing.Point(500, 271);
            this.checkBoxInventoryPermit.Name = "checkBoxInventoryPermit";
            this.checkBoxInventoryPermit.Size = new System.Drawing.Size(190, 17);
            this.checkBoxInventoryPermit.TabIndex = 19;
            this.checkBoxInventoryPermit.Text = "Permiso para Gestionar Inventarios";
            this.checkBoxInventoryPermit.UseVisualStyleBackColor = true;
            this.checkBoxInventoryPermit.Visible = false;
            // 
            // ModifyDeleteFormulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 441);
            this.Controls.Add(this.checkBoxInventoryPermit);
            this.Controls.Add(this.checkBoxStoragePermit);
            this.Controls.Add(this.checkBoxCatalogPermit);
            this.Controls.Add(this.checkBoxUserPermit);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.numUpDown1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.CBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModifyDeleteFormulary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.NumericUpDown numUpDown1;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.CheckBox checkBoxUserPermit;
        private System.Windows.Forms.CheckBox checkBoxCatalogPermit;
        private System.Windows.Forms.CheckBox checkBoxStoragePermit;
        private System.Windows.Forms.CheckBox checkBoxInventoryPermit;
    }
}