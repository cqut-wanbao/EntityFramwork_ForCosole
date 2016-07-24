using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

//没一点诚意
namespace FirstCodeFirstApp
{
   public class Context:DbContext
    {
       /*base关键字用于从派生类访问基类的成员*/
       public Context():base("name=FirstCodeFirstApp") 
       {
       }
       public DbSet<Donator> Donators { get; set; }
       public DbSet<PayWay> PayWays { get; set; }
       /*你信不信，生成的数据表名会是哪一个？Donator还是Donators?自己跑一下看看撒*/
    }
}
