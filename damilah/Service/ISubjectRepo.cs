using damilah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damilah.Service
{
    public interface ISubjectRepo
    {
        List<Subject> GetSubjects();
    }
}
