using Microsoft.AspNetCore.Mvc;
using StdApp.Models;
using System.Data;
using System.Data.SqlClient;
namespace StdApp.Controllers;

public class StudentController : Controller
{
    public IActionResult List()
    {
        string constr = "User ID=sa;password=examlyMssql@123; server=localhost;Database=SumantDb;trusted_connection=false;Persist Security Info=False;Encrypt=False";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand command = new SqlCommand("select * from Student",con);
        con.Open();
        SqlDataReader reader = command.ExecuteReader();
        DataTable stdTable = new DataTable();
        stdTable.Load(reader);
        return View(stdTable);
    }
}
