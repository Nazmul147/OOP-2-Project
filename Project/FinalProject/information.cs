using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class frmPatientInfo : Form
    {
        public frmPatientInfo()
        {
            InitializeComponent();
        }

        private void frmPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxSugerTest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            
        }

       

        private void btnRefrash_Click_1(object sender, EventArgs e)
        {
            this.txtAge.Clear();
            this.txtName.Clear();
            this.txtPayment.Clear();
            this.txtRef.Clear();
            


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            

                if (string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtAge.Text) ||
                    string.IsNullOrEmpty(this.txtRef.Text) || string.IsNullOrEmpty(this.txtPayment.Text)


                    )
                {


                   
                MessageBox.Show("Fill all the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);






            }



            if (string.IsNullOrEmpty(this.txtName.Text) == false && string.IsNullOrEmpty(this.txtAge.Text) == false &&
               string.IsNullOrEmpty(this.txtRef.Text) == false && string.IsNullOrEmpty(this.txtPayment.Text) == false


               )
            {




                this.lblName2.Text = this.txtName.Text;
                
                this.lblAge2.Text = this.txtAge.Text;
                this.lblRef2.Text = this.txtRef.Text;
                this.lblPayment2.Text = this.txtPayment.Text;
                this.lblDate2.Text = this.dtpDOT.Text;

                if (this.rbFemale.Checked)
                    this.lblGender2.Text = "Female";
                else
                    this.lblGender2.Text = this.rbMale.Text;


                //datastore



            }


          

            if (this.cbxBlood.Checked)

                this.lblTestBlood.Text = "Blood";


            if( this.cbxMRI.Checked )

                this.lblTestMRI.Text = "MRI";



            if (this.cbxSugerTest.Checked)

                this.lblTestSuger.Text = "Suger";


                    if (this.cbxCTscan.Checked)
                this.LblTestCT.Text = "CT Scan";


          


        }
        

        private void lblName2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
           
            if(!this.txtPayment.Text.All(Char.IsDigit) || txtPayment.Text.Any(Char.IsSymbol))

            MessageBox.Show("Enter Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            

        }

        private void cbxMRI_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblTest_Click(object sender, EventArgs e)
        {

        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxBlood_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {
           if(txtRef.Text.Any(Char.IsDigit) || txtRef.Text.Any(Char.IsSymbol))

                MessageBox.Show("Enter String", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (!this.txtAge.Text.All(Char.IsDigit) || txtAge.Text.Any(Char.IsSymbol))

                MessageBox.Show("Enter Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Any(Char.IsDigit) || txtName.Text.Any(Char.IsSymbol))

                MessageBox.Show("Enter String", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblPayment_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblRef_Click(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAge2_Click(object sender, EventArgs e)
        {

        }

        private void lblGender2_Click(object sender, EventArgs e)
        {

        }

        private void lblRef2_Click(object sender, EventArgs e)
        {

        }

        private void lblPayment2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DOT_Click(object sender, EventArgs e)
        {

        }

        private void lbls_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTitile_Click(object sender, EventArgs e)
        {

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            FormData f= new FormData();
            f.Visible= true;




        }
    }
}
