using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD.Connection;


namespace DVD.Function
{
    public class Authorisation
    {
        public static ObservableCollection<Sotrudnik> sotrudniks { get; set; }
        public static Sotrudnik AuthorisationSotr (int login, string password)
        {
            sotrudniks=new ObservableCollection<Sotrudnik> (DBconn.dvd.Sotrudnik.ToList());
            var userExists = sotrudniks.Where(sotrudniks => sotrudniks.Id == login && sotrudniks.Password == password).FirstOrDefault();
            if (userExists != null)
            {
                return userExists;
            }
            else
            {
                return userExists;
            }
        }
    }
}
