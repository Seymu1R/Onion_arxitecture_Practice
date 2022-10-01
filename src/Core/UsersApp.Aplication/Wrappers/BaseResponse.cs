using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp.Aplication.Wrappers
{
    public class BaseResponse
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public bool IsSuccess { get; set; } = true;
    }
}
