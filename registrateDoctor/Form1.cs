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
                //temp.client.Boring = doc[6];
                temp.doctor.FirstName = doc[7];
                temp.doctor.SecondName = doc[8];
                temp.doctor.ThirdName = doc[9];
                temp.doctor.Type = doc[10];
                //temp.time = doc[11];

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
        }
        public Form1()
        {
            
            Doctors = DownloadBase();
            Orders = DownloadsOrders();
            InitializeComponent();
            for(int i = 9; i < 17; i++)
            {
                Times.Add(new DateTime(1990, 1, 1, i, 00, 0));
                Times.Add(new DateTime(1990, 1, 1, i, 30, 0));
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Order tempOrder = new Order();
            tempOrder.client.FirstName = FirstName.ToString();
            tempOrder.client.SecondName = SecondName.ToString();
            tempOrder.client.ThirdName = ThirdName.ToString();
            tempOrder.client.Borning = BorningDate.Value;
            tempOrder.client.Adress = Adress.ToString();
            tempOrder.client.SNILS = SNILS.ToString();
            tempOrder.client.Polis = Polis.ToString();

            tempOrder.doctor.Type = Type.ToString();
            string[] FIO = Doctor.ToString().Split(' ');
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
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Doctor x in Doctors)
            {
                if (x.Type == Type.Items[Type.SelectedIndex].ToString())
                {
                    string str = x.SecondName + ' ' + x.FirstName + ' ' + x.ThirdName;
                    Doctor.Items.Add(str);
                }
            }
            
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
            foreach(DateTime time in Times)
            {
                if (!(temp.OrderTime.Any(x => x == time)))
                    Time.Items.Add(time.ToShortTimeString());

            }
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
