using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mdi
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
            dgvContact.Columns.Add("dtnom", "Nom");
            dgvContact.Columns.Add("dtprenom","Prenom");
     
            dgvContact.Columns.Add("dtemail", "Email ");
            dgvContact.Columns.Add("dtphone","telephone");
            
            dgvContact.Columns.Add("dtcont", "Contacte?");

            //dgvContact.Rows.Add("donfack", "fabrice", "fabrice@gmail.com", "675908756", "false");
            //dgvContact.Rows.Add("tamo", "junior", "junior@gmail.com", "678567845", "true");
            
            
            
        }   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool contacted;
            if (chkContact.Checked)
            {
                contacted = true;
            }
            else
            {
                contacted = false;
            }
            dgvContact.Rows.Add(txtnom.Text, txtprenom.Text, txtemail.Text, txtTel.Text, contacted);
        }
    }
}
