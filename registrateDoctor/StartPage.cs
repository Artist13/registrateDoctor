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

namespace registrateDoctor
{
    public partial class StartPage : Form
    {
        static public List<Doctor> Doctors;
        static public List<Client> Clients;
        static public List<Order> Orders;
        static public List<DateTime> Times = new List<DateTime>();
        public StartPage()
        {
            InitializeComponent();
            Doctors = DownloadBase();
            Orders = DownloadsOrders();
            for (int i = 9; i < 17; i++)
            {
                Times.Add(new DateTime(1990, 1, 1, i, 00, 0));
                Times.Add(new DateTime(1990, 1, 1, i, 30, 0));
            }
            foreach (Order order in Orders)
            {
                Doctors.Find(x => ((x.FirstName == order.doctor.FirstName)
                                    && (x.SecondName == order.doctor.SecondName)
                                    && (x.ThirdName == order.doctor.ThirdName))).OrderTime.Add(order.time);
            }
        }
        public List<Doctor> DownloadBase()
        {
            List<Doctor> tempDATA = new List<Doctor>();
            FileStream DATA;
            DATA = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader ReadData = new StreamReader(DATA, Encoding.GetEncoding(1251));
            string line;
            int id = 0;
            while ((line = ReadData.ReadLine()) != null)
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
            ReadData.Close();
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
        private void Regisration_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            Hide();
            newForm.ShowDialog();
            Show();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            EditList newForm = new EditList();
            Hide();
            newForm.ShowDialog();
            Orders = DownloadsOrders();
            this.Show();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            
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
