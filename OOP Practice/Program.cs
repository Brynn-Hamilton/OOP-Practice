
using OOP_Practice;
// OCP - Open closed principal - Software entities should be open for extension, but closed for modification
// can change implementation for logger version here
// var dbMigrator = new DbMigrator(new FileLogger("C:\\log.txt"));
var dbMigrator = new DbMigrator(new ConsoleLogger());
dbMigrator.Migrate();