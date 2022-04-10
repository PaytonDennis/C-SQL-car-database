using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_P_Dennis
{
    public partial class Form2 : Form
    {

        private void clearInterface()
        {
            lstBuyers.Items.Clear();

            txtAddress.Text = " ";

            txtCity.Text = " ";

            txtFirstName.Text = " ";

            txtLastName.Text = " ";

            txtPhoneNumber.Text = " ";
 
            txtState.Text = " ";

            txtZip.Text = " ";
        }

        ITE370CarSalesEntities context = new ITE370CarSalesEntities();

        public Form2()
        {
            InitializeComponent();



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clearInterface();

            foreach (tblBuyer buyer in context.tblBuyers.ToList().OrderBy(b => b.LastName))
            {
                lstBuyers.Items.Add(buyer.FirstName + " " + buyer.LastName);
            }
        }

        private void btnShowAllBuyers_Click(object sender, EventArgs e)
        {
            clearInterface();

            foreach (tblBuyer buyer in context.tblBuyers.ToList().OrderBy(b => b.LastName))
            {
                lstBuyers.Items.Add(buyer.FirstName + " " + buyer.LastName);
            }
        }

        private void btnShowAlabamaBuyers_Click(object sender, EventArgs e)
        {
            clearInterface();

            foreach (tblBuyer buyer in context.tblBuyers.ToList().Where(b => b.State == "AL").OrderBy(b => b.LastName))
            {
                lstBuyers.Items.Add(buyer.FirstName + " " + buyer.LastName);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearInterface();

            foreach (tblBuyer buyer in context.tblBuyers.ToList().Where(b => b.LastName.Contains(txtSearch.Text)).OrderBy(b => b.LastName))
            {
                lstBuyers.Items.Add(buyer.FirstName + " " + buyer.LastName);
            }
        }

        private void lstBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
           tblBuyer buyer = context.tblBuyers.ToList()[lstBuyers.SelectedIndex];


            txtAddress.Text = buyer.Address;

            txtCity.Text = buyer.City;

            txtFirstName.Text = buyer.FirstName;

            txtLastName.Text = buyer.LastName;

            txtPhoneNumber.Text = buyer.PhoneNumber;

            txtState.Text = buyer.State;

            txtZip.Text = buyer.Zip;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == " " ||
            txtLastName.Text == " " || txtPhoneNumber.Text == " ")
            {
                MessageBox.Show("Must enter data for First name, Last name, and Phone #");
                return;
            }

            if (txtFirstName.Text.Length > 50)
            {
                MessageBox.Show("First name is too long (50 is max characters");
                return;
            }

            if (txtLastName.Text.Length > 50)
            {
                MessageBox.Show("Last name is too long (50 is max characters");
                return;
            }

            if (txtState.Text.Length > 2)
            {
                MessageBox.Show("State is too long (2 is max characters");
                return;
            }

            if (txtPhoneNumber.Text.Length > 10)
            {
                MessageBox.Show("Phone # is too long (10 is max characters");
                return;
            }

            if (txtZip.Text.Length > 5)
            {
                MessageBox.Show("Phone # is too long (5 is max characters");
                return;
            }

            if (txtCity.Text.Length > 20)
            {
                MessageBox.Show("City is too long (20 is max characters");
                return;
            }

            if (txtAddress.Text.Length > 50 )
            {
                MessageBox.Show("Address is too long (50 is max characters");
                return;
            }

            tblBuyer buyer = context.tblBuyers.ToList()[lstBuyers.SelectedIndex];

            buyer.FirstName = txtFirstName.Text;
            buyer.LastName = txtLastName.Text;
            buyer.PhoneNumber = txtPhoneNumber.Text;
            buyer.Address = txtAddress.Text;
            buyer.City = txtCity.Text;
            buyer.Zip = txtZip.Text;
            buyer.State = txtState.Text;



            context.SaveChanges();

        }
    }
}
