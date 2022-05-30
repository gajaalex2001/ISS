using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectISS.Service
{
    public class ServiceException : ApplicationException
    {
		public ServiceException() { }
        public ServiceException(String mess) : base(mess) { }
        public ServiceException(String mess, Exception e) : base(mess, e) { }
    }
}