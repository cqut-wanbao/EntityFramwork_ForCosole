using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace FirstCodeFirstApp
{
   public class Initializer:DropCreateDatabaseIfModelChanges<Context>
    {

    }
}
