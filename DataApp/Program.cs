// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System;
AddRecord();
Show();

void AddRecord()
{
string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=SumantDb;trusted_connection=false;Persist Security Info=False;Encrypt=False";
    
string cmdtext = "insert into Product values(@id,@name,@price,@stock)";

Console.WriteLine("Enter ID");
int id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Name");
string name  = Console.ReadLine();
Console.WriteLine("Enter Price");
int price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Stock");
int stock = Convert.ToInt32(Console.ReadLine());
SqlConnection con = null;
SqlCommand command = null;

try
{
    con = new SqlConnection(connectionString);
    command = new SqlCommand(cmdtext,con);
    command.Parameters.AddWithValue("@id",id);
    command.Parameters.AddWithValue("@name",name);
    command.Parameters.AddWithValue("@price",price);
    command.Parameters.AddWithValue("@stock",stock);
    con.Open();
    command.ExecuteNonQuery();
    Console.WriteLine("Record Added");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally{con.Close();}
}


void Show()
{
string connectionString = "User ID=sa;password=examlyMssql@123; server=localhost;Database=SumantDb;trusted_connection=false;Persist Security Info=False;Encrypt=False";

string cmdtext = "select * from Product";

try
{
    SqlConnection con = new SqlConnection(connectionString);
    con.Open();
    Console.WriteLine("Connection Opened Successfully");
    SqlCommand command = new SqlCommand(cmdtext , con);
    SqlDataReader reader = command.ExecuteReader();
    while(reader.Read())
    {
        Console.WriteLine($"{reader["id"]} --- {reader["Name"]} --- {reader["Price"]} --- {reader["Stock"]} ");
    }
    con.Close();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
}