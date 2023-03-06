using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ООО__ЭКО_Сити_
{
    public partial class SingIn : Form
    {

        private SqlConnection sqlConnection = null;

        public SingIn()
        {
            InitializeComponent();
        }

        private void SingIn_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["data_base"].ConnectionString);
            sqlConnection.Open();
        }


        public void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Введите email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Введите пароль")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        public void button_singin_Click(object sender, EventArgs e)
        {
            string sql_select = $"SELECT email FROM users WHERE email = '{textBox1.Text}' AND password = '{textBox2.Text}'";
            SqlCommand command = new SqlCommand(sql_select, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show($"Привет {textBox1.Text}");
                DataBank.email_user_text_personal_account = textBox1.Text;
                Personal_account Personal_account_form = new Personal_account();
                this.Hide();
                Personal_account_form.Show(); 
            }
            else
            {
                MessageBox.Show("ERROR: Я вас не нашел в базе данных :(\nПроверьте правильность ввода данных!");
            }
        }

        private void register_form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg_from register_forms = new reg_from();
            this.Hide();
            register_forms.Show();
        }

        private void forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Обратитесь в тех поддержку сайта");
            System.Diagnostics.Process.Start("https://ecocity26.ru/");

        }
    }
}
