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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClientsSet clientsSet = new ClientsSet();
            clientsSet.FirstName = textBoxFirstName.Text;
            clientsSet.MiddleName = textBoxMiddleName.Text;
            clientsSet.LastName = textBoxLastName.Text;
            clientsSet.Phone = textBoxPhone.Text;
            clientsSet.Email = textBoxEmail.Text;
            Program.wftDb.ClientsSet.Add(clientsSet);
            Program.wftDb.SaveChanges();
            ShowClient();

        }
        void ShowClient()
        {
            listViewClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.id.ToString(), clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClient.Items.Add(item);
            }
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if (listViewClient.SelectedItems.Count==1)
            {
                //ищем элемент из таблицы по тегу
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что может быть изменено
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;

            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаем пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {//условие, если в listView выбран 1 элемент
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что может быть изменено
                clientsSet.FirstName = textBoxFirstName.Text;
                clientsSet.MiddleName = textBoxMiddleName.Text;
                clientsSet.LastName = textBoxLastName.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                //Сохраняем изменения в модели wftDb(экземпляр которой был создан ранее)
                Program.wftDb.SaveChanges();
                //отображение в listView
                ShowClient();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewClient.SelectedItems.Count==1)
                {
                    //ищем этот элемент, сверяем его
                    ClientsSet clientsSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    //удаляем из модели и базы данных
                    Program.wftDb.ClientsSet.Remove(clientsSet);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновлённый список
                    ShowClient();

                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";

            }
            //если возникает какая-то ошибка, к примеру, запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
