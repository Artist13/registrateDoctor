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
            Type.Text = CurrentOrder.doctor.Type;
            Doctor.Text = CurrentOrder.doctor.SecondName + CurrentOrder.doctor.FirstName + CurrentOrder.doctor.ThirdName;
            Date.Text = CurrentOrder.time.ToShortDateString();
            Time.Text = CurrentOrder.time.ToShortTimeString();

        }

    }
}
