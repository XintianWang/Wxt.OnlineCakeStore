using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wxt.OnlineCakeStore.Domain;
using Wxt.OnlineCakeStore.Domain.Concret;

namespace Wxt.OnlineCakeStore.DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new EFDbContext())
            {
                ctx.Cakes.RemoveRange(ctx.Cakes);
                ctx.Receipts.RemoveRange(ctx.Receipts);
                ctx.Categories.RemoveRange(ctx.Categories);
                ctx.SaveChanges();

                ctx.Categories.AddRange(new List<Category>
                {
                    new Category {Name = "Birthday", ParentId = 0, Description = "Cakes for birthday party"},
                    new Category {Name = "Graduation", ParentId = 0, Description = "Cakes for celebrating graduation"},
                    new Category {Name = "Marriage", ParentId = 0, Description = "Cakes for celebrating Marriage"}
                });

                for (int i = 0; i < 11; i++)
                {
                    var cake = new Cake()
                    {
                        Name = $"Birthday{i+1}",
                        Price = 10 + i * 2m,
                        Description = $"Cake {i+1} for birthday party",
                        Dimension = $"10*10*{2 * (i + 1)}",
                        CategoryId = 1
                    };
                    ctx.Cakes.Add(cake);
                    ctx.Stocks.Add(new Stock { CakeId = cake.Id, StockNumber = 10 + i * 2 });
                }

                for (int i = 0; i < 21; i++)
                {
                    var cake = new Cake()
                    {
                        Name = $"Graduation{i+1}",
                        Price = 20 + i * 2m,
                        Description = $"Cake {i+1} for celebrating graduation",
                        Dimension = $"15*10*{3 * (i + 1)}",
                        CategoryId = 2
                    };
                    ctx.Cakes.Add(cake);
                    ctx.Stocks.Add(new Stock { CakeId = cake.Id, StockNumber = 20 + i * 2 });
                }

                for (int i = 0; i < 31; i++)
                {
                    var cake = new Cake()
                    {
                        Name = $"Marriage{i+1}",
                        Price = 30 + i * 2m,
                        Description = $"Cake {i+1} for celebrating Marriage",
                        Dimension = $"15*25*{4 * (i + 1)}",
                        CategoryId = 3
                    };
                    ctx.Cakes.Add(cake);
                    ctx.Stocks.Add(new Stock { CakeId = cake.Id, StockNumber = 30 + i * 2 });
                }

                ctx.SaveChanges();
            }
            //Console.ReadKey();
        }
    }
}
