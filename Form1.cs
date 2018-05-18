using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double _total1;
        private double _total2;

        
        private bool _plusButtonClicked;
        private bool _minusButtonClicked;
        
        private bool _divideButtonClicked;
        private bool _multiplyButtonClicked;

        private bool _powButtonClicked;
        private bool _logButtonClicked;

        private string RemoveAmpersand(string input)
        {
            return input.Replace("&", string.Empty);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnOne.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnOne.Text);
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnTwo.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnTwo.Text);
            
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnThree.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnThree.Text);
            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnFour.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnFour.Text);
            
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnFive.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnFive.Text);
            
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnSix.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnSix.Text);
            
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnSeven.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnSeven.Text);
            
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnEight.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnEight.Text);
            
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnNine.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnNine.Text);
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(btnZero.Text)) 
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnZero.Text);
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDisplay.Text)) 
                txtDisplay.Clear();
            
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(btnPoint.Text) && !txtDisplay.Text.Contains("."))
                txtDisplay.Text = txtDisplay.Text + RemoveAmpersand(btnPoint.Text);

        }
        private void btnEquals_Click(object sender, EventArgs e)
        {

            try
            {
                if (_plusButtonClicked)
                {
                    _total2 = _total1 + double.Parse(txtDisplay.Text);
                }
                else if (_minusButtonClicked)
                {
                    _total2 = _total1 - double.Parse(txtDisplay.Text);
                }
                else if (_multiplyButtonClicked)
                {
                    _total2 = _total1 * double.Parse(txtDisplay.Text);
                }
                else if (_divideButtonClicked)
                {
                    _total2 = _total1 / double.Parse(txtDisplay.Text);
                }
                else if (_powButtonClicked)
                {
                    _total2 = Math.Pow(_total1, double.Parse(txtDisplay.Text));
                }
                else if (_logButtonClicked)
                {
                    _total2 = Math.Log(double.Parse(txtDisplay.Text), _total1);
                }
                txtDisplay.Text = _total2.ToString(CultureInfo.InvariantCulture);
                _total1 = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");

            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
              
                _total1 = _total1 + double.Parse(txtDisplay.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");

            }
            finally
            {
                txtDisplay.Clear();

                _plusButtonClicked = true;
                _minusButtonClicked = false;
                _divideButtonClicked = false;
                _multiplyButtonClicked = false;
                _powButtonClicked = false;
                _logButtonClicked = false;

            }
            
        }

        

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                _total1 = _total1 + double.Parse(txtDisplay.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");

            }
            finally 
            {
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = true;
                _multiplyButtonClicked = false;
                _divideButtonClicked = false;
                _powButtonClicked = false;
                _logButtonClicked = false;
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                _total1 = _total1 + double.Parse(txtDisplay.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");
            }
            finally 
            {
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = false;
                _multiplyButtonClicked = false;
                _divideButtonClicked = true;
                _powButtonClicked = false;
                _logButtonClicked = false;
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                _total1 = _total1 + double.Parse(txtDisplay.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");

            }
            finally 
            {
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = false;
                _multiplyButtonClicked = true;
                _divideButtonClicked = false;
                _powButtonClicked = false;
                _logButtonClicked = false;
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            try
            {
                
                _total1 = _total1 + double.Parse(txtDisplay.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");
            }
            finally
            {
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = false;
                _multiplyButtonClicked = false;
                _divideButtonClicked = false;
                _powButtonClicked = true;
                _logButtonClicked = false;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            
            try
            {
                _total1 = _total1 + double.Parse(txtDisplay.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter number first, then symbol");
            }
            finally
            {
                txtDisplay.Clear();

                _plusButtonClicked = false;
                _minusButtonClicked = false;
                _multiplyButtonClicked = false;
                _divideButtonClicked = false;
                _powButtonClicked = false;
                _logButtonClicked = true;
            }
        }

    }
}
