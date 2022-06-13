using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp90
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string connectionstring = @"Data Source=DESKTOP-TBJQIMB\SQLEXPRESS;Initial Catalog=a;Integrated Security=True";
            SqlConnection sqlconnecion = new SqlConnection(connectionstring);
            sqlconnecion.Open();
            Console.WriteLine("connnection established");
            string answer;
            do
            {
                Console.WriteLine("enter task to perform \n1.insert \n2.retrieve \n3.update salary \n4.update name \n5.delete");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //--insert
                        Console.WriteLine("enter id");
                        int i_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name");
                        string i_name = Console.ReadLine();
                        Console.WriteLine("enter salary");
                        int i_sal = int.Parse(Console.ReadLine());
                        string insertstring = "insert into emp values(" + i_id + ", '" + i_name + "'," + i_sal + ")";
                        SqlCommand insertcommand = new SqlCommand(insertstring, sqlconnecion);
                        insertcommand.ExecuteNonQuery();
                        Console.WriteLine("inserted succesfully");
                        break;
                    case 2:
                        //--retrieve / select
                        string selectstring = "select*from emp";
                        SqlCommand selectcommand = new SqlCommand(selectstring, sqlconnecion);

                        SqlDataReader readdata = selectcommand.ExecuteReader();
                        while (readdata.Read())
                        {
                            Console.WriteLine(" id: " + readdata.GetValue(0));
                            Console.WriteLine(" name: " + readdata.GetValue(1).ToString());
                            Console.WriteLine(" salary: " + readdata.GetValue(2));
                            Console.WriteLine("----------------------------");
                        }
                        break;
                    case 3:
                        //--update
                        //--update salary
                        Console.WriteLine("enter id in which u want to update");
                        int u_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter salary");
                        int u_sal = int.Parse(Console.ReadLine());
                        string updatestring = "update emp set salary=" + u_sal + "where id= " + u_id + "";
                        SqlCommand updatecommand = new SqlCommand(updatestring, sqlconnecion);
                        updatecommand.ExecuteNonQuery();
                        Console.WriteLine("updated succesfully");
                        break;
                    case 4:
                        Console.WriteLine("enter id in which u want to update");
                        int o_id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter name");
                        string o_name = Console.ReadLine();
                        string updatestr = "update emp set ame= '" + o_name + "' where id = " + o_id;
                        SqlCommand updatecmd = new SqlCommand(updatestr, sqlconnecion);
                        updatecmd.ExecuteNonQuery();
                        Console.WriteLine("updated succesfully");
                        break;
                    case 5:
                        //--delete
                        Console.WriteLine("enter id to delete data");
                        int d_id = int.Parse(Console.ReadLine());
                        string deletestring = "delete from emp where id=" + d_id + "";
                        SqlCommand deletecommand = new SqlCommand(deletestring, sqlconnecion);
                        deletecommand.ExecuteNonQuery();
                        Console.WriteLine("deleted succesfully");
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;

                }
                Console.WriteLine("do you want to perform actions again");
                answer = Console.ReadLine();
            }
            while (answer != "no");
            
                Console.WriteLine("thanks you");
            
            sqlconnecion.Close();
            Console.ReadLine();
        }
    }
}
