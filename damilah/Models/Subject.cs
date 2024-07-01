using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damilah.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfWeeklyClasses { get; set; }
        public List<string> LiteratureUsed { get; set; }
        public string [] _teachers  { get; set; }
        public string _prerequisites { get; set; }


        public void DetailsSubjects() {

            Console.WriteLine($"Subject: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weekly Classes: {NumberOfWeeklyClasses}");
            Console.WriteLine($"Literature Used: {string.Join(", ", LiteratureUsed)}");
            Console.WriteLine($"Teachers:  {string.Join(", ", _teachers)}");
            Console.WriteLine($"Prerequsites: {string.Join(", ", _prerequisites)}");


        }

    }
}
