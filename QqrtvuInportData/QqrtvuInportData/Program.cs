using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QqrtvuInportData
{
    class Program
    {
        static void Main(string[] args)
        {
            string myConn = ConfigurationManager.ConnectionStrings["mysqlsqerver"].ConnectionString;

            //SqlConnection conn = new SqlConnection(myConn);

            //SqlCommand cmd = conn.CreateCommand();

            //cmd.CommandText = "select * from Users";
            string sql = "select * from Users";
            DataSet ds = SqlHelper.ExecuteSqlDataSet(sql, CommandType.Text);

            foreach (DataRow mDr in ds.Tables[0].Rows)
            {
                foreach (DataColumn mDc in ds.Tables[0].Columns)
                {
                    Console.WriteLine(mDr[mDc].ToString());
                }
            }

            Console.ReadKey();
        }
    }
}
