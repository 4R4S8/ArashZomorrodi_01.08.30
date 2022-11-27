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
    public partial class MainForm : Form
    {
        //MyNewTextbox DateTxtbx = new MyNewTextbox();
        int myMonth, myDay;
        Boolean IsDateValid(string myDate)
        {
            
            if (myNewTextbox1.Text.Length != 10)
            {
                MessageBox.Show("لطفا در وارد کردن تاریخ دقت کنید \n\n:فرمت صحیح \nyyyy/mm/dd", "خطا در وارد کردن تاریخ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DialogResult res = MessageBox.Show("تاریخ با موفقیت ثبت شد\n\nآیا مقادیر وارد شده پاک شوند؟", "تاریخ با موفقیت ثبت شد", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (res)
            {
                case DialogResult.Yes:
                    {
                        myNewTextbox1.ResetText();
                        TEST infoForm = new TEST();
                        infoForm.ShowDialog();
                        
                    }
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
            return true;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void myNewButton1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void myNewTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (Char.IsPunctuation(e.KeyChar))))
            {
                MessageBox.Show("تاریخ وارد شده فقط باید از عدد و ممیز تشکیل شده باشد\n\nمثال:1398/08/28", "خطا در وارد کردن تاریخ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

            //else if (myNewButton1.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("لطفا در وارد کردن تاریخ دقت کنید \n\n:فرمت صحیح \n----/--/--", "خطا در وارد کردن تاریخ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void myNewButton1_Click(object sender, EventArgs e)
        {
            string text = myNewTextbox1.Text;
            IsDateValid(text);
        }
    }
}
