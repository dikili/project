using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DataAccess
{
    public static class UserQuery
    {

        public static bool ValidateUserCredentials(string _username, string _password)
        {
            using (var cn = new SqlConnection(@"Server=tcp:projectdb83.database.windows.net,1433;Database=Projectdb;User ID=dikili@projectdb83;Password=F213233d;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;"))
            {
                string _sql = @"SELECT [Username] FROM [dbo].[User] " +
                       @"WHERE [Username] = @u AND [Password] = @p";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                    .Value = _username;
                cmd.Parameters
                    .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                    .Value = Helpers.SHA1.Encode(_password);
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
    }
}
