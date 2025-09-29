using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns_3.Chain2
{
    public class Boss
    {
        public Boss(string name, int limit)
        {
            Name = name;
            Limit = limit;
        }

        public Boss(Boss principal, string name, int limit)
        {
            Name = name;
            Limit = limit;
            Principal = principal;
        }

        public string Name { get; set; }
        public int Limit { get; set; }
        public Boss Principal { get; set; }

        public bool AcceptRequest(string item, int price)
        {
            if (price <= Limit)
            {
                Console.WriteLine("Elfogadva " + Name + " által!");
                return true;
            }
            else if (Principal == null)
            {
                Console.WriteLine("Elutasítva " + Name + " által!");
                return false;
            }
            else
            {
                Console.WriteLine("Átirányítva " + Name + " által!");
                return Principal.AcceptRequest(item, price);
            }
        }
    }
}
