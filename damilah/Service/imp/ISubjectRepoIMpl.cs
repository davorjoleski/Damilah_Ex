using damilah.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damilah.Service.imp
{
    
    public class ISubjectRepoIMpl : ISubjectRepo
    {
        private  ISubjectRepo _subjectRepo;

     

        public ISubjectRepoIMpl(ISubjectRepo subjectRepo)
        {
            _subjectRepo = subjectRepo;
        }

        public List<Subject> GetSubjects()
        {
            return _subjectRepo.GetSubjects();
        }
    }
}

