using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace request.Order
{
    class Client
    {
        public String name { get; set; }
        public String email { get; set; }
        public DateTime birthDate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(name+ ", (" + birthDate.ToString("dd/MM/yyyy")+ ") - "+email);
            return sb.ToString();
        }
    }
}
