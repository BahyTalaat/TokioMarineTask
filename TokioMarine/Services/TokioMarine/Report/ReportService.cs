using Microsoft.Data.SqlClient;
using Repositories.TokioMarineRepositories.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.TokioMarine.Report
{
    public class ReportService
    {

        string ConSt = "data source=.;initial catalog=TokioMarine ;user id=bahytalaat;password=bbb;Trusted_Connection=True;";

        public DataTable GetProductReport()
        {
            var dt=new DataTable();
            using(SqlConnection con= new SqlConnection(ConSt))
            {
                SqlCommand sqlCommand = new SqlCommand("select Id,Name,Description,Price,Count from Tokio.Product", con);
                sqlCommand.CommandType = CommandType.Text;
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }
        
    }
}
