using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// an operating system for users ordering pizza
/// students name: Liu Huachen
/// students number: 10073591
/// </summary>
namespace Beagle_Boys_Pizza {

    public partial class Form1 : Form
    {



        private int _cost = 0;

        private int _toppingsNum = 0;

        private string _crust = "";

        private int _nameNum = 1;

        private int _GlutenfreeNum = 0;

        private int _OtherCrustNum = 0;

        private int _initialcost = 10;

        private int _totalPrice = 0;



        public Form1(){
            InitializeComponent();
            DisplayTotalPrice();
        }

        private void txtName_TextChanged(object sender, EventArgs e){
            cmbSauce.Enabled = true;
            if (txtName.Text == "") {
                _nameNum += 1;
                cmbSauce.Enabled = false;
                grpCrust.Enabled = false;
                grpToppings.Enabled = false;
                btnorder.Enabled = false;
            } else if (_nameNum > 1) {

                cmbSauce.Enabled = true;
                grpCrust.Enabled = true;
                grpToppings.Enabled = true;
                btnorder.Enabled = true;
            }

        }
    


        private void cmbSauce_SelectedIndexChanged(object sender, EventArgs e){
            grpCrust.Enabled = true;

        }

        private void rdoCrustType_CheckedChanged(object sender, EventArgs e){
            grpToppings.Enabled = true;

            RadioButton rdoClick = (RadioButton)sender;
            //store the crust type
            if (rdoGlutenfree.Checked) {
                _crust = "Gluten free";

            } else if (rdoThick.Checked) {

                _crust = "Thick";
            } else {

                _crust = "Thin";
            }

            DisplayTotalPrice();

        }

        private void chkToppings_CheckedChanged(object sender, EventArgs e){

            CheckBox chkClick = (CheckBox)sender;
            //count the toppings munbers and calculate the cost
            if (chkClick.Checked) {
                _toppingsNum += 1;
                if (_toppingsNum > 4) {
                    _cost += 1;
                }
            } else {
                _toppingsNum -= 1;
                if (_toppingsNum >= 4) {
                    _cost -= 1;
                }
            }
            
            if (_toppingsNum >= 1) {
                btnorder.Enabled = true;
            } else {
                btnorder.Enabled = false;
            }



            DisplayTotalPrice();
        }
        private void btnorder_Click(object sender, EventArgs e){

            DisplayMessagebox();

        }
        

        
        /// <summary>
        /// display message box and reset form
        /// </summary>
        private void DisplayMessagebox(){
            if (MessageBox.Show(string.Format("Thank you for your order, {0}.\n 1 {1} pizza base with {2} sauce and {3} toppings.\n\n Your order comes to {4:C}", txtName.Text, _crust, cmbSauce.Text, _toppingsNum, _totalPrice), "Order complete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                == DialogResult.OK) {

                Application.Restart();
            }
        }

        /// <summary>
        /// calculate the cost after crust choosen 
        /// </summary>
        private void CalculateCrustCost(){

            if (_crust == "Gluten free") {
                _GlutenfreeNum += 1;
                if (_GlutenfreeNum > 1 && _initialcost == 10) {
                    _initialcost += 2;

                } else if (_GlutenfreeNum <= 1) {
                    _initialcost += 2;
                } else if (_GlutenfreeNum > 1) {
                    _initialcost += 0;
                }
            } else {
                _OtherCrustNum += 1;
                if (_OtherCrustNum < 1) {
                    _initialcost += 0;
                } else if (_OtherCrustNum > 1 && _initialcost >= 12) {
                    _initialcost -= 2;
                }
            }
        }
            /// <summary>
            /// calculate and display the total price
            /// </summary>
            private void DisplayTotalPrice(){
            CalculateCrustCost();
            _totalPrice = _initialcost + _cost;
            lblPrice.Text = string.Format("Total price: {0:C2}", _totalPrice);
            }



        }
    }





    

    

