using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSsite.Models
{
    public class CatFactory
 {
        public static IEnumerable<Cat> CreateCats()
        {
            List<Cat> meows = new List<Cat>();
            meows.Add(new Cat()
            {
                Meow = "Meow",
                NumOfMeow = 1
                
              
            });
            meows.Add(new Cat()
            {
                Meow = "Meow",
                NumOfMeow = 3


            });
            meows.Add(new Cat()
            {
                Meow = "Meow",
                NumOfMeow = 5


            });

            return meows;
        }
    }

}