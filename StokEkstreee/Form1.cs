using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokEkstreee
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=NUMANPC\MSSQLSERVER01;Initial Catalog=Test;Integrated Security=True");
        SqlDataAdapter adapter;

        DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }
        void listele()
        {
            adapter = new SqlDataAdapter("stokEkstre", con);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
