using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4lab2nz
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            ctx.Database.EnsureCreated();
            ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4", IloscObecnych = 15, Sala="b316" });
            ctx.SaveChanges();

            foreach (var item in ctx.Zajecias)
            {
                Console.WriteLine($"{item.Nazwa} {item.ID} {item.IloscObecnych}");
            }
        }
    }
}
