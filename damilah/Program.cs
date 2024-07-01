using damilah.Repository;
using damilah.Service;
using damilah.Service.imp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damilah
{
      class Program
    {

       static void Main()
        {

            var dataSource = new InMemorySubejct();
            var service = new ISubjectRepoIMpl(dataSource);

            var subjects = service.GetSubjects();

            while (true)
            {
                Console.WriteLine("Available Subjects:");
                foreach (var subject in subjects)
                {
                    Console.WriteLine($"- {subject.Name}");
                }

                Console.Write("Enter the subject name to view details: ");
                string selectedSubject = Console.ReadLine();

                var chosenSubject = subjects.Find(s => s.Name.Equals(selectedSubject, StringComparison.OrdinalIgnoreCase));
                if (chosenSubject != null)
                {
                    chosenSubject.DetailsSubjects();
                }
                else
                {
                    Console.WriteLine("Subject not found.");
                }
            }
        }

    }
}
