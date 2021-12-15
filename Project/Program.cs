using System;
using FakerLib;
using Newtonsoft.Json;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            FakerLib.Faker faker = new FakerLib.Faker();
   //         Profile p = faker.Create<Profile>();
              User user = faker.Create<User>();
               Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
         //   Console.WriteLine(JsonConvert.SerializeObject(p, Formatting.Indented));

        }
    }
}
