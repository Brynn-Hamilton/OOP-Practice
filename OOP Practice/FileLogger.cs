using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message) 
        {
            // writing data to a file
            // using statement has exception handling it's implemented by the compiler
            //using (var streamWriter = new StreamWriter(_path, true))
            //{
            //    streamWriter.WriteLine("Error" + message);

            //    // this gets called by default from the using statement if there is an exception/error
            //    // this closes the file handle
            //    // this method is used for freeing external resources
            //    //streamWriter.Dispose();
            //}
            Log(message, "Error");
            
            
        }

        public void LogInfo(string message)
        {
             // Dry - Don't Repeat Yourself - created method below
             Log(message, "Info");

        }

        public void Log(string message, string messageType)
        {
            // Dry - Don't Repeat Yourself
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
