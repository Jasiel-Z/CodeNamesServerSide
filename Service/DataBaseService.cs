using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    
    
        
        public class DataBaseService : IDatabaseService
        {


            public void AddUserAccountToDatabase(string nickaname, string email, string password)
            {
                using (var databaseContext = new CodeNamesGameEntities())
                {
                    var user = new UserAccountSet
                    {
                        Nickname = nickaname,
                        Email = email,
                        Password = password
                    };

                    databaseContext.UserAccountSet.Add(user);
                    databaseContext.SaveChanges();
                }
            }

            public string GetData(int value)
            {
                return string.Format("You entered: {0}", value);
            }

            public void ShowUsersAccounts()
            {
                using (var databaseContext = new CodeNamesGameEntities())
                {
                    var user = new UserAccountSet();
                    var query = from b in databaseContext.UserAccountSet
                                orderby b.UserAccountId
                                select b;

                    Console.WriteLine("All blogs in the database:");
                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Nickname);
                        Console.WriteLine(item.Email);
                    }
                }
            }



        }
    
}
