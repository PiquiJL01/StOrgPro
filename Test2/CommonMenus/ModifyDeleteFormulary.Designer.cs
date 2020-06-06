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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // CBoxSelect
            // 
            this.CBoxSelect.FormattingEnabled = true;
            this.CBoxSelect.Location = new System.Drawing.Point(666, 41);
            this.CBoxSelect.Name = "CBoxSelect";
            this.CBoxSelect.Size = new System.Drawing.Size(274, 24);
            this.CBoxSelect.TabIndex = 0;
            this.CBoxSelect.SelectedIndexChanged += new System.EventHandler(this.CBoxSelect_SelectedIndexChanged);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 22);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(475, 509);
            this.dataGrid.TabIndex = 1;
            // 
            // numQuantityLength
            // 
            this.numQuantityLength.Location = new System.Drawing.Point(866, 83);
            this.numQuantityLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantityLength.Name = "numQuantityLength";
            this.numQuantityLength.Size = new System.Drawing.Size(74, 22);
            this.numQuantityLength.TabIndex = 2;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(512, 45);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(81, 17);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Seleccione ";
            // 
            // BtnDeleteModify
            // 
            this.BtnDeleteModify.Location = new System.Drawing.Point(655, 481);
            this.BtnDeleteModify.Name = "BtnDeleteModify";
            this.BtnDeleteModify.Size = new System.Drawing.Size(146, 50);
            this.BtnDeleteModify.TabIndex = 4;
            this.BtnDeleteModify.Text = "Modificar/Eliminar";
            this.BtnDeleteModify.UseVisualStyleBackColor = true;
            this.BtnDeleteModify.Click += new System.EventHandler(this.BtnDeleteModify_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(807, 481);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(133, 50);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TxtPasswordBrand
            // 
            this.TxtPasswordBrand.Location = new System.Drawing.Point(666, 161);
            this.TxtPasswordBrand.Name = "TxtPasswordBrand";
            this.TxtPasswordBrand.Size = new System.Drawing.Size(274, 22);
            this.TxtPasswordBrand.TabIndex = 6;
            // 
            // TxtModel
            // 
            this.TxtModel.Location = new System.Drawing.Point(666, 197);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(274, 22);
            this.TxtModel.TabIndex = 7;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(666, 236);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(274, 105);
            this.TxtDescription.TabIndex = 8;
            // 
            // lblQuantityLength
            // 
            this.lblQuantityLength.AutoSize = true;
            this.lblQuantityLength.Location = new System.Drawing.Point(516, 87);
            this.lblQuantityLength.Name = "lblQuantityLength";
            this.lblQuantityLength.Size = new System.Drawing.Size(46, 17);
            this.lblQuantityLength.TabIndex = 9;
            this.lblQuantityLength.Text = "label1";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(517, 123);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 17);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Ancho";
            // 
            // lblPasswordBrand
            // 
            this.lblPasswordBrand.AutoSize = true;
            this.lblPasswordBrand.Location = new System.Drawing.Point(516, 161);
            this.lblPasswordBrand.Name = "lblPasswordBrand";
            this.lblPasswordBrand.Size = new System.Drawing.Size(46, 17);
            this.lblPasswordBrand.TabIndex = 11;
            this.lblPasswordBrand.Text = "label3";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(518, 200);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(54, 17);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "Modelo";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(866, 123);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(74, 22);
            this.numWidth.TabIndex = 13;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(518, 236);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(82, 17);
            this.lblDescription.TabIndex = 14;
            this.lblDescription.Text = "Descripción";
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(666, 379);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(274, 59);
            this.btnInventory.TabIndex = 15;
            this.btnInventory.Text = "Gestionar Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // ModifyDeleteFormulary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 543);
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
    }
}