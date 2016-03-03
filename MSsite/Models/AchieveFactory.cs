using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSsite.Models
{
    public class AchieveFactory
    {
        public static IEnumerable<Achieve> CreateAchieves()
        {
            List<Achieve> achieves = new List<Achieve>();
            achieves.Add(new Achieve()
            {
                Descr = "Не вылетел из универа после 1 семестра"
              
            });
          
            return achieves;
        }
    }

}