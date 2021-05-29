namespace BestBuy_Proyecto
{
    partial class frmAddWorker
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
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.txtBoxWorkerName = new System.Windows.Forms.TextBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.txtBoxWorkerPssw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWorkerRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(97, 239);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(189, 62);
            this.btnAddWorker.TabIndex = 0;
            this.btnAddWorker.Text = "Agregar trabajador";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // txtBoxWorkerName
            // 
            this.txtBoxWorkerName.Location = new System.Drawing.Point(97, 27);
            this.txtBoxWorkerName.Name = "txtBoxWorkerName";
            this.txtBoxWorkerName.Size = new System.Drawing.Size(189, 22);
            this.txtBoxWorkerName.TabIndex = 1;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Location = new System.Drawing.Point(151, 52);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(88, 17);
            this.lblWorkerName.TabIndex = 2;
            this.lblWorkerName.Text = "N. empleado";
            // 
            // txtBoxWorkerPssw
            // 
            this.txtBoxWorkerPssw.Location = new System.Drawing.Point(97, 99);
            this.txtBoxWorkerPssw.Name = "txtBoxWorkerPssw";
            this.txtBoxWorkerPssw.Size = new System.Drawing.Size(189, 22);
            this.txtBoxWorkerPssw.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña";
            // 
            // cmbWorkerRole
            // 
            this.cmbWorkerRole.FormattingEnabled = true;
            this.cmbWorkerRole.Location = new System.Drawing.Point(97, 169);
            this.cmbWorkerRole.Name = "cmbWorkerRole";
            this.cmbWorkerRole.Size = new System.Drawing.Size(189, 24);
            this.cmbWorkerRole.TabIndex = 5;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(171, 196);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 17);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Cargo";
            // 
            // frmAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(380, 328);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.cmbWorkerRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxWorkerPssw);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.txtBoxWorkerName);
            this.Controls.Add(this.btnAddWorker);
            this.Name = "frmAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar trabajador";
            this.Load += new System.EventHandler(this.frmAddWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox txtBoxWorkerName;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.TextBox txtBoxWorkerPssw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWorkerRole;
        private System.Windows.Forms.Label lblRole;
    }
}