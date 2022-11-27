using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ArashZomorrodi_01._08._30
{
    partial class MyNewForm : Form
    {
        public MyNewForm InfoForm;
        private MyNewTextbox FirstNameTxt;
        private MyNewTextbox LastNameTxt;
        private MyNewTextbox IDtxt;
        private MyNewTextbox BirthDateTxt;
        private MyNewTextbox AddressTxt;
        private MyNewCheckbox StudentCheck;
        private MyNewTextbox StudentIDtxt;
        private MyNewTextbox EntrySemesterTxt;
        private MyNewLable myNewLable1;
        private MyNewLable myNewLable2;
        private MyNewLable myNewLable3;
        private MyNewLable myNewLable4;
        private MyNewLable myNewLable5;
        private MyNewLable myNewLable6;
        private MyNewLable myNewLable7;
        private MyNewLable myNewLable8;
        private MyNewComboBox MajorCmboBx;
        private MyNewButton SubmitBtn;



        
        private void InitializeComponent()
        {
            this.MajorCmboBx = new ArashZomorrodi_01._08._30.MyNewComboBox();
            this.myNewLable8 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable7 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable6 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable5 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable4 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable3 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable2 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.myNewLable1 = new ArashZomorrodi_01._08._30.MyNewLable();
            this.EntrySemesterTxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.StudentIDtxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.StudentCheck = new ArashZomorrodi_01._08._30.MyNewCheckbox();
            this.AddressTxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.BirthDateTxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.IDtxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.LastNameTxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.FirstNameTxt = new ArashZomorrodi_01._08._30.MyNewTextbox();
            this.SubmitBtn = new ArashZomorrodi_01._08._30.MyNewButton();
            this.SuspendLayout();
            // 
            // MajorCmboBx
            // 
            this.MajorCmboBx.Enabled = false;
            this.MajorCmboBx.FormattingEnabled = true;
            this.MajorCmboBx.Location = new System.Drawing.Point(131, 333);
            this.MajorCmboBx.Name = "MajorCmboBx";
            this.MajorCmboBx.Size = new System.Drawing.Size(117, 24);
            this.MajorCmboBx.TabIndex = 18;
            // 
            // myNewLable8
            // 
            this.myNewLable8.AutoSize = true;
            this.myNewLable8.Location = new System.Drawing.Point(292, 74);
            this.myNewLable8.Name = "myNewLable8";
            this.myNewLable8.Size = new System.Drawing.Size(64, 16);
            this.myNewLable8.TabIndex = 17;
            this.myNewLable8.Text = "Address :";
            this.myNewLable8.Click += new System.EventHandler(this.myNewLable8_Click);
            // 
            // myNewLable7
            // 
            this.myNewLable7.AutoSize = true;
            this.myNewLable7.Location = new System.Drawing.Point(292, 30);
            this.myNewLable7.Name = "myNewLable7";
            this.myNewLable7.Size = new System.Drawing.Size(71, 16);
            this.myNewLable7.TabIndex = 16;
            this.myNewLable7.Text = "Birth Date :";
            // 
            // myNewLable6
            // 
            this.myNewLable6.AutoSize = true;
            this.myNewLable6.Location = new System.Drawing.Point(12, 290);
            this.myNewLable6.Name = "myNewLable6";
            this.myNewLable6.Size = new System.Drawing.Size(104, 16);
            this.myNewLable6.TabIndex = 15;
            this.myNewLable6.Text = "Entry Semester :";
            // 
            // myNewLable5
            // 
            this.myNewLable5.AutoSize = true;
            this.myNewLable5.Location = new System.Drawing.Point(69, 336);
            this.myNewLable5.Name = "myNewLable5";
            this.myNewLable5.Size = new System.Drawing.Size(47, 16);
            this.myNewLable5.TabIndex = 14;
            this.myNewLable5.Text = "Major :";
            // 
            // myNewLable4
            // 
            this.myNewLable4.AutoSize = true;
            this.myNewLable4.Location = new System.Drawing.Point(42, 243);
            this.myNewLable4.Name = "myNewLable4";
            this.myNewLable4.Size = new System.Drawing.Size(74, 16);
            this.myNewLable4.TabIndex = 13;
            this.myNewLable4.Text = "Student ID :";
            // 
            // myNewLable3
            // 
            this.myNewLable3.AutoSize = true;
            this.myNewLable3.Location = new System.Drawing.Point(90, 117);
            this.myNewLable3.Name = "myNewLable3";
            this.myNewLable3.Size = new System.Drawing.Size(26, 16);
            this.myNewLable3.TabIndex = 12;
            this.myNewLable3.Text = "ID :";
            // 
            // myNewLable2
            // 
            this.myNewLable2.AutoSize = true;
            this.myNewLable2.Location = new System.Drawing.Point(38, 74);
            this.myNewLable2.Name = "myNewLable2";
            this.myNewLable2.Size = new System.Drawing.Size(78, 16);
            this.myNewLable2.TabIndex = 11;
            this.myNewLable2.Text = "Last Name :";
            // 
            // myNewLable1
            // 
            this.myNewLable1.AutoSize = true;
            this.myNewLable1.Location = new System.Drawing.Point(38, 30);
            this.myNewLable1.Name = "myNewLable1";
            this.myNewLable1.Size = new System.Drawing.Size(78, 16);
            this.myNewLable1.TabIndex = 10;
            this.myNewLable1.Text = "First Name :";
            // 
            // EntrySemesterTxt
            // 
            this.EntrySemesterTxt.Enabled = false;
            this.EntrySemesterTxt.Location = new System.Drawing.Point(131, 287);
            this.EntrySemesterTxt.Multiline = true;
            this.EntrySemesterTxt.Name = "EntrySemesterTxt";
            this.EntrySemesterTxt.Size = new System.Drawing.Size(117, 31);
            this.EntrySemesterTxt.TabIndex = 8;
            // 
            // StudentIDtxt
            // 
            this.StudentIDtxt.Enabled = false;
            this.StudentIDtxt.Location = new System.Drawing.Point(131, 237);
            this.StudentIDtxt.Multiline = true;
            this.StudentIDtxt.Name = "StudentIDtxt";
            this.StudentIDtxt.Size = new System.Drawing.Size(117, 31);
            this.StudentIDtxt.TabIndex = 7;
            // 
            // StudentCheck
            // 
            this.StudentCheck.AutoSize = true;
            this.StudentCheck.Location = new System.Drawing.Point(41, 199);
            this.StudentCheck.Name = "StudentCheck";
            this.StudentCheck.Size = new System.Drawing.Size(107, 20);
            this.StudentCheck.TabIndex = 6;
            this.StudentCheck.Text = "R U Student?";
            this.StudentCheck.UseVisualStyleBackColor = true;
            // 
            // AddressTxt
            // 
            this.AddressTxt.Location = new System.Drawing.Point(378, 67);
            this.AddressTxt.Multiline = true;
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.Size = new System.Drawing.Size(140, 74);
            this.AddressTxt.TabIndex = 5;
            this.AddressTxt.TextChanged += new System.EventHandler(this.myNewTextbox5_TextChanged);
            // 
            // BirthDateTxt
            // 
            this.BirthDateTxt.Location = new System.Drawing.Point(378, 23);
            this.BirthDateTxt.Multiline = true;
            this.BirthDateTxt.Name = "BirthDateTxt";
            this.BirthDateTxt.Size = new System.Drawing.Size(140, 31);
            this.BirthDateTxt.TabIndex = 4;
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(131, 110);
            this.IDtxt.Multiline = true;
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(117, 31);
            this.IDtxt.TabIndex = 3;
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Location = new System.Drawing.Point(131, 67);
            this.LastNameTxt.Multiline = true;
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(117, 31);
            this.LastNameTxt.TabIndex = 2;
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(131, 23);
            this.FirstNameTxt.Multiline = true;
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(117, 31);
            this.FirstNameTxt.TabIndex = 1;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(313, 237);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(225, 129);
            this.SubmitBtn.TabIndex = 0;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // MyNewForm
            // 
            this.ClientSize = new System.Drawing.Size(559, 397);
            this.Controls.Add(this.MajorCmboBx);
            this.Controls.Add(this.myNewLable8);
            this.Controls.Add(this.myNewLable7);
            this.Controls.Add(this.myNewLable6);
            this.Controls.Add(this.myNewLable5);
            this.Controls.Add(this.myNewLable4);
            this.Controls.Add(this.myNewLable3);
            this.Controls.Add(this.myNewLable2);
            this.Controls.Add(this.myNewLable1);
            this.Controls.Add(this.EntrySemesterTxt);
            this.Controls.Add(this.StudentIDtxt);
            this.Controls.Add(this.StudentCheck);
            this.Controls.Add(this.AddressTxt);
            this.Controls.Add(this.BirthDateTxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.SubmitBtn);
            this.Name = "MyNewForm";
            this.Text = "Submition Form";
            this.Load += new System.EventHandler(this.MyNewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void myNewTextbox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void myNewLable8_Click(object sender, EventArgs e)
        {

        }

        private void MyNewForm_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            
            int EnterySemester = int.Parse(EntrySemesterTxt.Text);
            Student student = new Student();
            FirstNameTxt.Text = student.firstName;
            LastNameTxt.Text = student.lastName;
            IDtxt.Text = student.ID;
            AddressTxt.Text=student.address;
            BirthDateTxt.Text=student.birthDate;
            StudentIDtxt.Text = student.studentID;
            EnterySemester = student.entrySemester;
            MajorCmboBx.Items.Add(Student.major.Electronic);
            MajorCmboBx.Items.Add(Student.major.Computer);
            MajorCmboBx.Items.Add(Student.major.Accounting);
        }
    }
}
