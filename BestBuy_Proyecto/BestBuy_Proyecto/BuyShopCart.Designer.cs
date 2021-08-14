
namespace BestBuy_Proyecto
{
    partial class BuyShopCart
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
            this.dataGridViewCarrito = new System.Windows.Forms.DataGridView();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.lblActualCart = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.AllowUserToOrderColumns = true;
            this.dataGridViewCarrito.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarrito.GridColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(104, 76);
            this.dataGridViewCarrito.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.Size = new System.Drawing.Size(560, 185);
            this.dataGridViewCarrito.TabIndex = 0;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Location = new System.Drawing.Point(225, 44);
            this.lblShoppingCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(132, 17);
            this.lblShoppingCart.TabIndex = 1;
            this.lblShoppingCart.Text = "Carrito de compras:";
            // 
            // lblActualCart
            // 
            this.lblActualCart.AutoSize = true;
            this.lblActualCart.Location = new System.Drawing.Point(124, 299);
            this.lblActualCart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualCart.Name = "lblActualCart";
            this.lblActualCart.Size = new System.Drawing.Size(154, 17);
            this.lblActualCart.TabIndex = 2;
            this.lblActualCart.Text = "Actualmente en carrito:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.numericUpDown1.Location = new System.Drawing.Point(287, 297);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(359, 297);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuy.Location = new System.Drawing.Point(208, 364);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(196, 50);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Comprar";
            this.btnBuy.UseVisualStyleBackColor = false;
            // 
            // BuyShopCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(744, 494);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblActualCart);
            this.Controls.Add(this.lblShoppingCart);
            this.Controls.Add(this.dataGridViewCarrito);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuyShopCart";
            this.Text = "Carrito de compras";
            this.Load += new System.EventHandler(this.BuyShopCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarrito;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Label lblActualCart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBuy;
    }
}