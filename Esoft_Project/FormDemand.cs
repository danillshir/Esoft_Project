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
    public partial class FormDemand : Form
    {
        public FormDemand()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowDemandSet();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHouse.SelectedItems.Count==1)
            {
                DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirstName + " " + demandSet.ClientsSet.ToString();
                comboBoxAgents.Text = demandSet.AgentSet.LastName + " " + demandSet.AgentSet.FirstName + " " + demandSet.AgentSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MinArea.ToString();
                textBoxMinFloors.Text = demandSet.MinFloors.ToString();
                textBoxMaxFloors.Text = demandSet.MaxFloors.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void listViewApartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewApartments.SelectedItems.Count==1)
            {
                DemandSet demandSet = listViewApartments.SelectedItems[0].Tag as DemandSet;
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirstName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentSet.LastName + " " + demandSet.AgentSet.FirstName + " " + demandSet.AgentSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinRooms.Text = demandSet.MinRooms.ToString();
                textBoxMaxRooms.Text = demandSet.MaxRooms.ToString();
                textBoxMinFloor.Text = demandSet.MinFloor.ToString();
                textBoxMaxFloor.Text = demandSet.MaxFloor.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();
            }
            else
            {
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DemandSet demandSet = new DemandSet();
            demandSet.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
            demandSet.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
            demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
            demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
            demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
            demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);


            if (comboBoxType.SelectedIndex==0)
            {
                demandSet.Type = 0;
                demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
            }
            else if (comboBoxType.SelectedIndex==1)
            {
                demandSet.Type = 1;
                demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
            }
            else
            {
                demandSet.Type = 2;
            }
            Program.wftDb.DemandSet.Add(demandSet);
            Program.wftDb.SaveChanges();
            ShowDemandSet();
        }
        void ShowAgents()
        {
            comboBoxAgents.Items.Clear();
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                string[] item = { agentSet.id.ToString() + ".", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgents.Items.Add(string.Join(" ", item));
            }

        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join("", item));
            }
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex==0)
            {
                //Делаем видимыми нужные элементы
                listViewApartments.Visible = true;
                comboBoxClients.Visible = true;
                labelClient.Visible = true;
                comboBoxAgents.Visible = true;
                labelAgent.Visible = true;
                labelMinPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                labelMinRooms.Visible = true;
                labelMaxRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                textBoxMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinFloor.Visible = true;
                labelMaxFloor.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMaxArea.Visible = true;
                labelMinArea.Visible = true;

                listViewHouse.Visible = false;
                listViewLand.Visible = false;
                labelMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
            else if (comboBoxType.SelectedIndex==1)
            {
                listViewHouse.Visible = true;
                comboBoxAgents.Visible = true;
                labelAgent.Visible = true;
                comboBoxClients.Visible = true;
                labelClient.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;
                labelMinFloors.Visible = true;
                labelMaxFloors.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMinArea.Visible = true;
                labelMaxArea.Visible = true;

                listViewApartments.Visible = false;
                listViewLand.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
            else if (comboBoxType.SelectedIndex==2)
            {
                listViewLand.Visible = true;
                comboBoxAgents.Visible = true;
                comboBoxClients.Visible = true;
                labelMinPrice.Visible = true;
                labelMaxPrice.Visible = true;
                labelAgent.Visible = true;
                labelMinArea.Visible = true;
                labelMaxArea.Visible = true;
                textBoxMinPrice.Visible = true;
                textBoxMaxPrice.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;

                listViewApartments.Visible = false;
                listViewHouse.Visible = false;
                labelMaxFloor.Visible = false;
                labelMinFloor.Visible = false;
                labelMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMinRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;
                labelMaxFloors.Visible = false;
                labelMinFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMaxPrice.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex==0)
            {
                if (listViewApartments.SelectedItems.Count==1)
                {
                    DemandSet demandSet = listViewApartments.SelectedItems[0].Tag as DemandSet;
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demandSet.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demandSet.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemandSet();
                    
                }
            }
            else if (comboBoxType.SelectedIndex==1)
            {
                if(listViewHouse.SelectedItems.Count==1)
                {
                    DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demandSet.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    demandSet.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else
            {
                if(listViewLand.SelectedItems.Count==1)
                {
                    DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                    demandSet.MinPrice = Convert.ToInt64(textBoxMinPrice.Text);
                    demandSet.MaxPrice = Convert.ToInt64(textBoxMaxPrice.Text);
                    demandSet.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    demandSet.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    demandSet.idAgent = Convert.ToInt32(comboBoxAgents.SelectedItem.ToString().Split('.')[0]);
                    demandSet.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    Program.wftDb.SaveChanges();
                    ShowDemandSet();
                }

            }
            
                
            
        }
        void ShowDemandSet()
        {
            listViewApartments.Items.Clear();
            listViewHouse.Items.Clear();
            listViewLand.Items.Clear();
            foreach (DemandSet demandSet in Program.wftDb.DemandSet)
            {
                if (demandSet.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,demandSet.AgentSet.LastName+" "+
                            demandSet.AgentSet.FirstName+" "+demandSet.AgentSet.MiddleName,demandSet.MinArea.ToString(),
                            demandSet.MaxArea.ToString(), demandSet.MinRooms.ToString(),demandSet.MaxRooms.ToString(),
                            demandSet.MinFloor.ToString(),demandSet.MaxFloor.ToString(),demandSet.MinPrice.ToString(),demandSet.MaxPrice.ToString()
                    });
                    item.Tag = demandSet;
                    listViewApartments.Items.Add(item);
                }
                else if (demandSet.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,demandSet.AgentSet.LastName+" "+demandSet.AgentSet.FirstName+" "+demandSet.AgentSet.MiddleName,
                            demandSet.MinArea.ToString(),demandSet.MaxArea.ToString(),demandSet.MinFloors.ToString(),demandSet.MaxFloors.ToString(),
                            demandSet.MinPrice.ToString(),demandSet.MaxPrice.ToString()
                    });
                    item.Tag = demandSet;
                    listViewHouse.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            demandSet.ClientsSet.LastName+" "+demandSet.ClientsSet.FirstName+" "+demandSet.ClientsSet.MiddleName,
                            demandSet.AgentSet.LastName+" "+demandSet.AgentSet.FirstName+" "+demandSet.AgentSet.MiddleName,
                            demandSet.MinArea.ToString(),demandSet.MaxArea.ToString(),demandSet.MinPrice.ToString(),demandSet.MaxPrice.ToString()
                    });
                    item.Tag = demandSet;
                    listViewLand.Items.Add(item);
                }
            }
            listViewApartments.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewLand.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewLand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLand.SelectedItems.Count==1)
            {
                DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                comboBoxClients.Text = demandSet.ClientsSet.LastName + " " + demandSet.ClientsSet.FirstName + " " + demandSet.ClientsSet.MiddleName.ToString();
                comboBoxAgents.Text = demandSet.AgentSet.LastName + " " + demandSet.AgentSet.FirstName + " " + demandSet.AgentSet.MiddleName.ToString();
                textBoxMinArea.Text = demandSet.MinArea.ToString();
                textBoxMaxArea.Text = demandSet.MaxArea.ToString();
                textBoxMinPrice.Text = demandSet.MinPrice.ToString();
                textBoxMaxPrice.Text = demandSet.MaxPrice.ToString();

            }
            else
            {
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                comboBoxClients.Text = "";
                comboBoxAgents.Text = "";

            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex==0)
                {
                    if(listViewApartments.SelectedItems.Count==1)
                    {
                        DemandSet demandSet = listViewApartments.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demandSet);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
                else if(comboBoxType.SelectedIndex==1)
                {
                    if(listViewHouse.SelectedItems.Count==1)
                    {
                        DemandSet demandSet = listViewHouse.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demandSet);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";

                }
                else
                {
                    if (listViewLand.SelectedItems.Count==1)
                    {
                        DemandSet demandSet = listViewLand.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(demandSet);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();

                    }
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    comboBoxClients.Text = "";
                    comboBoxAgents.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxMinRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDemand_Load(object sender, EventArgs e)
        {

        }
    }
}
