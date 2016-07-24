using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FirstCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new Initializer());
            using (var context = new Context())
            {
              
                context.Database.CreateIfNotExists();
                #region
                ///*made我是到今天我才发现server=localhost  进入了的是计算机名/用户名 这个篮子*/
                //var donators = new List<Donator>
                //{
                //    new Donator
                //    {
                //        Name="西行寺幽幽子",
                //        Account=1520,
                //        DonateDate=DateTime.Now
                //    },
                //    new Donator
                //    {
                //        Name="坂本大佬",
                //        Account=22500,
                //        DonateDate=DateTime.Now
                //    }
                //};

                //var donator_1 = new Donator();
                //donator_1.Name = "";
                //donator_1.Account=0;
                //donator_1.DonateDate = new DateTime(2016, 7, 23);
                //context.Donators.Add(donator_1);
                #endregion
                #region
                //var donators = context.Donators;
                //Console.WriteLine("Id\t\t姓名\t\t\t金额\t\t\t赞助日期");
                //foreach (var donator in donators)
                //{
                //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", donator.DonatorId, donator.Name, donator.Account, donator.DonateDate);
                //}
                #endregion
                #region
                //var donators = context.Donators;
                //if (donators.Any())
                //{
                //    var toBeUpdatedDonator = donators.First(d => d.Name == "西行寺幽幽子");
                //    toBeUpdatedDonator.Name = "西行寺H幽幽子";
                //    context.SaveChanges();
                //}
                #endregion
                #region
                //var toBeDeletedDonator = context.Donators.Single(d => d.Name == "坂本大佬");
                //if (toBeDeletedDonator != null)
                //{
                //    context.Donators.Remove(toBeDeletedDonator);
                //    context.SaveChanges();
                //}
                #endregion
                //context.Donators.AddRange(donators);
                //context.SaveChanges();
            }
            //Console.Write("DB has Created!");
            //Console.Write("Insert One!");
            //Console.Write("Query All!");
            //Console.Write("Update one?all");
            //Console.Write("Has Deleted!");
            Console.Write("Has Created New Database");
            Console.Read();
        }
    }
}
