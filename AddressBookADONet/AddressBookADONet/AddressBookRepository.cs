using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADONet
{
    public class AddressBookRepository
    {
        public static string connectionString = @"Data Source=DESKTOP-QGMU8R3;Initial Catalog=Address_Book;Integrated Security=True";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
