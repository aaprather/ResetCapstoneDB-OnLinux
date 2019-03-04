using System;
using System.Data.SqlClient;

namespace ResetCapstoneDB_OnLinux
{
    class Program
    {
        public static string sql = PrivateInfo.sql; //sql connection string


        static void Main(string[] args)
        {
            Console.WriteLine("Waiting until scheduled database reset time...");
            while (true) //Run in background
            {
                DateTime t = DateTime.Now;
                if (t.Hour == 4 && t.Minute == 0) //4:00AM EST should be a safe time to rebuild table
                {
                    //Clear employees
                    Console.WriteLine("Clearing Table: Employees");
                    try
                    {
                        using (SqlConnection Connection = new SqlConnection(sql))
                        {
                            SqlCommand cmd = new SqlCommand(@"DELETE Employees", Connection);
                            Connection.Open();
                            cmd.ExecuteNonQuery();
                            Connection.Close();
                            Console.WriteLine("Successfully Cleared Table: Employees");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    //Rebuild
                    Console.WriteLine("Rebuilding Table: Employees");
                    try
                    {
                        using (SqlConnection Connection = new SqlConnection(sql))
                        {
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO Employees VALUES ('Hacker', 'Chuck', 'E', 'CEH', 'A1234', 'DOE', 'HR', 'Your bank account', '999-999-9999', '', 'His house', '888-888-8888'),
                                            ('Wesker', 'James', 'K', 'JKW', 'c0239', 'SRNS', 'HR', '730-2b Rm 200', '999-999-9999', 'Chuck E Hacker', '730-2B Rm 201', '888-888-8888'),
                                            ('Carter', 'Jane', 'L', 'JLC', 'e3923', 'SRNS', 'HR', '730-1b Rm 300', '999-999-9999', 'Chuck E Hacker', '', '888-888-8888');", Connection);
                            Connection.Open();
                            cmd.ExecuteNonQuery();
                            Connection.Close();
                            Console.WriteLine("Successfully Rebuilt Table: Employees");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }



                    //Clear drafts
                    Console.WriteLine("Clearing Table: Drafts");
                    try
                    {
                        using (SqlConnection Connection = new SqlConnection(sql))
                        {
                            SqlCommand cmd = new SqlCommand(@"DELETE Drafts", Connection);
                            Connection.Open();
                            cmd.ExecuteNonQuery();
                            Connection.Close();
                            Console.WriteLine("Successfully Cleared Table: Drafts");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    //Clear requests
                    Console.WriteLine("Clearing Table: Requests");
                    try
                    {
                        using (SqlConnection Connection = new SqlConnection(sql))
                        {
                            SqlCommand cmd = new SqlCommand(@"DELETE Requests", Connection);
                            Connection.Open();
                            cmd.ExecuteNonQuery();
                            Connection.Close();
                            Console.WriteLine("Successfully Cleared Table: Requests");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }

                    Console.WriteLine("Sleeping for 60 seconds!\n");
                    System.Threading.Thread.Sleep(60000);
                    Console.WriteLine("Waiting until scheduled database reset time...");
                }
                else
                {
                    System.Threading.Thread.Sleep(10000); //Sleep for 10 seconds if the time requirement is not met
                }
            }
        }
    }
}
