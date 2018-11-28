using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace LibraryManagement
{
    class DataManager
    {
        public static MySqlConnection conn = null;

        public static MySqlConnection GetConnection()
        {
            MySqlConnection conn;
            string connectionString = "server=localhost;database=librarymanagement;uid=root;pwd=cs1234;";
            conn = new MySqlConnection(connectionString);
            return conn;
        }

        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager()
        {
            conn = GetConnection();
            Load();
        }

        public static void Load()
        {
            DataSet ds = new DataSet();

            string sql = "select * from book";
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(ds, "book");

            foreach (DataRow abook in ds.Tables["book"].Rows)
            {
                Book book = new Book();
                book.Isbn = abook["isbn"] as string;
                book.Name = abook["name"] as string;
                book.Publisher = abook["publisher"] as string;
                book.Page = (int)abook["page"];

                book.UserId = abook["userid"] as int?;
                book.UserName = abook["username"] as string;
                book.isBorrowed = (bool)abook["isborrowed"];
                book.BorrowedAt = (DateTime)abook["borrowedat"];

                Books.Add(book);
            }

            sql = "select * from user";
            adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(ds, "user");

            foreach (DataRow aUser in ds.Tables["user"].Rows)
            {
                User user = new User();
                user.Id =  (int)aUser["id"];
                user.Name = aUser["name"] as string;

                Users.Add(user);
            }
        }
        public static void Save()
        {

        }
    }
}
