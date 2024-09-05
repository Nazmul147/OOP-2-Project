using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace FinalProject
{
    public partial class frmFormLogin : Form
    {
        public frmFormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            

        }


        private void btnLogin_Click(object sender, EventArgs e) { }
       

        private void btnView_Click(object sender, EventArgs e)
        {

            if (this.txtPassword.UseSystemPasswordChar)
                this.txtPassword.UseSystemPasswordChar = false;
            else
                this.txtPassword.UseSystemPasswordChar = true;


        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string sqlStr = "Data Source=DESKTOP-PVP6L0G; Initial Catalog=diagonodtic_sys;  Integrated Security=True";
            // bool flag=false;
            string sql = "select * from Employee where empUserID = '" + this.txtUserID.Text + "' and empPassword = '" + this.txtPassword.Text + "';";


            SqlConnection sqlcon = new SqlConnection(@sqlStr);

            

            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            //admin
             string sql1 = "select * from UserAdmin where AdminID = '" + this.txtUserID.Text + "' and AdminPassword = '" + this.txtPassword.Text + "';";
            SqlConnection sqlcon1 = new SqlConnection(@sqlStr);

             sqlcon1.Open();
             SqlCommand sqlcom1 = new SqlCommand(sql1, sqlcon1);
             SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom1);
             DataSet ds1 = new DataSet();
              sda1.Fill(ds1);

            // FormEmployee s = new FormEmployee();
            //s.Visible = true;
            //admin

            if (string.IsNullOrEmpty(this.txtUserID.Text) || string.IsNullOrEmpty(this.txtPassword.Text))


                MessageBox.Show("Fill all the field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            else

             if (ds.Tables[0].Rows.Count == 1)
            {
                // MessageBox.Show("Login Success");
                MessageBox.Show("Login Success", "Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //show
                frmPatientInfo fp = new frmPatientInfo();
                fp.Visible = true;


            }
            else if (ds1.Tables[0].Rows.Count == 1) {

                MessageBox.Show("Login Success", "Mesaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormEmployeeData ed = new FormEmployeeData();
                ed.Visible = true;
            }
            else
            {


                MessageBox.Show("Lagin Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MessageBox.Show("Login Faild");
            }
        
            //admin
            
            //string sql1 = "select * from Admin where AdminID = '" + this.txtUserID.Text + "' and AdminPassword = '" + this.txtPassword.Text + "';";
          //  SqlConnection sqlcon1 = new SqlConnection(@"Data Source=DESKTOP-G8AM4LQ\SQL;Initial Catalog=BillingSystem;User ID=sa;Password=2144");

           // sqlcon1.Open();
           // SqlCommand sqlcom1 = new SqlCommand(sql1, sqlcon1);
          //  SqlDataAdapter sda1 = new SqlDataAdapter(sqlcom1);
          //  DataSet ds1 = new DataSet();
          //  sda1.Fill(ds1);







        }

        private void frmFormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
