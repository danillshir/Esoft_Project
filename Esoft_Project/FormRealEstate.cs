﻿using System;
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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();


        }
        void ShowRealEstateSet()
        {
            //Предварительно очищаем все listView
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();
            //Проходим по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (RealEstateSet realEstate in Program.wftDb.RealEstateSet)
            {
                //отображение квартир в listViewRealEstateSet_Apartment
                if (realEstate.Type == 0)
                {
                    //создадим новый элемент в listViewRealEstateSet_Apartment с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                        {
                            //указываем необходимые поля
                            realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                            realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(),
                            realEstate.Coordinate_longitude.ToString(), realEstate.TotalArea.ToString(),
                            realEstate.Rooms.ToString(), realEstate.Floor.ToString()
                        });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listVIewRealEstateSet_Apartment для отображения
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                //отображение домов в listViewRealEstateSet_House
                else if (realEstate.Type == 1)
                {
                    //создадим новый элемент в listViewRealEstateSet_House с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(),
                        realEstate.Coordinate_longitude.ToString(), realEstate.TotalArea.ToString(),
                        realEstate.TotalFloors.ToString()
                    }
                        );
                    //указываем по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_House для отображения
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    //создадим новый элемент в listViewRealEstateSet_Land с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street,realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(),
                        realEstate.Coordinate_longitude.ToString(), realEstate.TotalArea.ToString()
                    }
                        );
                    //указываем по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_Land для отображения
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            //Выравниваем столбцы во всех ListView
            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRealEstate_Load(object sender, EventArgs e)
        {

        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewRealEstateSet_Land.SelectedItems.Count==1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();

            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();

            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";

                textBoxFloor.Text = "";
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Изменения формы, если выбрана строчка "Квартира"
            if (comboBoxType.SelectedIndex==0)
            {
                //Делаем видимыми нужные элементы
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                //скрываем ненужные элементы
                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                //Очищаем все видимые элементы
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
            //Изменения формы, если выбрана строчка "Дом"(1)
            else if (comboBoxType.SelectedIndex==1)
            {
                //Делаем видимыми нужные элементы
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;
                //Скрываем ненужные элементы
                listViewRealEstateSet_Land.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                //Очищаем все видимые элементы
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";
            }
            //Изменения формы, если выбрана строчка "Земля"(2)
            else if (comboBoxType.SelectedIndex==2)
            {
                //Делаем видимыми нужные элементы
                listViewRealEstateSet_Land.Visible = true;
                //Скрываем ненужные элементы
                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;
                //Очищаемвсе видимые элементы
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void labelType_Click(object sender, EventArgs e)
        {

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxRooms.Text = "";
                    textBoxFloor.Text = "";

                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        Program.wftDb.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxFloor.Text = "";
                }
                else
                {
                    //если в ListView выбран элемент
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        //ищем элемент по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели БД
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновленный список
                        ShowRealEstateSet();
                    }
                    //очищаем текстовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";

                }

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Выбран тип "Квартира", работа с listViewRealEstateSet_Apartment
            if (comboBoxType.SelectedIndex==0)
            {
                //если в listView выбран элемент
                if (listViewRealEstateSet_Apartment.SelectedItems.Count==1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    //указываем, что  может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();

                }
            }
            else if (comboBoxType.SelectedIndex==1)
            {
                if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                    //указываем, что  может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();

                }
            }
            else
            {
                if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                    //указываем, что  может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    Program.wftDb.SaveChanges();
                    ShowRealEstateSet();

                }
            }
        }

        private void labelTotalFloors_Click(object sender, EventArgs e)
        {

        }

        private void labelCoordinate_latitude_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCoordinate_longitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFloor_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTotalArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTotalArea_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTotalFloors_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр класса Объект недвижимости
            RealEstateSet realEstate = new RealEstateSet();
            //Делаем ссылку на объект, который хранится в textBox-ах (сначала общие поля)
            realEstate.Address_City = textBoxAddress_City.Text;
            realEstate.Address_House = textBoxAddress_House.Text;
            realEstate.Address_Street = textBoxAddress_Street.Text;
            realEstate.Address_Number = textBoxAddress_Number.Text;
            realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
            realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
            realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
            //Дополнительные поля для типа "Квартира"
            if (comboBoxType.SelectedIndex == 0)
            {
                realEstate.Type = 0;
                realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
            }
            //Дополнительные поля для типа "Дом"
            else if (comboBoxType.SelectedIndex == 1)
            {
                realEstate.Type = 1;
                realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
            }
            //Дополнительные поля для типа "Земля"
            else
            {
                realEstate.Type = 2;
            }
            //Добавляем в таблицу RealEstateSet новый объект недвижимости realEstate
            Program.wftDb.RealEstateSet.Add(realEstate);
            //Сохраняем изменения в модели wftDb
            Program.wftDb.SaveChanges();
            ShowRealEstateSet();
        }


        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран один элемент
            if (listViewRealEstateSet_Apartment.SelectedItems.Count==1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();

            }
            else
            {
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
        }

        private void textBoxAddress_City_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRooms_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
