using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using дээм.Models;

namespace дээм
{
    public partial class AuthForm : Form
    {
        Ispr2522SafiulinaAdPzLazarevContext context = new Ispr2522SafiulinaAdPzLazarevContext();
        public AuthForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new Ispr2522SafiulinaAdPzLazarevContext())
            {
                // Ищем в базе по логину и паролю
                var user = db.Users.FirstOrDefault(u => u.Login == textBox1.Text && u.Password == textBox2.Text);

                if (user != null)
                {
                    // Если нашли — создаем экземпляр Form1
                    Form1 mainForm = new Form1();

                    // Скрываем текущую форму авторизации
                    this.Hide();

                    // Открываем Form1
                    mainForm.ShowDialog();

                    // После того как закроют Form1, закрываем и авторизацию (чтобы приложение не висело в процессах)
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка! Неверный логин или пароль.");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MainCardForm cardForm = new MainCardForm();
            this.Hide();
            cardForm.ShowDialog();
            this.Show(); // Показываем авторизацию снова, когда закрыли карточки
        }
    }
}
  
