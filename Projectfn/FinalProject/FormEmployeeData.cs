using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class FormEmployeeData : Form
    {

        private DataAccess data { set; get; }
        public FormEmployeeData()
        {
            InitializeComponent();
            this.data = new DataAccess();
            this.GridViewEmployee();
            this.AutoIdGenerate();
        }
        private void GridViewEmployee(string sql = "select * from  Employee;")
        {

            
            var ds = this.data.ExecuteQuery(sql);
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.DataSource = ds.Tables[0];


        }



        private void FormEmployeeData_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtPass.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from Employee where empUserID='" + this.txtSearch.Text + "';";

            this.GridViewEmployee(sql);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            this.GridViewEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {

                var sql = "insert into Employee  values ('" + this.txtID.Text + "','" + this.txtName.Text + "'," + txtPass.Text + ");";
                var de = this.data.ExecuteDMLQuery(sql);


                if (de == 1)
                {

                    MessageBox.Show("Data insert Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                    MessageBox.Show("Data insert Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.GridViewEmployee();
            }

            catch
            {


                MessageBox.Show("Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();




                var sql = "delete from Employee  where empUserID = '" + id + "';";
                var count = this.data.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(" Deleted");
                else
                    MessageBox.Show("Data remove failed");

                this.GridViewEmployee();




            }

            catch
            {
                MessageBox.Show("Error");
            }


            
        }



        private void AutoIdGenerate()
        {
            var sql = "select empUserID from Employee order by empUserID desc;";
            var dt = this.data.ExecuteQueryTable(sql);
            var lastId = dt.Rows[0][0].ToString();
            string[] s = lastId.Split('-');
            int temp = Convert.ToInt32(s[1]);
            string newId = "e-" + (++temp).ToString("d3");
            this.txtID.Text = newId;



        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
