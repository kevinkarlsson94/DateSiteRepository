using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UsersRepository
    {
        public List<Profiles> fetchProfiles()
        {
            using (var context = new UserDBEntities())
            {
                context.Database.Connection.Open();
                return context.Profiles.ToList();
            }
        }
    }
}
