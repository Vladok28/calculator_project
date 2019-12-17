using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text += "\n Откуда: " + Global.where;
            label1.Text += "\n Куда: " + Global.from;
            label1.Text += "\n Желаемое время прибытия: " + Global.select1;
            label1.Text += "\n Особенности заказа: " + Global.select2;
            Global.select2="";
            if (Global.phonenumber!="Введите номер телефона")
            {
                label1.Text += "\n Номер телефона: " + Global.phonenumber;
            }
            else
            {
                label1.Text += "\n Номер телефона не указан";
            }
            if (Global.comment != "Комментарии к заказу")
            {
                label1.Text += "\n Комментарии к заказу: " + Global.comment;
            }
            else
            {
                label1.Text += "\n Комментарии к заказу отсутствуют";
            }
            label1.Text += "\n Выбранный тариф: " + Global.selectcar;

            //Рандом для выбора машинок
           
            string[] randoms = new string[6];
            randoms[0] = "Audi TT Белая М111OO22";
            randoms[1] = "Chevrolet Corvette Синий О199УЕ74";
            randoms[2] = "Hyundai Solaris Белый А000ВВ74";
            randoms[3] = "Лада Vesta SW Серебристая В800ВВ74";
            randoms[4] = "Toyota Corolla Fielder Белая О901ВЕ38";
            randoms[5] = "Лада Vesta SW Черная Н840ТС50";

            Random r = new Random();
            string randsror = randoms[r.Next(0, randoms.Length - 1)];
            
            label1.Text += "\n Автомобиль ожидает: "+randoms[new Random().Next(0, randoms.Length - 1)];

        }
        //возврат на первую форму на Главную
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //переход на третью форму - кнопка Поехали
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();

            
        }
    }
}
