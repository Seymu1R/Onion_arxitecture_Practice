using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Entities
{
    public class User:BaseClass
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        List<ConTract> Contracts { get; set; }

        public static implicit operator User(List<User> v)
        {
            throw new NotImplementedException();
        }
    }
}
