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
    public partial class LibraryManagementForm : Form
    {
        public LibraryManagementForm()
        {
            InitializeComponent();

            //label 매칭
            TotalBookCountLabel.Text = DataManager.Books.Count.ToString();
            UserCountLabel.Text = DataManager.Users.Count.ToString();

            //DataGrid 매칭
            bookGridView.DataSource = DataManager.Books;
            bookGridView.CurrentCellChanged += BookGridView_CurrentCellChanged;

            UserGridView.DataSource = DataManager.Users;
            UserGridView.CurrentCellChanged += UserGridView_CurrentCellChanged;
        }

        private void BookGridView_CurrentCellChanged(object sender, EventArgs a)
        {

        }
        private void UserGridView_CurrentCellChanged(object sender, EventArgs a)
        {

        }

        private void 도서관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new BookManagementForm().Show();
        }

        private void 사용자관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UserManagementForm().Show();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }
    }
}
