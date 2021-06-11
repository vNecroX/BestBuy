
namespace BestBuy_Proyecto
{
    partial class frmSelectProduct
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
            this.numericUpDownProducts = new System.Windows.Forms.NumericUpDown();
            this.lblReturn = new System.Windows.Forms.Label();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblOpTotal = new System.Windows.Forms.Label();
            this.lblUnitaryPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAddToCar = new System.Windows.Forms.Label();
            this.pictureBoxMarketCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarketCar)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownProducts
            // 
            this.numericUpDownProducts.BackColor = System.Drawing.Color.LightSteelBlue;
            this.numericUpDownProducts.Location = new System.Drawing.Point(90, 204);
            this.numericUpDownProducts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProducts.Name = "numericUpDownProducts";
            this.numericUpDownProducts.Size = new System.Drawing.Size(38, 20);
            this.numericUpDownProducts.TabIndex = 3;
            this.numericUpDownProducts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProducts.ValueChanged += new System.EventHandler(this.numericUpDownProducts_ValueChanged);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(291, 306);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(50, 13);
            this.lblReturn.TabIndex = 7;
            this.lblReturn.Text = "Regresar";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Location = new System.Drawing.Point(74, 60);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(178, 108);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(50, 243);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(78, 13);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Precio total:   $";
            // 
            // lblOpTotal
            // 
            this.lblOpTotal.AutoSize = true;
            this.lblOpTotal.Location = new System.Drawing.Point(148, 243);
            this.lblOpTotal.Name = "lblOpTotal";
            this.lblOpTotal.Size = new System.Drawing.Size(19, 13);
            this.lblOpTotal.TabIndex = 5;
            this.lblOpTotal.Text = "----";
            // 
            // lblUnitaryPrice
            // 
            this.lblUnitaryPrice.AutoSize = true;
            this.lblUnitaryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitaryPrice.Location = new System.Drawing.Point(71, 32);
            this.lblUnitaryPrice.Name = "lblUnitaryPrice";
            this.lblUnitaryPrice.Size = new System.Drawing.Size(131, 15);
            this.lblUnitaryPrice.TabIndex = 10;
            this.lblUnitaryPrice.Text = "Precio Unitario:    $";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(229, 32);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(48, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Precio";
            // 
            // lblAddToCar
            // 
            this.lblAddToCar.AutoSize = true;
            this.lblAddToCar.Location = new System.Drawing.Point(222, 250);
            this.lblAddToCar.Name = "lblAddToCar";
            this.lblAddToCar.Size = new System.Drawing.Size(86, 13);
            this.lblAddToCar.TabIndex = 12;
            this.lblAddToCar.Text = "Mandar al carrito";
            // 
            // pictureBoxMarketCar
            // 
            this.pictureBoxMarketCar.Image = global::BestBuy_Proyecto.Properties.Resources.superMarketCar;
            this.pictureBoxMarketCar.Location = new System.Drawing.Point(232, 191);
            this.pictureBoxMarketCar.Name = "pictureBoxMarketCar";
            this.pictureBoxMarketCar.Size = new System.Drawing.Size(62, 52);
            this.pictureBoxMarketCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarketCar.TabIndex = 11;
            this.pictureBoxMarketCar.TabStop = false;
            this.pictureBoxMarketCar.Click += new System.EventHandler(this.pictureBoxMarketCar_Click);
            // 
            // frmSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(376, 328);
            this.Controls.Add(this.lblAddToCar);
            this.Controls.Add(this.pictureBoxMarketCar);
            this.Controls.Add(this.lblUnitaryPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblOpTotal);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.numericUpDownProducts);
            this.Controls.Add(this.pictureBoxProduct);
            this.Name = "frmSelectProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista del producto";
            this.Load += new System.EventHandler(this.frmSelectProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarketCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownProducts;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblOpTotal;
        private System.Windows.Forms.Label lblUnitaryPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAddToCar;
        private System.Windows.Forms.PictureBox pictureBoxMarketCar;
    }
}