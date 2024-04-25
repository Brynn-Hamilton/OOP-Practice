using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{ 
    public class DbMigrator
    {
        // dependency injection - specifying the dependencies for the dbmigrator class
        private readonly ILogger _logger;

        // DbMigrator "doesn't care" who the actual logger is
        // an instance of any class that implements this interface can be
        // passed within the constructor
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");
            _logger.LogInfo($"Migration finished at {DateTime.Now}");

            // Details of migrating the database
            // If tomorrow we decide to use a file or db instead of console,
            // we'd have to come back, change it, and then compile and deploy the class

            // we want to be able to change the behavior without changing the code
            // use extensibility
            //Console.WriteLine($"Migration started at {DateTime.Now}");
            //Console.WriteLine($"Migration finished at {DateTime.Now}");
        }
    }
}
