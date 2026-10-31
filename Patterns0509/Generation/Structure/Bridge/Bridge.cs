using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Patterns0509.Generation
{
    public static class Bridge
    {
        public class Student
        {
            public string Name;
            public int GroupId;
            public int Id;
            public string citizenship;
            Dictionary<int, List<string>> msgsFromTeachers = new Dictionary<int, List<string>>();
            Dictionary<int, List<string>> msgsToTeachers = new Dictionary<int, List<string>>();

            public Student(string _name, int _groupId, int _Id) 
            {
                Name = _name;
                GroupId = _groupId;
                Id = _Id;
            }
            public void GetMsgFromTeacher(int teacherId, string msg)
            {
                if (msgsFromTeachers.ContainsKey(teacherId)) msgsFromTeachers[teacherId].Add(msg);
                else 
                {
                    msgsFromTeachers.Add(teacherId, new List<string>());
                    msgsFromTeachers[teacherId].Add(msg);
                }
            }
            public void SendMsgToTeacher()
            {
                Console.Write("Сообщение: ");
                string msg = Console.ReadLine();
                Console.Write("Id преподавателя: ");
                int teacherId = Convert.ToInt32(Console.ReadLine());
            }
        }

        public class Teacher
        {
            public string Name;
            public int Id;
            public Dictionary<int, List<string>> msgsFromStudents = new Dictionary<int, List<string>>();
            public Dictionary<int, List<string>> msgsToGroups = new Dictionary<int, List<string>>();

            public Teacher(string _name, int _Id) 
            {
                Name = _name;
                Id = _Id;
            }

            public (int, string) SendMsgToStudent()
            {
                Console.WriteLine("Сообщение: ");
                string msg = Console.ReadLine();
                Console.WriteLine("Id группы: ");
                int group = Convert.ToInt32(Console.ReadLine());
                return (group, msg);
            }
            public void GetMsgFromStudent(int studentId, string msg)
            {
                if (msgsFromStudents.ContainsKey(studentId)) msgsFromStudents[studentId].Add(msg);
                else
                {
                    msgsFromStudents.Add(studentId, new List<string>());
                    msgsFromStudents[studentId].Add(msg);
                }
            }
        }

        public class Decanat
        {
            public Dictionary<int,string> MsgsToStudents= new Dictionary<int,string>();
            public Dictionary<int, string> MsgsToTeachers = new Dictionary<int, string>();

            public List<Student> students = new List<Student>();
            public List<Teacher> teachers = new List<Teacher>();

            //public event 

            public void MSGToGroup(Teacher teacher, (int, string) turple)
            {
                var (groupId, msg) = turple;
                foreach (Student student in students)
                {
                    if (student.GroupId == groupId) student.GetMsgFromTeacher(teacher.Id, msg);
                } 
            }
            public void MSGToTeacher(Student student, (int, string) turple)
            {
                var (teacherId, msg) = turple;
                foreach (Teacher teacher in teachers)
                {
                    if (teacher.Id == teacherId) teacher.GetMsgFromStudent(student.Id, msg);
                    break;
                }
            }

            public void AddTeacher(Teacher teacher)
            { 
                if(!teachers.Contains(teacher)) teachers.Add(teacher);
            }
            public void AddStudent(Student student)
            {
                if (!students.Contains(student)) students.Add(student);
            }
        }
    }
}
