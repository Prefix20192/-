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
    public partial class ResetPassword : Form
    {

        private SqlConnection sqlConnection = null;

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            emailuser.Text = DataBank.email_user_text_personal_account;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["data_base"].ConnectionString);
            sqlConnection.Open();
        }

        private void now_password_MouseClick(object sender, MouseEventArgs e)
        {
            if(now_password.Text == "Текущий пароль")
            {
                now_password.Text = "";
                now_password.PasswordChar = '*';
                now_password.ForeColor = Color.Black;
            }
        }

        private void new_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (new_password.Text == "Новый пароль")
            {
                new_password.Text = "";
                new_password.PasswordChar = '*';
                new_password.ForeColor = Color.Black;
            }
        }

        private void new_password_confiurm_MouseClick(object sender, MouseEventArgs e)
        {
            if (new_password_confiurm.Text == "Подтверждение нового пароля")
            {
                new_password_confiurm.Text = "";
                new_password_confiurm.PasswordChar = '*';
                new_password_confiurm.ForeColor = Color.Black;
            }
        }

        private void reset_password_Click(object sender, EventArgs e)
        {
            string sql_update = $"UPDATE [users] SET pssword = '{new_password.Text}' WHERE password = '{now_password.Text}'";
            if(new_password.Text == new_password_confiurm.Text)
            {
                SqlCommand command = new SqlCommand(sql_update, sqlConnection);

                command.ExecuteNonQuery();

                MessageBox.Show("Вы успешно сменили пароль");
                this.Hide();
                SingIn sing_in_form = new SingIn();
                sing_in_form.Show();

            }
            else
            {
                MessageBox.Show("ERROR: Пароли не совпадают!");
                new_password.PasswordChar = ' ';
                new_password_confiurm.PasswordChar = ' ';
                new_password.Text = "Введите пароль";
                new_password_confiurm.Text = "Повторите пароль";
            }
        }
    }
}
