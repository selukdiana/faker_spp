using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{


    class User
    {
        public string name;
        public int age { get; set; }
        public double money;
        public DateTime date;
        public List<Dog> dogs;
        public Profile profile;
    }


    class Dog
    {
        public String name;
        public User owner;
        public long longValue;
    }

    class Profile
    {
        public String address;
        public Profile()
        {
            this.address = "address";
            //throw new Exception();
        }
        public Profile(String addr)
        {
            throw new Exception();

            this.address = addr;
        
        }
    }
}
