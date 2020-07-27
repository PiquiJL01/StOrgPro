namespace StOrgPro
{
    partial class MainMenu
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
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnStorage = new System.Windows.Forms.Button();
            this.BtnItem = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUser
            // 
            this.BtnUser.Location = new System.Drawing.Point(12, 34);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(458, 45);
            this.BtnUser.TabIndex = 0;
            this.BtnUser.Text = "Gestión de Usuarios";
            this.BtnUser.UseVisualStyleBackColor = true;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnStorage
            // 
            this.BtnStorage.Location = new System.Drawing.Point(12, 86);
            this.BtnStorage.Name = "BtnStorage";
            this.BtnStorage.Size = new System.Drawing.Size(457, 52);
            this.BtnStorage.TabIndex = 1;
            this.BtnStorage.Text = "Gestión Almacenes";
            this.BtnStorage.UseVisualStyleBackColor = true;
            this.BtnStorage.Click += new System.EventHandler(this.BtnStorage_Click);
            // 
            // BtnItem
            // 
            this.BtnItem.Location = new System.Drawing.Point(12, 144);
            this.BtnItem.Name = "BtnItem";
            this.BtnItem.Size = new System.Drawing.Size(457, 55);
            this.BtnItem.TabIndex = 2;
            this.BtnItem.Text = "Gestión de Ítems";
            this.BtnItem.UseVisualStyleBackColor = true;
            this.BtnItem.Click += new System.EventHandler(this.BtnItem_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 205);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(456, 55);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Salir";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 276);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnItem);
            this.Controls.Add(this.BtnStorage);
            this.Controls.Add(this.BtnUser);
            this.Name = "MainMenu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnStorage;
        private System.Windows.Forms.Button BtnItem;
        private System.Windows.Forms.Button BtnExit;
    }
}