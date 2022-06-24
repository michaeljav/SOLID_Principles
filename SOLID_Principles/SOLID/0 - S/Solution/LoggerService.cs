using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._0___S.Solution
{
    interface ILoggerService
    {
        void Info(string  info);
        void Debug(string  info);
        void Error(string  message, Exception ex);
    }
    class LoggerService : ILoggerService
    {

        public LoggerService()
        {
            //here we need to write the code for initialization
            //that is creating the log file with necessary details
        }

        public void Info(string info)
        {
            throw new NotImplementedException();
        }

        public void Debug(string info)
        {
            throw new NotImplementedException();
        }

           public void Error(string message, Exception ex)
        {
            throw new NotImplementedException();
        }

      
    }
}
