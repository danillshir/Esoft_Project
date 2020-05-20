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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //проверяем, что все поля (раскрывающихся списков и текстового поля) были заполнены
            if (comboBoxAgents.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate != null && textBoxPrice.Text != "")
            {
                //создаем новый экземпляр класса Предложение
                SupplySet supply = new SupplySet();
                //из выбранной строки в comboBoxAgents отделяем Id риелтора (он отделен точкой) и делаем ссылку supply.IdAgent
                supply.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                //точно такжем отделяем и заносим id клиента
                supply.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                //отделяем  и заносим id объекта недвижимости
                supply.idRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                //цена объекта недвижимости чаще всего превосходит миллион, поэтому используем Int64
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //добавляем в таблицу SupplySet новый объект недвижимости supply
                Program.wftDb.SupplySet.Add(supply);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowAgents()
        {
            //очищаем comboBox
            comboBoxAgents.Items.Clear();
            foreach(AgentSet agentSet in Program.wftDb.AgentSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-а
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { agentSet.id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            //очищаем comboBox
            comboBoxClients.Items.Clear();
            foreach(ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-а
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = { clientsSet.id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()
        {
            //очищаем ComboBox
            comboBoxRealEstate.Items.Clear();
            foreach(RealEstateSet realEstateSet in Program.wftDb.RealEstateSet)
            {
                //добавляем информацию, которую хотим видеть в строке comboBox-а
                //можно настроить по своему усмотрению, добавить/удалить некоторые элементы и сокращения
                //главное, не убирать Id, так как он нужен для дальнейшей работы
                string[] item = {realEstateSet.id.ToString()+".",realEstateSet.Address_City+",",realEstateSet.Address_Street+",",
                "д. "+realEstateSet.Address_House+",","кв. "+realEstateSet.Address_Number};
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSupplySet()
        {
            //Предварительно очищаем все listView
            listViewSupplySet.Items.Clear();
            //Проходим по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                //создадим новый элемент в listView с помощью массива строк
                ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        //id риелтора
                        supply.idAgent.ToString(),
                        //ФИО риелтора(фамилия+имя+отчество)
                        supply.AgentSet.LastName+" "+supply.AgentSet.FirstName+" "+supply.AgentSet.MiddleName,
                        //id клиента
                        supply.idClient.ToString(),
                        //ФИО клиента(фамилия+имя+отчество)
                        supply.ClientsSet.LastName+" "+supply.ClientsSet.FirstName+" "+supply.ClientsSet.MiddleName,
                        //id объекта недвижимости
                        supply.idRealEstate.ToString(),
                        //адрес объекта недвижимости
                        "г. "+supply.RealEstateSet.Address_City+", ул. "+supply.RealEstateSet.Address_Street+", д. "+
                        supply.RealEstateSet.Address_House+", кв. "+supply.RealEstateSet.Address_Number,
                        //цена
                        supply.Price.ToString()
                    });
                //указываем по какому тегу выбраны элементы
                item.Tag = supply;
                //добавляем элементы в listViewRealEstateSet_Apartment для отображения
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewSupplySet.SelectedItems.Count==1)
            {
                //ищем элемент из таблицы по тегу
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //указываем, что может быть изменено
                supply.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                supply.idClient=Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.idRealEstate=Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если в listView выбран элемент
            if (listViewSupplySet.SelectedItems.Count==1)
            {
                //ищем элемент из таблицы по тегу
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                //указываем, что может быть изменено
                //находим в comboBoxAgents необходимую строку по id риелтора из supply.idAgent и задаем ее отображение comboBox-у
                comboBoxAgents.SelectedIndex = comboBoxAgents.FindString(supply.idAgent.ToString());
                //точно также поступаем с comboBoxClients и comboBoxRealEstate
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.idClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.idRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                //если не выбран ни один элемент, то задаем пустые элементы
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если в listView выбран элемент
                if (listViewSupplySet.SelectedItems.Count==1)
                {
                    //ищем элемент из таблицы по тегу
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    //удаляем из модели БД
                    Program.wftDb.SupplySet.Remove(supply);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновленный список
                    ShowSupplySet();
                }
                //очищаем все поля
                comboBoxAgents.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            //если возникает какая-то ошибка
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSupply_Load(object sender, EventArgs e)
        {

        }
    }
}
