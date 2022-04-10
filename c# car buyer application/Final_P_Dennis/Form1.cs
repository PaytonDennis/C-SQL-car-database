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
    public partial class Form1 : Form
    {
        ITE370CarSalesEntities context = new ITE370CarSalesEntities();


        private void UpdateInterface(tblSale sale)
        {
            txtMake.Text = sale.tblCar.Make;

            txtModel.Text = sale.tblCar.Model;

            txtType.Text = sale.tblCar.Type;

            txtYear.Text = sale.tblCar.Year.ToString();

            txtSaleDate.Text = sale.SaleDate.ToString();

            txtSalePrice.Text = sale.SalePrice.ToString();

            txtMileage.Text = sale.tblCar.Mileage.ToString();

            txtColor.Text = sale.tblCar.Color;

            txtBuyer.Text = sale.tblBuyer.FirstName + " " + sale.tblBuyer.LastName;

            txtSaleID.Text = sale.SaleID.ToString();

            TxtSalesPerson.Text = sale.tblSalesperson.FirstName + " " + sale.tblSalesperson.LastName;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblSale sale = context.tblSales.First();
            UpdateInterface(sale);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int SaleID = Convert.ToInt32(txtSaleID.Text);

            List<tblSale> fullOwnerList = context.tblSales.OrderBy(x => x.SaleID).ToList();





            if (SaleID != fullOwnerList.Last().SaleID)
            {
                tblSale previousOwner = fullOwnerList.FirstOrDefault(x => x.SaleID > SaleID);


                UpdateInterface(previousOwner);
            }


        }

        private void txtPrevious_Click(object sender, EventArgs e)
        {


            int SaleID = Convert.ToInt32(txtSaleID.Text);

            List<tblSale> fullOwnerList = context.tblSales.OrderByDescending(x => x.SaleID).ToList();

            if (SaleID != fullOwnerList.Last().SaleID)
            {
                tblSale previousOwner = fullOwnerList.FirstOrDefault(x => x.SaleID < SaleID);

                UpdateInterface(previousOwner);
            }


        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblSale sale = context.tblSales.ToList().Last();

            UpdateInterface(sale);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tblSale sale = context.tblSales.First();

            UpdateInterface(sale);
        }

        private void btnShowBuyerList_Click(object sender, EventArgs e)
        {
            Form2 addNewForm = new Form2();

            addNewForm.ShowDialog();

        }
    }
    
    
}
