namespace Airline_Ticked_Booking_System
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbinsurance = new System.Windows.Forms.CheckBox();
            this.rdnormal = new System.Windows.Forms.RadioButton();
            this.rdfirst = new System.Windows.Forms.RadioButton();
            this.rdbussiness = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbltickets = new System.Windows.Forms.Label();
            this.txtbaggage = new System.Windows.Forms.TextBox();
            this.lblbaggage = new System.Windows.Forms.Label();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbinsurance);
            this.groupBox2.Location = new System.Drawing.Point(44, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 66);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additional Options";
            // 
            // cbinsurance
            // 
            this.cbinsurance.AutoSize = true;
            this.cbinsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbinsurance.Location = new System.Drawing.Point(17, 27);
            this.cbinsurance.Name = "cbinsurance";
            this.cbinsurance.Size = new System.Drawing.Size(281, 20);
            this.cbinsurance.TabIndex = 145;
            this.cbinsurance.Text = "Add Travel Insurance ($25 Per ticket)";
            this.cbinsurance.UseVisualStyleBackColor = true;
            // 
            // rdnormal
            // 
            this.rdnormal.AutoSize = true;
            this.rdnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdnormal.Location = new System.Drawing.Point(132, 24);
            this.rdnormal.Name = "rdnormal";
            this.rdnormal.Size = new System.Drawing.Size(118, 20);
            this.rdnormal.TabIndex = 143;
            this.rdnormal.TabStop = true;
            this.rdnormal.Text = "Normal Class";
            this.rdnormal.UseVisualStyleBackColor = true;
            // 
            // rdfirst
            // 
            this.rdfirst.AutoSize = true;
            this.rdfirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdfirst.Location = new System.Drawing.Point(19, 24);
            this.rdfirst.Name = "rdfirst";
            this.rdfirst.Size = new System.Drawing.Size(98, 20);
            this.rdfirst.TabIndex = 142;
            this.rdfirst.TabStop = true;
            this.rdfirst.Text = "First Class";
            this.rdfirst.UseVisualStyleBackColor = true;
            // 
            // rdbussiness
            // 
            this.rdbussiness.AutoSize = true;
            this.rdbussiness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbussiness.Location = new System.Drawing.Point(266, 24);
            this.rdbussiness.Name = "rdbussiness";
            this.rdbussiness.Size = new System.Drawing.Size(139, 20);
            this.rdbussiness.TabIndex = 151;
            this.rdbussiness.TabStop = true;
            this.rdbussiness.Text = "Bussiness Class";
            this.rdbussiness.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbussiness);
            this.groupBox3.Controls.Add(this.rdnormal);
            this.groupBox3.Controls.Add(this.rdfirst);
            this.groupBox3.Location = new System.Drawing.Point(45, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 61);
            this.groupBox3.TabIndex = 152;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(565, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 342);
            this.listBox1.TabIndex = 153;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.Green;
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncalculate.Location = new System.Drawing.Point(44, 473);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(160, 39);
            this.btncalculate.TabIndex = 154;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnclear.Location = new System.Drawing.Point(219, 473);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(160, 39);
            this.btnclear.TabIndex = 155;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(393, 473);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(160, 39);
            this.btnexit.TabIndex = 156;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(30, 34);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(166, 24);
            this.lblname.TabIndex = 136;
            this.lblname.Text = "Passenger Name :";
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
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(30, 78);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(147, 24);
            this.lblage.TabIndex = 138;
            this.lblage.Text = "Passenger age :";
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
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltickets.Location = new System.Drawing.Point(30, 123);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(183, 24);
            this.lbltickets.TabIndex = 140;
            this.lbltickets.Text = "Number Of Trickets :";
            // 
            // txtbaggage
            // 
            this.txtbaggage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbaggage.Location = new System.Drawing.Point(242, 164);
            this.txtbaggage.Name = "txtbaggage";
            this.txtbaggage.Size = new System.Drawing.Size(237, 31);
            this.txtbaggage.TabIndex = 141;
            // 
            // lblbaggage
            // 
            this.lblbaggage.AutoSize = true;
            this.lblbaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaggage.Location = new System.Drawing.Point(30, 167);
            this.lblbaggage.Name = "lblbaggage";
            this.lblbaggage.Size = new System.Drawing.Size(192, 24);
            this.lblbaggage.TabIndex = 142;
            this.lblbaggage.Text = "Baggage Weight(kg) :";
            // 
            // txttickets
            // 
            this.txttickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttickets.Location = new System.Drawing.Point(242, 120);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(237, 31);
            this.txttickets.TabIndex = 143;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttickets);
            this.groupBox1.Controls.Add(this.lblbaggage);
            this.groupBox1.Controls.Add(this.txtbaggage);
            this.groupBox1.Controls.Add(this.lbltickets);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(44, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 228);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 534);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "AIRLINE BOOKING DETAILS";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbinsurance;
        private System.Windows.Forms.RadioButton rdnormal;
        private System.Windows.Forms.RadioButton rdfirst;
        private System.Windows.Forms.RadioButton rdbussiness;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.TextBox txtbaggage;
        private System.Windows.Forms.Label lblbaggage;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

