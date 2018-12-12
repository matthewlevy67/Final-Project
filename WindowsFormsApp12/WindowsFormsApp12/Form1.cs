using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Total : Form
    {
        

        public Total()
        {
            InitializeComponent();
        }

        Boolean errorfound = false;

        private void btnCal_Click(object sender, EventArgs e)

        {

            Double meal = 0;

            //Meal Slections
            if (cmbB.Text == "" & txtQtyB.Text != "") {
                lblB.Text = "No Meal has been  Selected";
            }

            if (txtQtyB.Text == "" & cmbB.Text != "") {
                lblB.Text = "No Quantity has been selected";
            }
            if (cmbB.Text == "" & txtQtyB.Text == "")
            {
                lblB.Text = "Please Select a Quantity and a Meal";
            }


            if (cmbD.Text == "" & txtQtyD.Text != "")
            {
                lblD.Text = "No Meal has been  Selected";
            }

            if (txtQtyL.Text == "" & cmbL.Text != "")
            {
                lblL.Text = "No Quantity has been selected";
            }
            if (cmbL.Text == "" & txtQtyL.Text == "")
            {
                lblL.Text = "Please Select a Quantity and a Meal";
            }


            if (cmbD.Text == "" & txtQtyD.Text != "")
            {
                lblD.Text = "No Meal has been  Selected";
            }

            if (txtQtyD.Text == "" & cmbD.Text != "")
            {
                lblD.Text = "No Quantity has been selected";
            }
            if (cmbL.Text == "" & txtQtyD.Text == "")
            {
                lblD.Text = "Please Select a Quantity and a Meal";
            }

            else
            {
                MessageBox.Show("Numbers Only");
                lblB.Text = "";
                errorfound = true;
            }

            
            {
                MessageBox.Show("Numbers Only");
                lblL.Text = "";
                errorfound = true;
            }

            
            {
                MessageBox.Show("Numbers Only");
                lblD.Text = "";
                errorfound = true;
            }

            //Method for calucating the totals

                double cost = 0;
                double bagel = 3.95;
                double veg = 10.95;
                double protein = 11.95;

                bagel = bagel * Convert.ToDouble(txtQtyB.Text);
                veg = veg * Convert.ToDouble(txtQtyB.Text);
                bagel = protein * Convert.ToDouble(txtQtyB.Text);

              switch  (cmbB.Text)
            {
                case "bagel":
                    cost = 3.95;
                    break;
                case "veg":
                    cost = 10.95;
                    break;
                case "protein":
                    cost = 11.95;
                    break;
            }


            }
            

        







            //has a been selected

            //error display message 

            // calcualte all


        }
    }

