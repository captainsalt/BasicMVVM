using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMVVM.Model
{
    class Person
    {
        string _firstName;
        string _lastName;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FullName { get => $"{_firstName}  {_lastName}"; }
    }
}
