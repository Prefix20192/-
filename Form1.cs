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
    public partial class Main : Form
    {

        private SqlConnection sqlConnection = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["data_base"].ConnectionString);
            sqlConnection.Open();
        }

        private void item_geography_service_Click(object sender, EventArgs e)
        {

        }

        private void button_office_Click(object sender, EventArgs e)
        {
            SingIn SingIn_form = new SingIn();
            SingIn_form.Show();
            /*
            Personal_account Personal_account_form = new Personal_account();
            Personal_account_form.Show();*/
        }

        private void item_about_the_activity_Click(object sender, EventArgs e)
        {
            about_the_activity about_the_activity_form = new about_the_activity();
            about_the_activity_form.Show();
        }

        private void item_vacancy_Click(object sender, EventArgs e)
        {
            vacancy_main vacancy_main_form = new vacancy_main();
            vacancy_main_form.Show();
        }

        private void item_regulatory_documents_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/information/docs/");
        }

        private void item_new_waste_management_system_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/information/newsystem/");
        }

        private void item_requisite_Click(object sender, EventArgs e)
        {
            requisites requisites_form = new requisites();
            requisites_form.Show();
        }

        private void item_disclosure_of_information_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/opendata/");
        }

        private void item_special_assessment_of_working_conditions_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/information/spetsotsenka-usloviy-truda/");
        }

        private void item_procurement_procedures_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR: ИНФОРМАЦИИ НЕТУ");
        }

        private void item_tariffs_and_regulations_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/tarify-i-normativy/");
        }

        private void item_model_contract_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/tipovoy-dogovor/");
        }

        private void item_contact_dogovor_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/comf_dogovor/");
        }

        private void item_sign_contract_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/zaklyuchit-dogovor/");
        }

        private void item_benefits_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/lgoty/");
        }

        private void item_grapf_cart_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/grafiki-na-karte/");
        }

        private void item_methods_purse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/oplata/");
        }

        private void item_container_pet_but_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/kontpetb/");
        }

        private void item_panaytka_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/pamyatka/");
        }

        private void item_conclusion_of_a_direct_contract_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/zaklyuchenie-pryamogo-dogovora/");
        }

        private void item_blank_fiz_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/blanki-fl.php");
        }

        private void item_priem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/appeals/internet-reception/index.php");
        }

        private void item_info_comp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/informatsiya-po-organizatsii-vyvoz/");
        }

        private void item_about_program_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу сделал бла-бла\nВерсия: 1337\n");
        }

        private void button_contract_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/zaklyuchit-dogovor/");
        }

        private void button_question_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/potrebitelyam/zaklyuchit-dogovor/");
        }

        private void item_all_news_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/news/index.php");
        }

        private void item_official_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/news/ofitsialno/");
        }

        private void item_question_answer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/appeals/vopros-otvet/");
        }

        private void item_photograf_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/media/photo-gallery/");
        }

        private void item_video_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/media/video/");
        }

        private void item_smi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/news/smionas/");
        }

        private void item_about_predpri_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/info/");
        }

        private void item_achiv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR: В разработке");
        }

        private void item_trafic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/util_tarifi/");
        }

        private void item_shop_vto_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/secondhand/");
        }

        private void item_ecologt_kas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/eco_cunsult/");
        }

        private void item_normv_document_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/docs/");
        }

        private void item_app_contract_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/zayavki/");
        }

        private void item_lic_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/lic/");
        }

        private void item_exists_docum_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/razreshitelnaya-dokumentatsiya/");
        }

        private void item_contact_metz_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/arenda/");
        }

        private void item_bureau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ERROR: В разработке");
        }

        private void item_vacancy_metz_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ecocity26.ru/eco-city/jobs/");
        }

    }
}
