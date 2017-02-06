using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registrateDoctor
{
    public partial class EditForm : Form
    {
        Order CurrentOrder = new Order();
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            
            SecondName.Text = CurrentOrder.client.SecondName;
            FirstName.Text = CurrentOrder.client.FirstName;
            ThirdName.Text = CurrentOrder.client.ThirdName;
            BorningDate.Text = CurrentOrder.client.Borning.ToShortDateString();
            SNILS.Text = CurrentOrder.client.SNILS;
            Polis.Text = CurrentOrder.client.Polis;
            Adress.Text = CurrentOrder.client.Adress;
            Type.SelectedIndex = Type.Items.IndexOf(CurrentOrder.doctor.Type);
            Type_SelectedIndexChanged();
            Doctor.SelectedIndex = Doctor.Items.IndexOf(CurrentOrder.doctor.SecondName + ' ' + CurrentOrder.doctor.FirstName + ' ' + CurrentOrder.doctor.ThirdName);
            Doctor_SelectedIndexChanged();
            Date.Text = CurrentOrder.time.ToShortDateString();
            Time.SelectedIndex = Time.Items.IndexOf(CurrentOrder.time.ToShortTimeString());

        }
       
        private void Type_SelectedIndexChanged()
        {
            Doctor.Items.Clear();
            foreach (Doctor x in StartPage.Doctors)
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

        
        private void Doctor_SelectedIndexChanged()
        {
            Doctor temp = new Doctor();
            string[] FIO = Doctor.Items[Doctor.SelectedIndex].ToString().Split(' ');
            foreach (Doctor x in StartPage.Doctors)
            {
                if ((x.SecondName == FIO[0]) && (x.FirstName == FIO[1]) && (x.ThirdName == FIO[2]))
                    temp = x;
            }
            Time.Items.Clear();
            foreach (DateTime time in StartPage.Times)
            {
                if (!(temp.OrderTime.Any(x => (x.TimeOfDay == time.TimeOfDay))) || (time.TimeOfDay == CurrentOrder.time.TimeOfDay))
                    Time.Items.Add(time.ToShortTimeString());

            }
            Time.Text = "";
        }

        private void Accept_Click(object sender, EventArgs e)
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
            FIO = Time.SelectedItem.ToString().Split(':');
            tempOrder.time = new DateTime(Date.Value.Year,
                Date.Value.Month,
                Date.Value.Day,
                Convert.ToInt32(FIO[0]),
                Convert.ToInt32(FIO[1]),
                0);
            int i = StartPage.Orders.FindIndex(x => x == CurrentOrder);
            StartPage.Orders[i] = tempOrder;
            StartPage.Doctors.Find(x => (x.SecondName == CurrentOrder.doctor.SecondName)
                                        && (x.FirstName == CurrentOrder.doctor.FirstName)
                                        && (x.ThirdName == CurrentOrder.doctor.ThirdName)
                                        && (x.Type == CurrentOrder.doctor.Type)).OrderTime.Remove(CurrentOrder.time);
            StartPage.Doctors.Find(x => (x.Type == tempOrder.doctor.Type)
                                        && (x.SecondName == tempOrder.doctor.SecondName)
                                        && (x.FirstName == tempOrder.doctor.FirstName)
                                        && (x.ThirdName == tempOrder.doctor.ThirdName)).OrderTime.Add(tempOrder.time);
            Close();
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doctor.Items.Clear();
            foreach (Doctor x in StartPage.Doctors)
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
            foreach (Doctor x in StartPage.Doctors)
            {
                if ((x.SecondName == FIO[0]) && (x.FirstName == FIO[1]) && (x.ThirdName == FIO[2]))
                    temp = x;
            }
            Time.Items.Clear();
            foreach (DateTime time in StartPage.Times)
            {
                if (!(temp.OrderTime.Any(x => (x.TimeOfDay == time.TimeOfDay))))
                    Time.Items.Add(time.ToShortTimeString());

            }
            Time.Text = "";
        }
    }
}
