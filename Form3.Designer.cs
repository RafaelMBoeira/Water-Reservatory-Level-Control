namespace WindowsFormsApp2
{
    partial class ConfigurationForm
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
            this.lbSkeleton = new System.Windows.Forms.Label();
            this.tbSkeleton = new System.Windows.Forms.TextBox();
            this.btSelectSkeleton = new System.Windows.Forms.Button();
            this.lbDefaultPath = new System.Windows.Forms.Label();
            this.tbDefaultPath = new System.Windows.Forms.TextBox();
            this.btSelectDefaultPath = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSkeleton
            // 
            this.lbSkeleton.AutoSize = true;
            this.lbSkeleton.Location = new System.Drawing.Point(12, 62);
            this.lbSkeleton.Name = "lbSkeleton";
            this.lbSkeleton.Size = new System.Drawing.Size(206, 16);
            this.lbSkeleton.TabIndex = 0;
            this.lbSkeleton.Text = "Local dos Esqueletos de Código:";
            // 
            // tbSkeleton
            // 
            this.tbSkeleton.Enabled = false;
            this.tbSkeleton.Location = new System.Drawing.Point(224, 59);
            this.tbSkeleton.Name = "tbSkeleton";
            this.tbSkeleton.Size = new System.Drawing.Size(408, 22);
            this.tbSkeleton.TabIndex = 1;
            // 
            // btSelectSkeleton
            // 
            this.btSelectSkeleton.Location = new System.Drawing.Point(638, 59);
            this.btSelectSkeleton.Name = "btSelectSkeleton";
            this.btSelectSkeleton.Size = new System.Drawing.Size(150, 23);
            this.btSelectSkeleton.TabIndex = 2;
            this.btSelectSkeleton.Text = "Selecionar Caminho";
            this.btSelectSkeleton.UseVisualStyleBackColor = true;
            this.btSelectSkeleton.Click += new System.EventHandler(this.selectSkeletonsFolder);
            // 
            // lbDefaultPath
            // 
            this.lbDefaultPath.AutoSize = true;
            this.lbDefaultPath.Location = new System.Drawing.Point(15, 17);
            this.lbDefaultPath.Name = "lbDefaultPath";
            this.lbDefaultPath.Size = new System.Drawing.Size(166, 16);
            this.lbDefaultPath.TabIndex = 3;
            this.lbDefaultPath.Text = "Local Padrão de Arquivos:";
            // 
            // tbDefaultPath
            // 
            this.tbDefaultPath.Enabled = false;
            this.tbDefaultPath.Location = new System.Drawing.Point(187, 14);
            this.tbDefaultPath.Name = "tbDefaultPath";
            this.tbDefaultPath.Size = new System.Drawing.Size(445, 22);
            this.tbDefaultPath.TabIndex = 4;
            // 
            // btSelectDefaultPath
            // 
            this.btSelectDefaultPath.Location = new System.Drawing.Point(639, 12);
            this.btSelectDefaultPath.Name = "btSelectDefaultPath";
            this.btSelectDefaultPath.Size = new System.Drawing.Size(149, 23);
            this.btSelectDefaultPath.TabIndex = 5;
            this.btSelectDefaultPath.Text = "Selecionar Caminho";
            this.btSelectDefaultPath.UseVisualStyleBackColor = true;
            this.btSelectDefaultPath.Click += new System.EventHandler(this.selectDefaultPath);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(572, 106);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 23);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.saveConfiguration);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(683, 106);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(105, 23);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.cancel);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 141);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btSelectDefaultPath);
            this.Controls.Add(this.tbDefaultPath);
            this.Controls.Add(this.lbDefaultPath);
            this.Controls.Add(this.btSelectSkeleton);
            this.Controls.Add(this.tbSkeleton);
            this.Controls.Add(this.lbSkeleton);
            this.Name = "ConfigurationForm";
            this.Text = "Configurações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.whenClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSkeleton;
        private System.Windows.Forms.TextBox tbSkeleton;
        private System.Windows.Forms.Button btSelectSkeleton;
        private System.Windows.Forms.Label lbDefaultPath;
        private System.Windows.Forms.TextBox tbDefaultPath;
        private System.Windows.Forms.Button btSelectDefaultPath;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}