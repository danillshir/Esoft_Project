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
    public partial class FormAuthrorization : Form
    {
        public static User users = new User();
        public FormAuthrorization()
        {
            InitializeComponent();
        }
        public struct User
        {
            public string login;
            public string password;
            public string type;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text==""&& textBoxPassword.Text=="")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //если логин и пароль ввели
            else
            {
                bool key = false;
                //ищем в БД пользователя с такими логином и паролем и запоминаем их
                foreach (Users user in Program.wftDb.Users)
                {
                    if (textBoxLogin.Text==user.Login&&textBoxPassword.Text==user.Password)
                    {
                        key = true;
                        users.login = user.Login;
                        users.password = user.Password;
                        users.type = user.Type;
                    }
                }
                //если пользователя не нашли
                if(!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                //если пользователя нашли
                else
                {
                    MessageBox.Show("Данные введены верно", "Пользователь найден", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
            }

        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {

        }
    }
}
