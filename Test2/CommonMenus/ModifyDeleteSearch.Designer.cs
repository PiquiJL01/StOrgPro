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
            this.CBoxSelect = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.numQuantityLength = new System.Windows.Forms.NumericUpDown();
            this.lblSelect = new System.Windows.Forms.Label();
            this.BtnDeleteModify = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TxtPasswordBrand = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.lblQuantityLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPasswordBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.checkBoxUserPermit = new System.Windows.Forms.CheckBox();
            this.checkBoxCatalogPermit = new System.Windows.Forms.CheckBox();
            this.checkBoxStoragePermit = new System.Windows.Forms.CheckBox();
            this.checkBoxInventoryPermit = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // CBoxSelect
            // 
            this.CBoxSelect.FormattingEnabled = true;
            this.CBoxSelect.Location = new System.Drawing.Point(500, 33);
            this.CBoxSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBoxSelect.Name = "CBoxSelect";
            this.CBoxSelect.Size = new System.Drawing.Size(206, 21);
            this.CBoxSelect.TabIndex = 0;
            this.CBoxSelect.SelectedIndexChanged += new System.EventHandler(this.CBoxSelect_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(9, 18);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(356, 414);
            this.dataGrid.TabIndex = 1;
            // 
            // numQuantityLength
            // 
            this.numQuantityLength.Location = new System.Drawing.Point(650, 67);
            this.numQuantityLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQuantityLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantityLength.Name = "numQuantityLength";
            this.numQuantityLength.Size = new System.Drawing.Size(56, 20);
            this.numQuantityLength.TabIndex = 2;
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
            // BtnDeleteModify
            // 
            this.BtnDeleteModify.Location = new System.Drawing.Point(491, 391);
            this.BtnDeleteModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDeleteModify.Name = "BtnDeleteModify";
            this.BtnDeleteModify.Size = new System.Drawing.Size(110, 41);
            this.BtnDeleteModify.TabIndex = 4;
            this.BtnDeleteModify.Text = "Modificar/Eliminar";
            this.BtnDeleteModify.UseVisualStyleBackColor = true;
            this.BtnDeleteModify.Click += new System.EventHandler(this.BtnDeleteModify_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(605, 391);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 41);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPasswordBrand
            // 
            this.TxtPasswordBrand.Location = new System.Drawing.Point(500, 131);
            this.TxtPasswordBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtPasswordBrand.Name = "TxtPasswordBrand";
            this.TxtPasswordBrand.Size = new System.Drawing.Size(206, 20);
            this.TxtPasswordBrand.TabIndex = 6;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(500, 160);
            this.TxtModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(206, 20);
            this.TxtModel.TabIndex = 7;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(500, 192);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(206, 86);
            this.TxtDescription.TabIndex = 8;
            // 
            // lblQuantityLength
            // 
            this.lblQuantityLength.AutoSize = true;
            this.lblQuantityLength.Location = new System.Drawing.Point(387, 71);
            this.lblQuantityLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantityLength.Name = "lblQuantityLength";
            this.lblQuantityLength.Size = new System.Drawing.Size(35, 13);
            this.lblQuantityLength.TabIndex = 9;
            this.lblQuantityLength.Text = "label1";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(388, 100);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 13);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Ancho";
            // 
            // lblPasswordBrand
            // 
            this.lblPasswordBrand.AutoSize = true;
            this.lblPasswordBrand.Location = new System.Drawing.Point(387, 131);
            this.lblPasswordBrand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordBrand.Name = "lblPasswordBrand";
            this.lblPasswordBrand.Size = new System.Drawing.Size(35, 13);
            this.lblPasswordBrand.TabIndex = 11;
            this.lblPasswordBrand.Text = "label3";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(388, 162);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(42, 13);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Modelo";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(650, 100);
            this.numWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(56, 20);
            this.numWidth.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(388, 192);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Descripción";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(500, 308);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(206, 48);
            this.btnInventory.TabIndex = 15;
            this.btnInventory.Text = "Gestionar Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblPasswordBrand);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblQuantityLength);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.TxtModel);
            this.Controls.Add(this.TxtPasswordBrand);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDeleteModify);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.numQuantityLength);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.CBoxSelect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyDeleteFormulary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBoxSelect;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.NumericUpDown numQuantityLength;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button BtnDeleteModify;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtPasswordBrand;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label lblQuantityLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPasswordBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.CheckBox checkBoxUserPermit;
        private System.Windows.Forms.CheckBox checkBoxCatalogPermit;
        private System.Windows.Forms.CheckBox checkBoxStoragePermit;
        private System.Windows.Forms.CheckBox checkBoxInventoryPermit;
    }
}