namespace BestBuy_Proyecto
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.picBoxLog = new System.Windows.Forms.PictureBox();
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.picBoxProducts = new System.Windows.Forms.PictureBox();
            this.picBoxUsers = new System.Windows.Forms.PictureBox();
            this.picBoxWorkers = new System.Windows.Forms.PictureBox();
            this.lblWorkers = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblHMworkers = new System.Windows.Forms.Label();
            this.lblHMusers = new System.Windows.Forms.Label();
            this.lblHMproducts = new System.Windows.Forms.Label();
            this.lblAddWorker = new System.Windows.Forms.Label();
            this.arduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDashboard.Controls.Add(this.lblLog);
            this.pnlDashboard.Controls.Add(this.lblProducto);
            this.pnlDashboard.Controls.Add(this.picBoxLog);
            this.pnlDashboard.Controls.Add(this.picBoxProduct);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(145, 239);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(38, 207);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(64, 17);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "Logistica";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(38, 85);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(65, 17);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Text = "Producto";
            // 
            // picBoxLog
            // 
            this.picBoxLog.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLog.Image")));
            this.picBoxLog.Location = new System.Drawing.Point(24, 144);
            this.picBoxLog.Name = "picBoxLog";
            this.picBoxLog.Size = new System.Drawing.Size(91, 62);
            this.picBoxLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLog.TabIndex = 1;
            this.picBoxLog.TabStop = false;
            this.picBoxLog.Click += new System.EventHandler(this.picBoxLog_Click);
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProduct.Image")));
            this.picBoxProduct.InitialImage = null;
            this.picBoxProduct.Location = new System.Drawing.Point(24, 22);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(91, 56);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduct.TabIndex = 0;
            this.picBoxProduct.TabStop = false;
            this.picBoxProduct.Click += new System.EventHandler(this.picBoxProduct_Click);
            // 
            // picBoxProducts
            // 
            this.picBoxProducts.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProducts.Image")));
            this.picBoxProducts.InitialImage = null;
            this.picBoxProducts.Location = new System.Drawing.Point(526, 78);
            this.picBoxProducts.Name = "picBoxProducts";
            this.picBoxProducts.Size = new System.Drawing.Size(110, 110);
            this.picBoxProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProducts.TabIndex = 4;
            this.picBoxProducts.TabStop = false;
            // 
            // picBoxUsers
            // 
            this.picBoxUsers.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsers.Image")));
            this.picBoxUsers.InitialImage = null;
            this.picBoxUsers.Location = new System.Drawing.Point(372, 87);
            this.picBoxUsers.Name = "picBoxUsers";
            this.picBoxUsers.Size = new System.Drawing.Size(95, 85);
            this.picBoxUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxUsers.TabIndex = 3;
            this.picBoxUsers.TabStop = false;
            // 
            // picBoxWorkers
            // 
            this.picBoxWorkers.Image = ((System.Drawing.Image)(resources.GetObject("picBoxWorkers.Image")));
            this.picBoxWorkers.InitialImage = null;
            this.picBoxWorkers.Location = new System.Drawing.Point(220, 82);
            this.picBoxWorkers.Name = "picBoxWorkers";
            this.picBoxWorkers.Size = new System.Drawing.Size(90, 90);
            this.picBoxWorkers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxWorkers.TabIndex = 2;
            this.picBoxWorkers.TabStop = false;
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkers.Location = new System.Drawing.Point(197, 52);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(119, 20);
            this.lblWorkers.TabIndex = 4;
            this.lblWorkers.Text = "Trabajadores";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(377, 52);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(78, 20);
            this.lblUsers.TabIndex = 5;
            this.lblUsers.Text = "Clientes";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(527, 52);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(94, 20);
            this.lblProducts.TabIndex = 6;
            this.lblProducts.Text = "Productos";
            // 
            // lblHMworkers
            // 
            this.lblHMworkers.AutoSize = true;
            this.lblHMworkers.Location = new System.Drawing.Point(258, 181);
            this.lblHMworkers.Name = "lblHMworkers";
            this.lblHMworkers.Size = new System.Drawing.Size(16, 17);
            this.lblHMworkers.TabIndex = 4;
            this.lblHMworkers.Text = "4";
            // 
            // lblHMusers
            // 
            this.lblHMusers.AutoSize = true;
            this.lblHMusers.Location = new System.Drawing.Point(412, 181);
            this.lblHMusers.Name = "lblHMusers";
            this.lblHMusers.Size = new System.Drawing.Size(16, 17);
            this.lblHMusers.TabIndex = 7;
            this.lblHMusers.Text = "4";
            // 
            // lblHMproducts
            // 
            this.lblHMproducts.AutoSize = true;
            this.lblHMproducts.Location = new System.Drawing.Point(568, 181);
            this.lblHMproducts.Name = "lblHMproducts";
            this.lblHMproducts.Size = new System.Drawing.Size(16, 17);
            this.lblHMproducts.TabIndex = 8;
            this.lblHMproducts.Text = "4";
            // 
            // lblAddWorker
            // 
            this.lblAddWorker.AutoSize = true;
            this.lblAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWorker.Location = new System.Drawing.Point(294, 82);
            this.lblAddWorker.Name = "lblAddWorker";
            this.lblAddWorker.Size = new System.Drawing.Size(27, 29);
            this.lblAddWorker.TabIndex = 9;
            this.lblAddWorker.Text = "+";
            this.lblAddWorker.Click += new System.EventHandler(this.lblAddWorker_Click);
            // 
            // arduinoSerialPort
            // 
            this.arduinoSerialPort.PortName = "COM5";
            this.arduinoSerialPort.ReadTimeout = 2000;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(700, 239);
            this.Controls.Add(this.lblAddWorker);
            this.Controls.Add(this.lblHMproducts);
            this.Controls.Add(this.lblHMusers);
            this.Controls.Add(this.lblHMworkers);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.lblWorkers);
            this.Controls.Add(this.picBoxProducts);
            this.Controls.Add(this.picBoxUsers);
            this.Controls.Add(this.picBoxWorkers);
            this.Controls.Add(this.pnlDashboard);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.VisibleChanged += new System.EventHandler(this.frmDashboard_VisibleChanged);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxWorkers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox picBoxLog;
        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.PictureBox picBoxWorkers;
        private System.Windows.Forms.PictureBox picBoxUsers;
        private System.Windows.Forms.PictureBox picBoxProducts;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblWorkers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblHMworkers;
        private System.Windows.Forms.Label lblHMusers;
        private System.Windows.Forms.Label lblHMproducts;
        private System.Windows.Forms.Label lblAddWorker;
        private System.IO.Ports.SerialPort arduinoSerialPort;
    }
}

