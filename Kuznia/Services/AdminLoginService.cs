using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kuznia.Helpers;
using Kuznia.Models;

namespace Kuznia.Services
{
    public class AdminLoginService : ILoginService<Admin>
    {
        private ISerializer<List<Admin>> _serializer;

        public AdminLoginService(ISerializer<List<Admin>> serializer)
        {
            this._serializer = serializer;
        }

        public Admin Login(Admin t)
        {
            List<Admin> adminsDeserialized = _serializer.Deserialize();
            Admin adminSameUsername = adminsDeserialized.FirstOrDefault(x => x.Username == t.Username);
            if (adminSameUsername == null)
                return null;

            if (!VerifyPassword(t.Password, adminSameUsername.Password))
            {
                return null;
            }
            return adminSameUsername;
        }

        private bool VerifyPassword(string pass1, string pass2)
        {
            return pass1.Equals(pass2);
        }
    }
}
