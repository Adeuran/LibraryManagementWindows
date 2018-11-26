using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();

            userGridView.DataSource = DataManager.Users;
            userGridView.CurrentCellChanged += UserGridView_CurrentCellChanged;
        }

        private void UserGridView_CurrentCellChanged(object sender, EventArgs a)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

        }
    }
}
