using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Aplication.Features.Commads.UpdateUserComand
{
    public class UpdateUserComandDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string FathetName { get; set; }
        public int Age { get; set; }
    }
}
