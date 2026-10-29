namespace Multiple_Course_Registration_System
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
            this.lscourses = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lsresult = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btncourseremove = new System.Windows.Forms.Button();
            this.txtcourseprice = new System.Windows.Forms.TextBox();
            this.lblcourseprice = new System.Windows.Forms.Label();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.lblcoursename = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Scolarship = new System.Windows.Forms.GroupBox();
            this.chkScholarship = new System.Windows.Forms.CheckBox();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Scolarship.SuspendLayout();
            this.SuspendLayout();
            // 
            // lscourses
            // 
            this.lscourses.FormattingEnabled = true;
            this.lscourses.Location = new System.Drawing.Point(18, 28);
            this.lscourses.Name = "lscourses";
            this.lscourses.Size = new System.Drawing.Size(353, 121);
            this.lscourses.TabIndex = 151;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(28, 371);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 34);
            this.button4.TabIndex = 168;
            this.button4.Text = "Add Course";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(716, 625);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 48);
            this.button3.TabIndex = 167;
            this.button3.Text = "Exist";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(581, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 48);
            this.button1.TabIndex = 166;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox5.Controls.Add(this.lscourses);
            this.groupBox5.Location = new System.Drawing.Point(28, 503);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(389, 170);
            this.groupBox5.TabIndex = 162;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Course Information";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(442, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 48);
            this.button2.TabIndex = 165;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lsresult
            // 
            this.lsresult.FormattingEnabled = true;
            this.lsresult.Location = new System.Drawing.Point(18, 26);
            this.lsresult.Name = "lsresult";
            this.lsresult.Size = new System.Drawing.Size(353, 472);
            this.lsresult.TabIndex = 151;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox6.Controls.Add(this.lsresult);
            this.groupBox6.Location = new System.Drawing.Point(442, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(389, 522);
            this.groupBox6.TabIndex = 164;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Course Information";
            // 
            // btncourseremove
            // 
            this.btncourseremove.BackColor = System.Drawing.Color.Red;
            this.btncourseremove.ForeColor = System.Drawing.Color.White;
            this.btncourseremove.Location = new System.Drawing.Point(232, 371);
            this.btncourseremove.Name = "btncourseremove";
            this.btncourseremove.Size = new System.Drawing.Size(185, 34);
            this.btncourseremove.TabIndex = 163;
            this.btncourseremove.Text = "Remove Course";
            this.btncourseremove.UseVisualStyleBackColor = false;
            this.btncourseremove.Click += new System.EventHandler(this.btncourseremove_Click);
            // 
            // txtcourseprice
            // 
            this.txtcourseprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcourseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourseprice.Location = new System.Drawing.Point(135, 70);
            this.txtcourseprice.Name = "txtcourseprice";
            this.txtcourseprice.Size = new System.Drawing.Size(237, 26);
            this.txtcourseprice.TabIndex = 144;
            // 
            // lblcourseprice
            // 
            this.lblcourseprice.AutoSize = true;
            this.lblcourseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourseprice.Location = new System.Drawing.Point(15, 73);
            this.lblcourseprice.Name = "lblcourseprice";
            this.lblcourseprice.Size = new System.Drawing.Size(103, 20);
            this.lblcourseprice.TabIndex = 143;
            this.lblcourseprice.Text = "Course Price:";
            // 
            // txtcoursename
            // 
            this.txtcoursename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcoursename.Location = new System.Drawing.Point(135, 33);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(237, 26);
            this.txtcoursename.TabIndex = 142;
            // 
            // lblcoursename
            // 
            this.lblcoursename.AutoSize = true;
            this.lblcoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoursename.Location = new System.Drawing.Point(15, 35);
            this.lblcoursename.Name = "lblcoursename";
            this.lblcoursename.Size = new System.Drawing.Size(108, 20);
            this.lblcoursename.TabIndex = 141;
            this.lblcoursename.Text = "Course name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.txtcourseprice);
            this.groupBox2.Controls.Add(this.lblcourseprice);
            this.groupBox2.Controls.Add(this.txtcoursename);
            this.groupBox2.Controls.Add(this.lblcoursename);
            this.groupBox2.Location = new System.Drawing.Point(28, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 116);
            this.groupBox2.TabIndex = 161;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.lblid);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.lblage);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Location = new System.Drawing.Point(28, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 138);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(135, 108);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(237, 26);
            this.txtid.TabIndex = 146;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(15, 112);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(91, 20);
            this.lblid.TabIndex = 145;
            this.lblid.Text = "Student ID:";
            // 
            // txtage
            // 
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(135, 70);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(237, 26);
            this.txtage.TabIndex = 144;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(15, 73);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(101, 20);
            this.lblage.TabIndex = 143;
            this.lblage.Text = "Student age:";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(135, 33);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(237, 26);
            this.txtname.TabIndex = 142;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(15, 35);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(114, 20);
            this.lblname.TabIndex = 141;
            this.lblname.Text = "Student name:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(173, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(478, 31);
            this.title.TabIndex = 0;
            this.title.Text = "Student Course Regestaration System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 53);
            this.panel1.TabIndex = 159;
            // 
            // Scolarship
            // 
            this.Scolarship.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Scolarship.Controls.Add(this.chkScholarship);
            this.Scolarship.Location = new System.Drawing.Point(28, 421);
            this.Scolarship.Name = "Scolarship";
            this.Scolarship.Size = new System.Drawing.Size(389, 64);
            this.Scolarship.TabIndex = 162;
            this.Scolarship.TabStop = false;
            this.Scolarship.Text = "Scolarship";
            // 
            // chkScholarship
            // 
            this.chkScholarship.AutoSize = true;
            this.chkScholarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScholarship.Location = new System.Drawing.Point(16, 25);
            this.chkScholarship.Name = "chkScholarship";
            this.chkScholarship.Size = new System.Drawing.Size(200, 24);
            this.chkScholarship.TabIndex = 145;
            this.chkScholarship.Text = "Get Scolarship Discount";
            this.chkScholarship.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 697);
            this.Controls.Add(this.Scolarship);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btncourseremove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Scolarship.ResumeLayout(false);
            this.Scolarship.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lscourses;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lsresult;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btncourseremove;
        private System.Windows.Forms.TextBox txtcourseprice;
        private System.Windows.Forms.Label lblcourseprice;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.Label lblcoursename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Scolarship;
        private System.Windows.Forms.CheckBox chkScholarship;
    }
}

