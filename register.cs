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
    public partial class reg_from : Form
    {
        private SqlConnection sqlConnection = null;

        public reg_from()
        {
            InitializeComponent();
        }

        private void reg_from_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["data_base"].ConnectionString);
            sqlConnection.Open();

            
            /*
            if(sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("База данных подключена");
            }
            else
            {
                MessageBox.Show("ERROR: Ошибка подключение к базе данных");
            }
            */
        }

        private void email_MouseClick(object sender, MouseEventArgs e)
        {
            if (email.Text == "Введите email")
            {
                email.Text = "";
            }
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.PasswordChar = '*';
            }
        }

        private void password_confiurm_MouseClick(object sender, MouseEventArgs e)
        {
            if (password_confiurm.Text == "Повторите пароль")
            {
                password_confiurm.Text = "";
                password_confiurm.PasswordChar = '*';
            }
        }

        private void register_send_Click(object sender, EventArgs e)
        {
            
            if(password.Text == password_confiurm.Text)
            {
                
                SqlCommand command = new SqlCommand($"INSERT INTO [users] (email, password) VALUES (@email, @password)", sqlConnection);

                command.Parameters.AddWithValue("email", email.Text);
                command.Parameters.AddWithValue("password", password.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Вы успешно зарегистрировались!");
                Personal_account Personal_account_form = new Personal_account();
                Personal_account_form.Show();

            }
            else
            {
                MessageBox.Show("ERROR: Пароли не совпадают!");
                password_confiurm.PasswordChar = ' ';
                password.PasswordChar = ' ';
                password.Text = "Введите пароль";
                password_confiurm.Text = "Повторите пароль";
            }
        }

        private void sing_in_Click(object sender, EventArgs e)
        {
            Personal_account Personal_account_form = new Personal_account();
            Personal_account_form.Show();
        }
    }
}
