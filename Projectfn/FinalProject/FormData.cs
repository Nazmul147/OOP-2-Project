using Microsoft.SqlServer.Server;
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
    public partial class FormData : Form
    {


        private DataAccess data { set; get; }
        public FormData()
        {
            InitializeComponent();
            this.data = new DataAccess();
            this.GridView();
            this.AutoIdGenerate();



        }

        private void GridView(string sql = "select * from PatientData;")
        {


            var ds = this.data.ExecuteQuery(sql);
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.DataSource = ds.Tables[0];


        }

        private void FormData_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select*from PatientData where id='" + this.txtSearch.Text + "';";

            this.GridView(sql);



        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.GridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {




            try
            {

                var sql = "insert into PatientData values ('" + this.txtPatientID.Text + "','" + this.txtPatientName.Text + "'," + txtPAtientAge.Text + ",'" + this.txtRef.Text + "','" + this.dtpDATE+ "','" + cbxTest.Text + "'," + this.txtPayment.Text + ",'" + this.cbxGender.Text + "');";
                var de = this.data.ExecuteDMLQuery(sql);


                if (de ==1)
                {

                    MessageBox.Show("Data insert Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                    MessageBox.Show("Data insert Faild", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.GridView();
            }

            catch
            {


                MessageBox.Show("Error ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPatientID.Clear();
            this.txtPatientName.Clear();
            this.txtPAtientAge.Clear();
            this.txtRef.Clear();
           
            this.dtpDATE.Text = "";
            this.txtPayment.Clear();
            this.cbxTest.SelectedIndex = -1;
            this.cbxGender.SelectedIndex = -1;


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {



        }



        private void AutoIdGenerate()
        {
            var sql = "select id from PatientData order by id desc;";
            var dt = this.data.ExecuteQueryTable(sql);
            var lastId = dt.Rows[0][0].ToString();
            string[] s = lastId.Split('-');
            int temp = Convert.ToInt32(s[1]);
            string newId = "p-" + (++temp).ToString("d3");
            this.txtPatientID.Text = newId;
            


        }

        private void dtpDATE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)//delete
        {


            try
            {
                var id = this.dataGridView.CurrentRow.Cells[0].Value.ToString();




                var sql = "delete from PatientData where id = '" + id + "';";
                var count = this.data.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(" Deleted");
                else
                    MessageBox.Show("Data remove failed");

                this.GridView();




            }

            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
