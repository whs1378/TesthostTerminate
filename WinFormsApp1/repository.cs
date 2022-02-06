using System;
using System.Data.OleDb;

namespace WinFormsApp1
{
    public class Repository
    {
        OleDbConnection _connection = null!;
        public Repository() { }

        public bool Open()
        {
            bool rc = false;
            try
            {
                _connection = new OleDbConnection(
                    "Provider = Microsoft.ACE.OLEDB.12.0;" +
                    $"Data Source=../../../../Database1.accdb");
                _connection.Open();
                rc = true;  
            }
            catch (Exception e)
            {
                rc = false;
            }
            return rc;
        }
        public bool Close()
        {
            bool rc = false;
            try
            {
                _connection.Close();
                rc = true;
            }
            catch (Exception e)
            {
                rc = false;
            }
            return rc;
        }
    }
}
