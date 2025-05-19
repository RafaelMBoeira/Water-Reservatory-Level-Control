namespace WindowsFormsApp2
{
    partial class PortSelectionForm
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
            this.btUpdate = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ardPort = new System.IO.Ports.SerialPort(this.components);
            this.sfdLoad = new System.Windows.Forms.SaveFileDialog();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(9, 96);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 28);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "Atualizar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.updatePorts);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(117, 96);
            this.btSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(100, 28);
            this.btSelect.TabIndex = 1;
            this.btSelect.Text = "Selecionar";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.loadToBoard);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(225, 96);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 28);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.cancel);
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(88, 29);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(160, 24);
            this.cbPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione a porta de comunicação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMessage
            // 
            this.lbMessage.Location = new System.Drawing.Point(11, 66);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(317, 16);
            this.lbMessage.TabIndex = 6;
            this.lbMessage.Text = "teste";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMessage.Visible = false;
            // 
            // PortSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 137);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PortSelectionForm";
            this.Text = "Conexão";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.whenClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog sfdLoad;
        public System.IO.Ports.SerialPort ardPort;
        private System.Windows.Forms.Label lbMessage;
    }
}