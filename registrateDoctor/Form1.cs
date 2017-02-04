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
        List<Doctor> DownloadBase()
        {
            List<Doctor> tempDATA = new List<Doctor>();
            FileStream DATA;
            try
            {
                DATA = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            }
            catch (IOException e)
            {
                File.Create("data.txt");
            }
            
            DATA = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader ReadData = new StreamReader(DATA, Encoding.GetEncoding(1251));
            string line;
            int id = 0;
            while((line = ReadData.ReadLine())!= null)
            {
                Doctor temp = new Doctor();
                string[] doc = line.Split(':');
                temp.FirstName = doc[0];
                temp.SecondName = doc[1];
                temp.ThirdName = doc[2];
                temp.Type = doc[3];
                temp.ID = id;
                tempDATA.Add(temp);
                id++;
            }
            return tempDATA;
        }
        List<Order> DownloadsOrders()
        {
            List<Order> tempOrders = new List<Order>();
            FileStream DATA;
            DATA = new FileStream("orders.txt", FileMode.Open, FileAccess.Read);
            StreamReader ReadData = new StreamReader(DATA, Encoding.GetEncoding(1251));
            string line;
            int id = 0;
            while ((line = ReadData.ReadLine()) != null)
            {
                Order temp = new Order();
                string[] doc = line.Split(';');
                temp.client.FirstName = doc[0];
                temp.client.SecondName = doc[1];
                temp.client.ThirdName = doc[2];
                temp.client.SNILS = doc[3];
                temp.client.Polis = doc[4];
                temp.client.Adress = doc[5];
                string[] date = doc[6].Split(' ')[0].Split('.');
                temp.client.Borning = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]), 0, 0, 0);
                temp.doctor.FirstName = doc[7];
                temp.doctor.SecondName = doc[8];
                temp.doctor.ThirdName = doc[9];
                temp.doctor.Type = doc[10];
                date = doc[11].Split(' ');
                string[] time = date[1].Split(':');
                date = date[0].Split('.');
                temp.time = new DateTime(Convert.ToInt32(date[2]), Convert.ToInt32(date[1]), Convert.ToInt32(date[0]), Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), 0);
                tempOrders.Add(temp);
                id++;
            }
            ReadData.Close();
            return tempOrders;
        }
        void UpdateDatabase()
        {
            FileStream DATA = new FileStream("orders.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writeData = new StreamWriter(DATA, Encoding.GetEncoding(1251));
            foreach(Order order in Orders)
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
            
            Doctors = DownloadBase();
            Orders = DownloadsOrders();
            foreach(Order order in Orders)
            {
                Doctors.Find(x => ((x.FirstName == order.doctor.FirstName)
                                    && (x.SecondName == order.doctor.SecondName)
                                    && (x.ThirdName == order.doctor.ThirdName))).OrderTime.Add(order.time);
            }
            InitializeComponent();
            for(int i = 9; i < 17; i++)
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

                Application.Exit();
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
            foreach(Doctor x in Doctors)
            {
                if ((x.SecondName == FIO[0]) && (x.FirstName == FIO[1]) && (x.ThirdName == FIO[2]))
                    temp = x;
            }
            Time.Items.Clear();
            foreach(DateTime time in Times)
            {
                if (!(temp.OrderTime.Any(x => x.TimeOfDay == time.TimeOfDay)))
                    Time.Items.Add(time.ToShortTimeString());

            }
            Time.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Person
    {
        public string FirstName;
        public string SecondName;
        public string ThirdName;
        public Person()
        {
            FirstName = "";
            SecondName = "";
            ThirdName = "";
        }
    }

    public class Doctor : Person
    {
        public string Type;
        public int ID;
        public List<DateTime> OrderTime;
        public Doctor()
        {
            ID = 0;
            Type = "";
            OrderTime = new List<DateTime>();
        }
    }
    public class Client : Person
    {
        public int ID;
        public string SNILS;
        public string Polis;
        public string Adress;
        public DateTime Borning;
        public Client()
        {
            Borning = new DateTime(1990, 1, 1, 0, 0, 0);
            ID = 0;
            SNILS = "";
            Polis = "";
            Adress = "";
        }
    }
    public class Order
    {
        public Client client;
        public Doctor doctor;
        public DateTime time;
        public Order()
        {
            client = new Client();
            doctor = new Doctor();
            time = new DateTime(1990, 1, 1, 0, 0, 0);
        }
    }
    
}
