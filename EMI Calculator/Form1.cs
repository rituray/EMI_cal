using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        //Formula =p.r(1+r)n);
        //calculate EMI method

        static double EMI_Calculator(double dLoan, double dRate, double dYears)
        {

            double dPayment;
            dRate = dRate / (12 * 100);
            dYears = dYears * 12;


            dPayment = (dLoan * dRate * (double)Math.Pow(1 + dRate, dYears)) / (double)(Math.Pow(1 + dRate, dYears) - 1);


            return dPayment;
            

        }
        static double Total_interest(double dLoan, double dRate, double dYears)
        {
            double dinterest;

            dYears = dYears * 12;
            dinterest = (dLoan * dRate * dYears)/100 ;
          
            return dinterest;  
            


        }
        static double Total(double dLoan, double dRate)
        {
            double dtotal;



            dRate = dRate / (12 * 100);
            

            dtotal = dLoan + dRate;

            return dtotal;



        }







        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dPayment;
            double dPay;
            double dinterest;
            double dtotal;
            
            
            double dLoan, dRate, dYears;
            

            dLoan = double.Parse(txtLoan.Text);
            dRate = double.Parse(txtRate.Text);
            dYears = double.Parse(txtYears.Text);
            

            dPayment = EMI_Calculator(dLoan, dRate,dYears);
            
            dPay = Math.Round(dPayment, 2);
            dinterest = Total_interest(dLoan, dRate,dYears);
            dtotal = Total(dLoan, dRate);




            txtPayment.Text = " " + dPay ;
            txtinterest.Text = " " + dinterest;
            txttotal.Text = " " + dtotal;
            txtPayment.Refresh();


        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
