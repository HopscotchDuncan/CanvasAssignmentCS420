using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    internal class Teacher : User
    {
        public Course MakeCourse()
        {
            return new Course();
        }

        public Assignment MakeAssignment()
        {
            return new Assignment();
        }

        public File MakeFile() 
        { 
            return new File(); 
        }

        public string SendAnnouncement(string message)
        {
            return message;
        }

        public Group MakeGroup()
        {
            return new Group();
        }

        public void GradeAssignment(float grade, Assignment assignment)
        {
            assignment.grade = grade;
        }
    }
}
