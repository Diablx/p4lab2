using System;

namespace p4lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Context ctx = new Context();
            ctx.Database.EnsureCreated();
            ctx.Zajecias.Add(new Zajecia() { Nazwa = "P4", IloscObecnych = 15, Sala = "b316" });
            ctx.SaveChanges();

            foreach (var item in ctx.Zajecias)
            {
                Console.WriteLine($"{item.Nazwa} {item.ID} {item.IloscObecnych}");
            }
        }
    }
}
