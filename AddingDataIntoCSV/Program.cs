using System;

namespace AddingDataIntoCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            addingRecords();
            
        }
        public static void addingRecords()
        {
            try
            {
                System.IO.File.WriteAllText(@"D:\OneDrive - Constellation HomeBuilder Systems\Desktop\RegisterUsers.csv", string.Empty);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\OneDrive - Constellation HomeBuilder Systems\Desktop\RegisterUsers.csv", true))
                {
                    file.WriteLine("Username," + "Password");
                    for (int i = 0; i < 10; i++)
                    {
                        Guid obj = Guid.NewGuid();
                        string myguid = obj.ToString();
                        Console.WriteLine("New Guid is " + obj.ToString());
                        file.WriteLine(myguid + "@gmail.com," + "@ut0m@te!@#");
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
