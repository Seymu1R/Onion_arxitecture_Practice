using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Domain.Entities
{
    public class ConTract:BaseClass
    {
        public string Title{ get; set; }
        public string Description { get; set; }
        public DateTime ActivityTime { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
