using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.IO;
using System.Data;

namespace Shop_DB
{
    public class DB
    {
        private string dbFileName;
        public SQLiteConnection m_dbConn;
        public SQLiteCommand m_sqlCmd;

        public void InitializeDB()
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "sample.sqlite";
        }

        public void CreateDB()
        {
            // создать базу данных, по указанному пути содаётся пустой файл базы данных
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName); }

        public void CreateTable(string tableName, List<string> fields)
        {
            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                string text = "CREATE TABLE IF NOT EXISTS " + tableName +
                    " (id INTEGER PRIMARY KEY AUTOINCREMENT";

                foreach (var fld in fields)
                {
                    text += ", " + fld;
                }

                m_sqlCmd.CommandText = text + ")";
                m_sqlCmd.ExecuteNonQuery(); //do command

                m_dbConn.Close();
            }
            catch (SQLiteException ex)
            {
                //logs of exeption
                // MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void StartDB()
        {
            InitializeDB();
            CreateDB();

            var usrFilds = new List<string>();
            usrFilds.Add("name TEXT");
            usrFilds.Add("pas TEXT");
            usrFilds.Add("mail TEXT");
            CreateTable("Users", usrFilds);

            var cityFilds = new List<string>();
            cityFilds.Add("name TEXT");
            CreateTable("City", cityFilds);

            var marketFlds = new List<string>();
            marketFlds.Add("name TEXT");
            marketFlds.Add("city_id INTEGER");
            marketFlds.Add("address TEXT");
            CreateTable("Market", marketFlds);

            var ctgFilds = new List<string>();
            ctgFilds.Add("name TEXT");
            CreateTable("Categories", ctgFilds);

            var productFilds = new List<string>();
            productFilds.Add("name TEXT");
            productFilds.Add("city_id INTEGER");
            productFilds.Add("count INTEGER");
            CreateTable("Products", productFilds);

            var basketFilds = new List<string>();
            productFilds.Add("usr_id INTEGER");
            productFilds.Add("product_id INTEGER");
            productFilds.Add("product_count INTEGER");
            CreateTable("Products", productFilds);

            var orderFilds = new List<string>();
            //
            var historyFilds = new List<string>();
            //
            var logsFilds = new List<string>();
            //
        }

        public void CreateUser(string name, string pas, string mail)
        {
            try
            {

                string ttext = "select  id from Users order by id desc";
                m_sqlCmd.CommandText = ttext;
                var res = m_sqlCmd.ExecuteScalar();
                int i = 0;
                try
                {
                    i = Int32.Parse(res.ToString());
                }
                catch (Exception e) { }
                if (UserIsNotCreated(name))
                {
                    string text = $"INSERT INTO Users VALUES ({i+1},'{name}', '{pas}', '{mail}')";
                    m_sqlCmd.CommandText = text;
                    m_sqlCmd.ExecuteNonQuery();
                }
                else
                {
                    //error
                    //user is used
                }
            }
            catch (SQLiteException ex)
            {
                //logs of exeption
                // MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        public bool UserIsNotCreated(string name)
        {

            var text = "SELECT id FROM Users WHERE name='" + name + "'";
            m_sqlCmd.CommandText = text;
            var count = m_sqlCmd.ExecuteNonQuery();
            return count == -1;

        }
    }

 

}
