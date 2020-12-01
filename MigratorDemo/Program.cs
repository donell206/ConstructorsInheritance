using MigratorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new Logger());

            Logger logger = new Logger();
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();

        }
    }
}
