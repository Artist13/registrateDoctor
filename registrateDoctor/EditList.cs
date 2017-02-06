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
    public partial class EditList : Form
    {
        public EditList()
        {
            InitializeComponent();
        }
        private void EditList_Load(object sender, EventArgs e)
        {
            OrderList.View = View.Details;
            OrderList.Columns.Add("Дата", 150);
            OrderList.Columns.Add("Имя пациента", 300);
            OrderList.Columns.Add("Врач", 300);
            foreach (Order order in StartPage.Orders)
            {
                ListViewItem item = new ListViewItem(order.time.ToString());
                item.SubItems.Add(order.client.SecondName + ' ' + order.client.FirstName + ' ' + order.client.ThirdName);
                item.SubItems.Add(order.doctor.Type + ' ' + order.doctor.SecondName + ' ' + order.doctor.FirstName + ' ' + order.doctor.ThirdName);
                OrderList.Items.Add(item);
            }

        }

        private void OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            Order currentOrder = StartPage.Orders.Find(x => ((x.time.ToString() == OrderList.SelectedItems[0].SubItems[0].Text) &&
                                                    (x.doctor.Type == OrderList.SelectedItems[0].SubItems[2].Text.Split(' ')[0])));
            EditForm newForm = new EditForm(currentOrder);
            newForm.ShowDialog();
            OrderList.Clear();
            OrderList.View = View.Details;
            OrderList.Columns.Add("Дата", 150);
            OrderList.Columns.Add("Имя пациента", 300);
            OrderList.Columns.Add("Врач", 300);
            foreach (Order order in StartPage.Orders)
            {
                ListViewItem item = new ListViewItem(order.time.ToString());
                item.SubItems.Add(order.client.SecondName + ' ' + order.client.FirstName + ' ' + order.client.ThirdName);
                item.SubItems.Add(order.doctor.Type + ' ' + order.doctor.SecondName + ' ' + order.doctor.FirstName + ' ' + order.doctor.ThirdName);
                OrderList.Items.Add(item);
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            OrderList.Items[OrderList.SelectedIndices[0]].Remove();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();
            foreach (ListViewItem item in OrderList.Items)
            {
                orders.Add(StartPage.Orders.Find(x => ((x.time.ToString() == item.SubItems[0].Text) && (x.doctor.Type == item.SubItems[2].Text.Split(' ')[0]))));
            }
            StartPage.Orders = orders;
            FileStream DATA = new FileStream("orders.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writeData = new StreamWriter(DATA, Encoding.GetEncoding(1251));
            foreach (Order order in StartPage.Orders)
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
    }
}
