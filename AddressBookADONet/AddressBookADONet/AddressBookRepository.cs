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
        public static string ConnectionString = @"Data Source=DESKTOP-QGMU8R3;Initial Catalog=Address_Book;Integrated Security=True";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        AddressBookModel model = new AddressBookModel();
        public  void AddContact(AddressBookModel addressBookModel)
        {
            try
            {
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand("dbo.InsertDataIntoDB",sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.first_Name);
                    sqlCommand.Parameters.AddWithValue("@LirstName", model.last_Name);
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.address);
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.city);
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.state);
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.phoneNumber);
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.email);
                    sqlCommand.Parameters.AddWithValue("@FirstName", model.zip);

                }
            }
            catch(Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}
