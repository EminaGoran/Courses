using Azure.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
public class UserExceptions:Exception
    {
        public UserExceptions(string message):base(message) { }
    }
}
