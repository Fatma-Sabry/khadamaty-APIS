using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khadamaty.BL.Helper
{
   public class ApiResponce<T>
    {
        public string Code { get; set; }
        public string Statues { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
