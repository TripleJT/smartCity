using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity
{
    class LoginController
    {
        private DatabaseLinQDataContext db;
        public LoginController (DatabaseLinQDataContext db)
        {
            this.db = db;
        }
 
        public bool inloggen(string gebruikersnaam, string wachtwoord)
        {
            var Gebruiker = (from user in db.users
                              where user.name == gebruikersnaam && user.password == wachtwoord
                              select user).FirstOrDefault();
            if(Gebruiker != null)
            {
                return true;
            }
            else
            {
                return false;
              
            }
        }
    }
}
