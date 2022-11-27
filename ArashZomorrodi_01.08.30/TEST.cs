using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArashZomorrodi_01._08._30
{
    public partial class TEST : Form
    {
        //Empty Response Checker(Human)
        Boolean EmptyCheckerStudent(string fname, string lname, string id, string address,string  birthdate, string sid,string entrysemester,string major)
        {
            if (fname == "")  MessageBox.Show("مقدار نام نباید خالی باشد","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            if (lname == "")  MessageBox.Show("مقدار نام خانوادگی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            if (id == "")  MessageBox.Show("مقدار کد ملی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (address == "")  MessageBox.Show("مقدار نشانی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (birthdate == "")  MessageBox.Show("مقدار تاریخ تولد نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (sid == "")  MessageBox.Show("مقدار شماره دانشجویی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (entrysemester == "") MessageBox.Show("مقدار ترم ورود نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (major == "") MessageBox.Show("مقدار رشته نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (fname == "" || lname == "" || id == "" || address == "" || birthdate == "" || sid == "" || entrysemester == "" || major == "")
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        //Empty Response Checker(Student)
        Boolean EmptyCheckerHuman(string fname, string lname, string id, string address, string birthdate)
        {
            if (fname == "") MessageBox.Show("مقدار نام نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (lname == "") MessageBox.Show("مقدار نام خانوادگی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (id == "") MessageBox.Show("مقدار کد ملی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (address == "") MessageBox.Show("مقدار نشانی نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (birthdate == "") MessageBox.Show("مقدار تاریخ تولد نباید خالی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            if (fname == "" || lname == "" || id == "" || address == "" || birthdate == "")
            {
                return false;
            }
            else
            {
                return true;

            }
        }
        //Student ID Validation
        Boolean IsStudentIDValid(string mySID)
        {
            if (IDtxt.Text.Length != 14)
            {
                MessageBox.Show(".طول شماره دانشجویی باید 14 رقم باشد", "خطا در مقدار شماره دانشجویی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Entry Semester Validation 
        Boolean IsEntrySemesterValid(string myES)
        {
            if (EntrySemesterTxt.Text.Length!=3)
            {
                MessageBox.Show(".طول ترم ورود باید 3 رقم باشد", "خطا در مقدار ترم ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        //ID Validation
        Boolean IsIdValid(string myID)
        {
            if (IDtxt.Text.Length != 10)
            {
                MessageBox.Show(".طول کد ملی باید 10 رقم باشد","خطا در مقدار کد ملی",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        //Date Validation
        int myMonth, myDay;
        Boolean IsDateValid(string myDate)
        {

            if (BirthDateTxt.Text.Length != 10)
            {
                MessageBox.Show("لطفا در وارد کردن تاریخ تولد دقت کنید \n\n:فرمت صحیح \nyyyy/mm/dd", "خطا در مقدار تاریخ تولد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            myDay = Convert.ToInt16(myDate.Substring(8, 2));
            myMonth = Convert.ToInt16(myDate.Substring(5, 2));

            if (myDate.Trim().Substring(4, 1) != "/")
            {
                MessageBox.Show("خطا در محل قرارگیری ممیز ها\n فرمت صحیح تاریخ : 1398/08/28", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             if (myDate.Trim().Substring(7, 1) != "/")
            {
                MessageBox.Show("خطا در محل قرارگیری ممیز ها\n فرمت صحیح تاریخ : 1398/08/28", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             if (myDay < 1 || myDay > 31)
            {
                MessageBox.Show("خطا در مقدار روز\n مقدار ماه باید بین 1 تا 31 یاشد", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

             if (myMonth < 1 || myMonth > 12)
            {
                MessageBox.Show("خطا در مقدار ماه\n مقدار ماه باید بین 1 تا 12 یاشد", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
             if (myMonth >= 1 && myMonth <= 6)
            {
                if (myDay < 1 || myDay > 31)
                {
                    MessageBox.Show("خطا در مقدار روز\n مقدار روز در شش ماه اول سال باید بین 1 تا 31 باشد", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
             if (myMonth >= 7 && myMonth <= 11)
            {
                if (myDay < 1 || myDay > 30)
                {
                    MessageBox.Show("خطا در مقدار روز\n مقدار روز در شش ماه آخر سال باید بین 1 تا 30 باشد", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
             if (myMonth == 12)
            {
                if (myDay < 1 || myDay > 29)
                {
                    MessageBox.Show("خطا در مقدار روز\n مقدار روز در ماه آخر سال باید بین 1 تا 29 باشد", "تاریخ وارد شده صحیح نیست", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //DialogResult res = MessageBox.Show("تاریخ با موفقیت ثبت شد\n\nآیا مقادیر وارد شده پاک شوند؟", "تاریخ با موفقیت ثبت شد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //switch (res)
            //{
            //    case DialogResult.Yes:
            //        {
            //            BirthDateTxt.ResetText();
            //            MyNewForm MyNewForm = new MyNewForm();
            //            MyNewForm.ShowDialog();

            //        }
            //        break;
            //    case DialogResult.No:
            //        break;
            //    default:
            //        break;
            //}


            return true;
            

        }
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            MajorCmboBx.Enabled = false;
            EntrySemesterTxt.Enabled = false;
            StudentIDtxt.Enabled = false;
        }

        private void StudentCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (StudentCheck.Checked==true)
            {
                MajorCmboBx.Enabled = true;
                EntrySemesterTxt.Enabled = true;
                StudentIDtxt.Enabled = true;
            }
            else
            {
                MajorCmboBx.Enabled = false;
                EntrySemesterTxt.Enabled = false;
                StudentIDtxt.Enabled = false;
            }
        }

        private void BirthDateTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (Char.IsPunctuation(e.KeyChar))))
            {
                MessageBox.Show("تاریخ وارد شده فقط باید از عدد و ممیز تشکیل شده باشد\n\nمثال:1398/08/28", "خطا در وارد کردن تاریخ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (Char.IsPunctuation(e.KeyChar))))
            {
                MessageBox.Show("فقط مقادیر عددی مجاز است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void StudentIDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (Char.IsPunctuation(e.KeyChar))))
            {
                MessageBox.Show("فقط مقادیر عددی مجاز است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void EntrySemesterTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (Char.IsPunctuation(e.KeyChar))))
            {
                MessageBox.Show("فقط مقادیر عددی مجاز است ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void FirstNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string BTtxt = BirthDateTxt.Text;
            string idtxt = IDtxt.Text;
            string entsemtxt = EntrySemesterTxt.Text;
            string studentid = StudentIDtxt.Text;
            if (StudentCheck.Checked==true)
            {
                EmptyCheckerStudent(FirstNameTxt.Text, LastNameTxt.Text, IDtxt.Text, AddressTxt.Text, BirthDateTxt.Text, StudentIDtxt.Text, EntrySemesterTxt.Text, MajorCmboBx.Text);
                IsDateValid(BTtxt);
                IsIdValid(idtxt);
                IsEntrySemesterValid(entsemtxt);
                IsStudentIDValid(studentid);
                MessageBox.Show("ID = " + IDtxt.Text + "" +
                           "\nFirst Name = " + FirstNameTxt.Text + "" +
                           "\nLast Name = " + LastNameTxt.Text + "" +
                           "\nBirth Date = " + BirthDateTxt.Text + "" +
                           "\nAddress = \n" + AddressTxt.Text + "" +
                           "\n" +
                           "\nStudent ID = " + StudentIDtxt.Text + "" +
                           "\nMajor = " + MajorCmboBx.Text + "" +
                           "\nEntry Semester = " + EntrySemesterTxt.Text + "",
                           "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (StudentCheck.Checked != true)
            {
                EmptyCheckerHuman(FirstNameTxt.Text, LastNameTxt.Text, IDtxt.Text, AddressTxt.Text, BirthDateTxt.Text);
                IsDateValid(BTtxt);
                IsIdValid(idtxt);
                MessageBox.Show("ID = " + IDtxt.Text + "" +
                            "\nFirst Name = " + FirstNameTxt.Text + "" +
                            "\nLast Name = " + LastNameTxt.Text + "" +
                            "\nBirth Date = " + BirthDateTxt.Text + "" +
                            "\nAddress = \n" + AddressTxt.Text + "",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
            
        }
    }
}
