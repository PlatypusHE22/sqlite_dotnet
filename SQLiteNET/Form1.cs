using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteNET {
    public partial class Form1 : Form {
        private DBHelper db;

        public Form1()
        {
            InitializeComponent();
            db = new DBHelper(dBFunctions.ConnectionStringSQLite);
            db.Load("SELECT * FROM Contact");
            DataTable dataTable = db.DataSet.Tables[0];
            dataGridView1.DataSource = dataTable;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            NewForm form = new NewForm(dataGridView1.Rows.Count);
            form.ShowDialog();

            if (!form.Confirmed)
                return;
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {

        }

        private void menuDelete_Click(object sender, EventArgs e)
        {

        }
    }
}