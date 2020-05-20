using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu(){
            InitializeComponent();
            if (FormAuthrorization.users.type == "agent") buttonOpenAgents.Enabled = false;
            labelHello.Text = "Приветствую тебя, " + FormAuthrorization.users.login;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Клиент и открываем ее
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Риелтор и открываем ее
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenDeals_Click(object sender, EventArgs e)
        {
            Form formDeal = new FormDeal();
            formDeal.Show();
        }

        private void buttonOpenRealEstates_Click(object sender, EventArgs e)
        {
            //Задаем новую форму из класса Объекты недвижимостии и открываем ее
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formSupply = new FormSupply();
            formSupply.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form formDemand = new FormDemand();
            formDemand.Show();
        }
    }
}
