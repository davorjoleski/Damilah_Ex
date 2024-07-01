using damilah.Models;
using damilah.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damilah.Repository
{
    public class InMemorySubejct : ISubjectRepo
    {
        public List<Subject> GetSubjects()
        {
            return new List<Subject> { 
                new Subject
           {

                     Name = "Math",
                    Description = "Mathematics is the study of numbers, shapes, and patterns.",
                    NumberOfWeeklyClasses = 5,
                    LiteratureUsed = new List<string> { "Algebra Textbook", "Geometry Workbook","Limes Book" },
                    _teachers = new string[] { "Mr. Smith", "Ms. Davis" },
                    _prerequisites = "Basic Arithmetic"



           },
                  new Subject
           {

                     Name = "English",
                    Description = "English involves the study of literature, language, and writing.",
                    NumberOfWeeklyClasses = 4,
                    LiteratureUsed = new List<string> { "Shakespeare's Plays", "Modern Poetry Collection" },
                    _teachers = new string[] { "Mr. JOhn", "Ms. Sins" },
                    _prerequisites = "Aritmetica"

           },
                    new Subject
           {

                   Name = "Art",
                    Description = "Art is the expression of creativity through visual forms.",
                    NumberOfWeeklyClasses = 3,
                    LiteratureUsed = new List<string> { "Art History Book", "Sketching Guide" },
                    _teachers = new string[] { "Mr. Amin", "Ms. JOsua" },
                    _prerequisites = "Plazma Arithmetic"


           },
                      new Subject
           {

                     Name = "Math",
                    Description = "Mathematics is the study of numbers, shapes, and patterns.",
                    NumberOfWeeklyClasses = 5,
                    LiteratureUsed = new List<string> { "Algebra Textbook", "Geometry Workbook","Structural Proggraming" },
                    _teachers = new string[] { "Mr. Smith", "Ms. Davis" },
                    _prerequisites = "Basic Arithmetic"


           },





               };
        }
    }
}
