using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace registrateDoctor
{


    public partial class Form1 : Form
    {
        List<Doctor> Doctors;
        List<Client> Clients;
        List<Order> Orders;
        List<DateTime> Times = new List<DateTime>();
        int CurrentDoctor = 0;
        
        
        void UpdateDatabase()
        {
            FileStream DATA = new FileStream("orders.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writeData = new StreamWriter(DATA, Encoding.GetEncoding(1251));
            foreach (Order order in Orders)
            {


                writeData.Write(order.client.FirstName + ';'
                    + order.client.SecondName + ';'
                    + order.client.ThirdName + ';'
                    + order.client.SNILS + ';'
                    + order.client.Polis + ';'
                    + order.client.Adress + ';'
                    + order.client.Borning.ToString() + ';'
                    + order.doctor.FirstName + ';'
                    + order.doctor.SecondName + ';'
                    + order.doctor.ThirdName + ';'
                    + order.doctor.Type + ';'
                    + order.time.ToString() + '\n');

            }
            writeData.Close();
        }
        public Form1()
        {
            InitializeComponent();
            Doctors = new List<Doctor>();
            Orders = new List<Order>();
            for (int i = 9; i < 17; i++)
            {
                Times.Add(new DateTime(1990, 1, 1, i, 00, 0));
                Times.Add(new DateTime(1990, 1, 1, i, 30, 0));
            }
        }
        public Form1(List<Doctor> doctors, List<Order> orders)
        {
            InitializeComponent();
            Doctors = doctors;
            Orders = orders;
            foreach (Order order in Orders)
            {
                Doctors.Find(x => ((x.FirstName == order.doctor.FirstName)
                                    && (x.SecondName == order.doctor.SecondName)
                                    && (x.ThirdName == order.doctor.ThirdName))).OrderTime.Add(order.time);
            }
            for (int i = 9; i < 17; i++)
            {
                Times.Add(new DateTime(1990, 1, 1, i, 00, 0));
                Times.Add(new DateTime(1990, 1, 1, i, 30, 0));
            }
        }
        bool Checked()
        {
            bool check = true;
            if (FirstName.Text == "" || FirstName.Text == "Введите Имя")
            {
                FirstName.Text = "Введите Имя";
                check = false;
            }
            if (SecondName.Text == "" || SecondName.Text == "Введите Фамилию")
            {
                SecondName.Text = "Введите Фамилию";
                check = false;
            }
            if (ThirdName.Text == "" || ThirdName.Text == "Введите Отчество")
            {
                ThirdName.Text = "Введите Отчество";
                check = false;
            }
            if (SNILS.Text == "" || SNILS.Text == "Введите № СНИЛС")
            {
                SNILS.Text = "Введите № СНИЛС";
                check = false;
            }
            if (Polis.Text == "" || Polis.Text == "Введите № Полиса")
            {
                Polis.Text = "Введите № Полиса";
                check = false;
            }
            if (Adress.Text == "" || Adress.Text == "Введите Адрес")
            {
                Adress.Text = "Введите Адрес";
                check = false;
            }
            if (Type.Text == "" || Type.Text == "Выберите специальность")
            {
                Type.Text = "Выберите специальность";
                check = false;
            }
            if (Doctor.Text == "" || Doctor.Text == "Выберите врача")
            {
                Doctor.Text = "Выберите врача";
                check = false;
            }
            if (Time.Text == "" || Time.Text == "Выберите время")
            {
                Time.Text = "Выберите время";
                check = false;
            }
            return check;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Checked())
            {
                Order tempOrder = new Order();
                tempOrder.client.FirstName = FirstName.Text;
                tempOrder.client.SecondName = SecondName.Text;
                tempOrder.client.ThirdName = ThirdName.Text;
                tempOrder.client.Borning = BorningDate.Value;
                tempOrder.client.Adress = Adress.Text;
                tempOrder.client.SNILS = SNILS.Text;
                tempOrder.client.Polis = Polis.Text;

                tempOrder.doctor.Type = Type.Items[Type.SelectedIndex].ToString();
                string[] FIO = Doctor.Items[Doctor.SelectedIndex].ToString().Split(' ');
                tempOrder.doctor.SecondName = FIO[0];
                tempOrder.doctor.FirstName = FIO[1];
                tempOrder.doctor.ThirdName = FIO[2];
                tempOrder.time = new DateTime(Date.Value.Year,
                    Date.Value.Month,
                    Date.Value.Day,
                    Convert.ToInt32(Convert.ToString(Time.Items[Time.SelectedIndex].ToString()[0])) * 10 + Convert.ToInt32(Convert.ToString(Time.Items[Time.SelectedIndex].ToString()[1])),
                    Convert.ToInt32(Convert.ToString(Time.Items[Time.SelectedIndex].ToString()[3])) * 10 + Convert.ToInt32(Convert.ToString(Time.Items[Time.SelectedIndex].ToString()[4])),
                    0);
                Orders.Add(tempOrder);
                UpdateDatabase();
                Sucess success = new Sucess();
                success.ShowDialog();
                Close();

            }
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor.Items.Clear();
            foreach (Doctor x in Doctors)
            {
                if (x.Type == Type.Items[Type.SelectedIndex].ToString())
                {
                    string str = x.SecondName + ' ' + x.FirstName + ' ' + x.ThirdName;
                    Doctor.Items.Add(str);
                }
            }
            Doctor.Text = "";
            Time.Text = "";

        }

        private void Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor temp = new Doctor();
            string[] FIO = Doctor.Items[Doctor.SelectedIndex].ToString().Split(' ');
            foreach (Doctor x in Doctors)
            {
                if ((x.SecondName == FIO[0]) && (x.FirstName == FIO[1]) && (x.ThirdName == FIO[2]))
                    temp = x;
            }
            Time.Items.Clear();
            foreach (DateTime time in Times)
            {
                if (!(temp.OrderTime.Any(x => x.TimeOfDay == time.TimeOfDay)))
                    Time.Items.Add(time.ToShortTimeString());

            }
            Time.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
