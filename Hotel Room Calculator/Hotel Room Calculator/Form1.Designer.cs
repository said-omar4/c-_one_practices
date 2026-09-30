namespace Hotel_Room_Calculator
{
    partial class Form1
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
            this.lblServiceTax = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldiscon = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.txtPriceNight = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblroom = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtGustName = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServiceTax
            // 
            this.lblServiceTax.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblServiceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblServiceTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceTax.Location = new System.Drawing.Point(233, 392);
            this.lblServiceTax.Name = "lblServiceTax";
            this.lblServiceTax.Size = new System.Drawing.Size(224, 24);
            this.lblServiceTax.TabIndex = 30;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(233, 468);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(224, 24);
            this.lblTotalAmount.TabIndex = 29;
            // 
            // lblDiscount
            // 
            this.lblDiscount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(233, 430);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(224, 24);
            this.lblDiscount.TabIndex = 28;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(60, 392);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(167, 24);
            this.lblTax.TabIndex = 27;
            this.lblTax.Text = "Service Tax(10%) :";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(60, 468);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(132, 24);
            this.lbltotal.TabIndex = 26;
            this.lbltotal.Text = "Total Amount :";
            // 
            // lbldiscon
            // 
            this.lbldiscon.AutoSize = true;
            this.lbldiscon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscon.Location = new System.Drawing.Point(60, 430);
            this.lbldiscon.Name = "lbldiscon";
            this.lbldiscon.Size = new System.Drawing.Size(130, 24);
            this.lbldiscon.TabIndex = 25;
            this.lbldiscon.Text = "Discount(5%) :";
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Green;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.Color.White;
            this.btncalculate.Location = new System.Drawing.Point(64, 322);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(393, 41);
            this.btncalculate.TabIndex = 24;
            this.btncalculate.Text = "Calculate Booking";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // txtPriceNight
            // 
            this.txtPriceNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceNight.Location = new System.Drawing.Point(268, 264);
            this.txtPriceNight.Name = "txtPriceNight";
            this.txtPriceNight.Size = new System.Drawing.Size(189, 29);
            this.txtPriceNight.TabIndex = 23;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(268, 165);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(189, 29);
            this.txtRoomType.TabIndex = 22;
            // 
            // txtNights
            // 
            this.txtNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNights.Location = new System.Drawing.Point(268, 215);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(189, 29);
            this.txtNights.TabIndex = 21;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(60, 269);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(196, 24);
            this.lblPrice.TabIndex = 20;
            this.lblPrice.Text = "Enter Price Per Night :";
            // 
            // lblroom
            // 
            this.lblroom.AutoSize = true;
            this.lblroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroom.Location = new System.Drawing.Point(60, 165);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(169, 24);
            this.lblroom.TabIndex = 19;
            this.lblroom.Text = "Enter Room Type :";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(60, 218);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(189, 24);
            this.lblNumber.TabIndex = 18;
            this.lblNumber.Text = "Enter Num of Nights :";
            // 
            // txtGustName
            // 
            this.txtGustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGustName.Location = new System.Drawing.Point(268, 114);
            this.txtGustName.Name = "txtGustName";
            this.txtGustName.Size = new System.Drawing.Size(189, 29);
            this.txtGustName.TabIndex = 17;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(60, 114);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(164, 24);
            this.lblname.TabIndex = 16;
            this.lblname.Text = "Enter Gust Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(80, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 33);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hotel Booking Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblServiceTax);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbldiscon);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txtPriceNight);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtGustName);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblServiceTax;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldiscon;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.TextBox txtPriceNight;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtGustName;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
    }
}

