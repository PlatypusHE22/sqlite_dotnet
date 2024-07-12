using System;
using System.Windows.Forms;

namespace SQLiteNET {
    public partial class NewForm : Form {

        private bool confirmed = false;

        public string FirstName => tbFirstName.Text;
        public string LastName => tbLastName.Text;
        public bool Confirmed => confirmed;


        public NewForm(int id)
        {
            InitializeComponent();
            tbId.Text = id.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            confirmed = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}