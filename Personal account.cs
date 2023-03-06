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
    public partial class Personal_account : Form
    {
        private SqlConnection sqlConnection = null;

        public Personal_account()
        {
            InitializeComponent();
        }

        public void Personal_account_Load(object sender, EventArgs e)
        {
            emailuser.Text = DataBank.email_user_text_personal_account;
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["data_base"].ConnectionString);
            sqlConnection.Open();


            string sql_select = $"SELECT COUNT(*) as count FROM Contracts WHERE user_email = '{DataBank.email_user_text_personal_account}' AND face_contracts = 'fiz'";
            SqlCommand command = new SqlCommand(sql_select, sqlConnection);

            int count = (int)command.ExecuteScalar();
            if (count == 0)
            {
                contract_info.Text = "\tК вашей учетной записи не прикреплены \nдоговоры";
            }
            else
            {
                contract_info.Text = $"Количествго договоров: {count}";
            }            
            
            string sql_select_urid = $"SELECT COUNT(*) as count FROM Contracts WHERE user_email = '{DataBank.email_user_text_personal_account}' AND face_contracts = 'urid'";
            SqlCommand command_urid = new SqlCommand(sql_select_urid, sqlConnection);

            int count_urid = (int)command_urid.ExecuteScalar();
            if (count == 0)
            {
                urid_lab.Text = "\tК вашей учетной записи не прикреплены \nдоговоры";
            }
            else
            {
                urid_lab.Text = $"Количествго договоров: {count_urid}";
            }
        }

        private void exit_account_Click(object sender, EventArgs e)
        {
            Main Main_form = new Main();
            this.Hide();
            Main_form.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword ResetPassword_form = new ResetPassword();
            ResetPassword_form.Show();
        }

        private void textBox_number_check_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox_number_check.Text == "Введите номер лиц. счета")
            {
                textBox_number_check.Text = "";
                textBox_number_check.ForeColor = Color.Black;
            }
        }

        private void textBox_surname_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_surname.Text == "Введите фамилию")
            {
                textBox_surname.Text = "";
                textBox_surname.ForeColor = Color.Black;
            }
        }

        private void send_contact_fiz_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox_surname.Text) || String.IsNullOrEmpty(textBox_surname.Text))
            {
                MessageBox.Show("ERROR: Номер лиц. счета или фамилия пуста\nЗаполните пустые строки!");
            }
            else
            {
                if(textBox_number_check.Text.Length < 9)
                {
                    string face = "fiz";

                    SqlCommand command = new SqlCommand(
                        $"INSERT INTO [Contracts] (face_contracts, personal_account_number, surname, user_email) VALUES (@face_contracts, @personal_account_number, @surname, @user_email)",
                    sqlConnection);

                    command.Parameters.AddWithValue("face_contracts", face);
                    command.Parameters.AddWithValue("personal_account_number", textBox_number_check.Text);
                    command.Parameters.AddWithValue("surname", textBox_surname.Text);
                    command.Parameters.AddWithValue("user_email", DataBank.email_user_text_personal_account);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Успешно!\nВы создали договор");
                    Personal_account_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка. Лицевой счет состоит из 9 знаков.");
                }
            }
        }

        private void number_contracts__urid_face_MouseClick(object sender, MouseEventArgs e)
        {
            if (number_contracts__urid_face.Text == "Номер договора")
            {
                number_contracts__urid_face.Text = "";
                number_contracts__urid_face.ForeColor = Color.Black;
            }
        }

        private void inn_urid_face_MouseClick(object sender, MouseEventArgs e)
        {
            if (inn_urid_face.Text == "ИНН")
            {
                inn_urid_face.Text = "";
                inn_urid_face.ForeColor = Color.Black;
            }
        }

        private void kpp_urid_face_MouseClick(object sender, MouseEventArgs e)
        {
            if (kpp_urid_face.Text == "КПП (если есть)")
            {
                kpp_urid_face.Text = "";
                kpp_urid_face.ForeColor = Color.Black;
            }
        }

        private void send_urid_face_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(inn_urid_face.Text) || String.IsNullOrEmpty(number_contracts__urid_face.Text))
            {
                MessageBox.Show("ERROR: Номер договора и ИНН не заполнены!\nЗаполните пустые строки!");
            }
            else
            {
                string face = "urid";

                SqlCommand command = new SqlCommand(
                    $"INSERT INTO [Contracts] (face_contracts, number_contracts, inn, kpp, user_email) VALUES (@face_contracts, @number_contracts, @inn, @kpp, @user_email)",
                sqlConnection);

                command.Parameters.AddWithValue("face_contracts", face);
                command.Parameters.AddWithValue("number_contracts", number_contracts__urid_face.Text);
                command.Parameters.AddWithValue("inn", inn_urid_face.Text);
                if (String.IsNullOrEmpty(kpp_urid_face.Text))
                {
                    command.Parameters.AddWithValue("kpp", "");
                }
                else
                {
                    command.Parameters.AddWithValue("kpp", textBox_surname.Text);
                }
                command.Parameters.AddWithValue("user_email", DataBank.email_user_text_personal_account);

                command.ExecuteNonQuery();

                MessageBox.Show("Успешно!\nВы создали договор");
                Personal_account_Load(sender, e);
            }
        }
    }
}
