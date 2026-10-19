namespace Hotel_Room_Booking_System
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncalculate = new System.Windows.Forms.Button();
            this.Booking_details = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdhight = new System.Windows.Forms.RadioButton();
            this.rdnormal = new System.Windows.Forms.RadioButton();
            this.rdstandard = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbreakfast = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnight = new System.Windows.Forms.TextBox();
            this.lblbaggage = new System.Windows.Forms.Label();
            this.txtguest = new System.Windows.Forms.TextBox();
            this.lbltickets = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(392, 496);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 39);
            this.btnexit.TabIndex = 163;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(218, 496);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 39);
            this.btnclear.TabIndex = 162;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Green;
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Location = new System.Drawing.Point(43, 496);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(160, 39);
            this.btncalculate.TabIndex = 161;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // Booking_details
            // 
            this.Booking_details.FormattingEnabled = true;
            this.Booking_details.Location = new System.Drawing.Point(564, 72);
            this.Booking_details.Name = "Booking_details";
            this.Booking_details.Size = new System.Drawing.Size(215, 342);
            this.Booking_details.TabIndex = 160;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdhight);
            this.groupBox3.Controls.Add(this.rdnormal);
            this.groupBox3.Controls.Add(this.rdstandard);
            this.groupBox3.Location = new System.Drawing.Point(44, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 61);
            this.groupBox3.TabIndex = 159;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Room Type";
            // 
            // rdhight
            // 
            this.rdhight.AutoSize = true;
            this.rdhight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdhight.Location = new System.Drawing.Point(240, 24);
            this.rdhight.Name = "rdhight";
            this.rdhight.Size = new System.Drawing.Size(61, 20);
            this.rdhight.TabIndex = 151;
            this.rdhight.TabStop = true;
            this.rdhight.Text = "Hight";
            this.rdhight.UseVisualStyleBackColor = true;
            // 
            // rdnormal
            // 
            this.rdnormal.AutoSize = true;
            this.rdnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnormal.Location = new System.Drawing.Point(136, 24);
            this.rdnormal.Name = "rdnormal";
            this.rdnormal.Size = new System.Drawing.Size(75, 20);
            this.rdnormal.TabIndex = 143;
            this.rdnormal.TabStop = true;
            this.rdnormal.Text = "Normal";
            this.rdnormal.UseVisualStyleBackColor = true;
            // 
            // rdstandard
            // 
            this.rdstandard.AutoSize = true;
            this.rdstandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdstandard.Location = new System.Drawing.Point(19, 24);
            this.rdstandard.Name = "rdstandard";
            this.rdstandard.Size = new System.Drawing.Size(88, 20);
            this.rdstandard.TabIndex = 142;
            this.rdstandard.TabStop = true;
            this.rdstandard.Text = "Standard";
            this.rdstandard.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbreakfast);
            this.groupBox2.Location = new System.Drawing.Point(43, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 66);
            this.groupBox2.TabIndex = 158;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            // 
            // cbbreakfast
            // 
            this.cbbreakfast.AutoSize = true;
            this.cbbreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbreakfast.Location = new System.Drawing.Point(17, 27);
            this.cbbreakfast.Name = "cbbreakfast";
            this.cbbreakfast.Size = new System.Drawing.Size(271, 20);
            this.cbbreakfast.TabIndex = 145;
            this.cbbreakfast.Text = "BreakFast (10 Per Guest per nights)";
            this.cbbreakfast.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnight);
            this.groupBox1.Controls.Add(this.lblbaggage);
            this.groupBox1.Controls.Add(this.txtguest);
            this.groupBox1.Controls.Add(this.lbltickets);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(43, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 228);
            this.groupBox1.TabIndex = 157;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // txtnight
            // 
            this.txtnight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnight.Location = new System.Drawing.Point(242, 120);
            this.txtnight.Name = "txtnight";
            this.txtnight.Size = new System.Drawing.Size(237, 31);
            this.txtnight.TabIndex = 143;
            // 
            // lblbaggage
            // 
            this.lblbaggage.AutoSize = true;
            this.lblbaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaggage.Location = new System.Drawing.Point(30, 167);
            this.lblbaggage.Name = "lblbaggage";
            this.lblbaggage.Size = new System.Drawing.Size(167, 24);
            this.lblbaggage.TabIndex = 142;
            this.lblbaggage.Text = "Number Of Guest :";
            // 
            // txtguest
            // 
            this.txtguest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtguest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtguest.Location = new System.Drawing.Point(242, 164);
            this.txtguest.Name = "txtguest";
            this.txtguest.Size = new System.Drawing.Size(237, 31);
            this.txtguest.TabIndex = 141;
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltickets.Location = new System.Drawing.Point(30, 123);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(162, 24);
            this.lbltickets.TabIndex = 140;
            this.lbltickets.Text = "Number Of Night :";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(242, 31);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 31);
            this.txtname.TabIndex = 139;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(30, 78);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(106, 24);
            this.lblage.TabIndex = 138;
            this.lblage.Text = "Guest age :";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(242, 75);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(237, 31);
            this.txtage.TabIndex = 137;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(30, 34);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(125, 24);
            this.lblname.TabIndex = 136;
            this.lblname.Text = "Guest Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 39);
            this.panel1.TabIndex = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 29);
            this.label1.TabIndex = 165;
            this.label1.Text = "Hotel Room Booking System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.Booking_details);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hotel Room Booking System";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.ListBox Booking_details;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdhight;
        private System.Windows.Forms.RadioButton rdnormal;
        private System.Windows.Forms.RadioButton rdstandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbbreakfast;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnight;
        private System.Windows.Forms.Label lblbaggage;
        private System.Windows.Forms.TextBox txtguest;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

