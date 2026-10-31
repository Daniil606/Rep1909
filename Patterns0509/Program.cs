using Patterns0509.Generation;
using Patterns0509.Generation.AbstractFactory;
using Patterns0509.Generation.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Patterns0509.Generation.Bridge;

namespace Patterns0509
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton.Run();
            //Prototype.Run();
            //FactoryMethod.Run();
            //AbstractFactory.Run();
            //Console.WriteLine("Добавлено изменение в ветке 41");
            //HAHAHAHAHAHAH

            //Adapter.Run();
            
//            string xml = @"
//<root>
//    <person id=""1"">
//        <name>Анна</name>
//        <age>30</age>
//    </person>
//    <person id=""2"">
//        <name>Борис</name>
//        <age>25</age>
//    </person>
//</root>";
//            Console.WriteLine(xmlToJson.Convert(xml));

            Student st1 = new Student("Vasya", 1, 1);
            Student st2 = new Student("Danya", 1, 2);
            Student st3 = new Student("Ilya", 3, 1);

            Teacher t1 = new Teacher("Petrov", 12);
            Teacher t2 = new Teacher("Ivanov", 15);

            Decanat decanat = new Decanat();
            foreach (Student student in new Student[] { st1, st2, st3 }) 
            {
                decanat.AddStudent(student);
            }
            foreach (Teacher teacher in new Teacher[] { t1, t2 })
            {
                decanat.AddTeacher(teacher);
            }
            //st1.SendMsgToTeacher();
            //t2.SendMsgToStudent();
            

        }
    }
}
