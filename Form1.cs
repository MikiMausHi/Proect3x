using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proect3x
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelRecovery.Visible = false;
            pnRegist.Visible = false;
        }


        //кнопка регистрация
        private void Registration_Click(object sender, EventArgs e)
        {
            pnRegist.Visible = true;
            authorization.Visible = false;
        }



        public bool IsValidEmail(string email)
        {
            string pattern = @"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.
    (com|edu|info|gov|int|mail|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$";
            Regex check = new Regex(pattern, RegexOptions.IgnorePatternWhitespace);
            bool valid = false;
            if (string.IsNullOrEmpty(email))
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(email);
            }
            return valid;
        }


        private void bRegistr_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(tbEmail.Text))
            {
                if (tbLogin.Text != "")
                {
                    
                    if (tbPassword.Text == tbPasswordTwo.Text)
                    {
                        DBLayer.AddUsers(tbLogin.Text, tbPassword.Text, tbEmail.Text, tbName.Text, tbPhone.Text);
                        tbLogin.Clear();
                        tbPassword.Clear();
                        tbEmail.Clear();
                        tbName.Clear();
                        tbPhone.Clear();
                        tbPasswordTwo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают.!.");
                        tbPasswordTwo.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Введите логин.!.");
                }
            }
            else
            {
                MessageBox.Show("Некорректный Email.!.");
            }
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection())
            {
                conn.ConnectionString = DBLayer.GetConnectionString();
                conn.Open();
                string selectCommand = "SELECT * FROM users WHERE users.loginUser='" + tbLoginAut.Text + "' OR users.email='"+ tbLoginAut.Text + "' AND users.passwordUser='" + tbPasswordAut.Text + "'";
                MySqlCommand cmd = new MySqlCommand(selectCommand, conn);
                if (cmd.ExecuteScalar() == null)
                {
                    MessageBox.Show("Неверный логин/пароль!");
                }
                else
                {
                    MessageBox.Show("Добрый день!");
                    //функционал
                }
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
