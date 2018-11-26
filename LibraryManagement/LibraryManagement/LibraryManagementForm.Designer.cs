namespace LibraryManagement
{
    partial class LibraryManagementForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OverdueBookCountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BorrowedBookCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBookCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.bookNameTextbox = new System.Windows.Forms.TextBox();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bookGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UserGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.도서관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OverdueBookCountLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BorrowedBookCountLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UserCountLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TotalBookCountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "도서관 현황";
            // 
            // OverdueBookCountLabel
            // 
            this.OverdueBookCountLabel.AutoSize = true;
            this.OverdueBookCountLabel.Location = new System.Drawing.Point(133, 89);
            this.OverdueBookCountLabel.Name = "OverdueBookCountLabel";
            this.OverdueBookCountLabel.Size = new System.Drawing.Size(15, 17);
            this.OverdueBookCountLabel.TabIndex = 7;
            this.OverdueBookCountLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "연체 중인 도서의 수:";
            // 
            // BorrowedBookCountLabel
            // 
            this.BorrowedBookCountLabel.AutoSize = true;
            this.BorrowedBookCountLabel.Location = new System.Drawing.Point(133, 68);
            this.BorrowedBookCountLabel.Name = "BorrowedBookCountLabel";
            this.BorrowedBookCountLabel.Size = new System.Drawing.Size(15, 17);
            this.BorrowedBookCountLabel.TabIndex = 5;
            this.BorrowedBookCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "대출 중인 도서의 수:";
            // 
            // UserCountLabel
            // 
            this.UserCountLabel.AutoSize = true;
            this.UserCountLabel.Location = new System.Drawing.Point(74, 46);
            this.UserCountLabel.Name = "UserCountLabel";
            this.UserCountLabel.Size = new System.Drawing.Size(15, 17);
            this.UserCountLabel.TabIndex = 3;
            this.UserCountLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "사용자 수:";
            // 
            // TotalBookCountLabel
            // 
            this.TotalBookCountLabel.AutoSize = true;
            this.TotalBookCountLabel.Location = new System.Drawing.Point(89, 24);
            this.TotalBookCountLabel.Name = "TotalBookCountLabel";
            this.TotalBookCountLabel.Size = new System.Drawing.Size(15, 17);
            this.TotalBookCountLabel.TabIndex = 1;
            this.TotalBookCountLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "전체 도서 수:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReturn);
            this.groupBox2.Controls.Add(this.btnBorrow);
            this.groupBox2.Controls.Add(this.userIdTextBox);
            this.groupBox2.Controls.Add(this.bookNameTextbox);
            this.groupBox2.Controls.Add(this.isbnTextbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(218, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 118);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여 / 반납";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(227, 69);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "반납";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(227, 40);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 9;
            this.btnBorrow.Text = "대여";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(77, 83);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(144, 25);
            this.userIdTextBox.TabIndex = 8;
            // 
            // bookNameTextbox
            // 
            this.bookNameTextbox.Location = new System.Drawing.Point(77, 52);
            this.bookNameTextbox.Name = "bookNameTextbox";
            this.bookNameTextbox.Size = new System.Drawing.Size(144, 25);
            this.bookNameTextbox.TabIndex = 7;
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.Location = new System.Drawing.Point(77, 18);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(144, 25);
            this.isbnTextbox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "사용자 ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "도서 이름";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ISBN";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bookGridView);
            this.groupBox3.Location = new System.Drawing.Point(13, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1066, 273);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // bookGridView
            // 
            this.bookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGridView.Location = new System.Drawing.Point(6, 24);
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.RowTemplate.Height = 23;
            this.bookGridView.Size = new System.Drawing.Size(1054, 243);
            this.bookGridView.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.UserGridView);
            this.groupBox4.Location = new System.Drawing.Point(12, 434);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1065, 235);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // UserGridView
            // 
            this.UserGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserGridView.Location = new System.Drawing.Point(7, 25);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RowTemplate.Height = 23;
            this.UserGridView.Size = new System.Drawing.Size(1052, 204);
            this.UserGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도서관리ToolStripMenuItem1,
            this.사용자관리ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 도서관리ToolStripMenuItem1
            // 
            this.도서관리ToolStripMenuItem1.Name = "도서관리ToolStripMenuItem1";
            this.도서관리ToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.도서관리ToolStripMenuItem1.Text = "도서 관리";
            this.도서관리ToolStripMenuItem1.Click += new System.EventHandler(this.도서관리ToolStripMenuItem1_Click);
            // 
            // 사용자관리ToolStripMenuItem1
            // 
            this.사용자관리ToolStripMenuItem1.Name = "사용자관리ToolStripMenuItem1";
            this.사용자관리ToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.사용자관리ToolStripMenuItem1.Text = "사용자 관리";
            this.사용자관리ToolStripMenuItem1.Click += new System.EventHandler(this.사용자관리ToolStripMenuItem1_Click);
            // 
            // LibraryManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 677);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "LibraryManagementForm";
            this.Text = "도서관 관리";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TotalBookCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OverdueBookCountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BorrowedBookCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox bookNameTextbox;
        private System.Windows.Forms.TextBox isbnTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView bookGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView UserGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 도서관리ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리ToolStripMenuItem1;
    }
}

