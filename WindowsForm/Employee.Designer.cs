namespace WindowsForm
{
    partial class Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.ComboBox();
            this.Day = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.CheckEmail = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.RePassword = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.securityQues = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.State = new System.Windows.Forms.ComboBox();
            this.register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name :";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(151, 39);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(338, 22);
            this.FirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name :";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(151, 80);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(338, 22);
            this.LastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date of Birth :";
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.Month.Location = new System.Drawing.Point(151, 124);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(76, 24);
            this.Month.TabIndex = 6;
            this.Month.Text = "Month";
            // 
            // Day
            // 
            this.Day.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Day.FormattingEnabled = true;
            this.Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.Day.Location = new System.Drawing.Point(245, 122);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(69, 27);
            this.Day.TabIndex = 7;
            this.Day.Text = "Day";
            // 
            // Year
            // 
            this.Year.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000"});
            this.Year.Location = new System.Drawing.Point(336, 124);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(72, 27);
            this.Year.TabIndex = 8;
            this.Year.Text = "Year";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(151, 166);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(145, 24);
            this.Gender.TabIndex = 9;
            this.Gender.Text = "Choose a gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Information";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Retype Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Retype Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Security Question";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Security answer";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(165, 221);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(324, 22);
            this.Email.TabIndex = 18;
            // 
            // CheckEmail
            // 
            this.CheckEmail.Location = new System.Drawing.Point(165, 250);
            this.CheckEmail.Name = "CheckEmail";
            this.CheckEmail.Size = new System.Drawing.Size(324, 22);
            this.CheckEmail.TabIndex = 19;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(165, 276);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(324, 22);
            this.Password.TabIndex = 20;
            // 
            // RePassword
            // 
            this.RePassword.Location = new System.Drawing.Point(165, 305);
            this.RePassword.Name = "RePassword";
            this.RePassword.Size = new System.Drawing.Size(324, 22);
            this.RePassword.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(165, 365);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(324, 22);
            this.textBox7.TabIndex = 22;
            // 
            // securityQues
            // 
            this.securityQues.FormattingEnabled = true;
            this.securityQues.Items.AddRange(new object[] {
            "What is your date of Birth",
            "Fav color?",
            "Car number"});
            this.securityQues.Location = new System.Drawing.Point(165, 334);
            this.securityQues.Name = "securityQues";
            this.securityQues.Size = new System.Drawing.Size(324, 24);
            this.securityQues.TabIndex = 23;
            this.securityQues.Text = "Choose a security question";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "Contact Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(81, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(103, 472);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "City";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(93, 503);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "State";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(69, 532);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 28;
            this.label17.Text = "Zip Code";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(85, 567);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 17);
            this.label18.TabIndex = 29;
            this.label18.Text = "Phone";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(165, 440);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(324, 22);
            this.Address.TabIndex = 30;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(165, 472);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(324, 22);
            this.City.TabIndex = 31;
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(166, 532);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(136, 22);
            this.zip.TabIndex = 32;
            // 
            // phoneNo
            // 
            this.phoneNo.Location = new System.Drawing.Point(165, 567);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(324, 22);
            this.phoneNo.TabIndex = 33;
            // 
            // State
            // 
            this.State.FormattingEnabled = true;
            this.State.Items.AddRange(new object[] {
            "Bangladesh",
            "India",
            "Pakistan"});
            this.State.Location = new System.Drawing.Point(165, 503);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(324, 24);
            this.State.TabIndex = 34;
            this.State.Text = "Select a state";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.register.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(231, 631);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(105, 49);
            this.register.TabIndex = 35;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.RegisterClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(542, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 708);
            this.panel1.TabIndex = 36;
            this.panel1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBox1.Location = new System.Drawing.Point(33, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 680);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.State);
            this.Controls.Add(this.phoneNo);
            this.Controls.Add(this.zip);
            this.Controls.Add(this.City);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.securityQues);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.RePassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.CheckEmail);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Employee";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox CheckEmail;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox RePassword;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox securityQues;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.ComboBox State;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}