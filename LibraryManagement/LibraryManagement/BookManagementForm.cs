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
    public partial class BookManagementForm : Form
    {
        public BookManagementForm()
        {
            InitializeComponent();

            //DataGrid 매칭
            bookGridView.DataSource = DataManager.Books;
            bookGridView.DataMemberChanged += BookGridView_CurrentCellChanged;
        }

        private void BookGridView_CurrentCellChanged(object sender, EventArgs a)
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
