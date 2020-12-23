using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lambda表达式和语法糖
/// </summary>
namespace GrammarSugar
{

    public class Student
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string GetStudentInfo()
        {
            return string.Format("学号={0}，姓名={1}，年龄{2}", ID, Name, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            // 构建student的list
            List<Student> students = new List<Student>();
            for (int i = 0; i < 100; i++)
            {
                Student student = new Student
                {
                    ID = i,
                    Name = "学生" + i,
                    Age = random.Next(0, 100)
                };

                students.Add(student);

            }



            // Lambda表达式
            // 表达式(=>)
            // 获取年龄小于等于30的学生信息
            Console.WriteLine("——————————————————Lambda表达式 => 获取年龄小于等于30的学生信息——————————————————");
            var student55 = students.Where(stu => stu.Age <= 30);
            foreach (var student_AgeLess30 in student55)
            {
                Console.WriteLine(student_AgeLess30.GetStudentInfo());
            }





            //  NULL检查运算符
            // 表达式（?.）
            Console.WriteLine("——————————————————?. NULL检查运算符——————————————————");
            Student student101 = new Student
            {
                ID = 101,
                Name = "顾洪鑫",
                Age = 101
            };
            Console.WriteLine(student101?.GetStudentInfo());
            //// 等同于
            //if(student101!=null)
            //{
            //    Console.WriteLine(student101.GetStudentInfo());
            //}



            // 三元运算符
            // 表达式（?:)
            // 例如：x? y:z 表示如果表达式x为true，则返回y；
            // 如果x为false，则返回z，是省略if{ }else { }的简单形式
            Console.WriteLine("——————————————————?: 三元运算符——————————————————");
            string judgeMsg101 = student101.Age == 101 ? "该学生的年龄为101" : "该学生的年龄不是101";
            Console.WriteLine(student101.GetStudentInfo());
            Console.WriteLine(judgeMsg101);
            //// 等同于
            //string judgeMsg1012 = "";
            //if (student101.Age==101)
            //{
            //    judgeMsg1012 = "该学生的年龄为101";
            //}
            //else
            //{
            //    judgeMsg1012 = "该学生的年龄不是101";
            //}
            //Console.WriteLine(judgeMsg1012);




            // 空合并运算符
            // 表达式（??）
            // 如果此运算符的左操作数不为null，则此运算符将返回左操作数，否则返回右操作数。
            // 例如：a ?? b 当a为null时则返回b，a不为null时则返回a本身。 
            // 空合并运算符为右结合运算符，即操作时从右向左进行组合的。
            // 如，“a ?? b ?? c”的形式按“a ?? (b ?? c)”计算。
            Console.WriteLine("——————————————————?? 空合并运算符——————————————————");
            var student_AgeIsSuitForMarry = students.Where(stu => stu.Age == 25) ?? students.Where(stu => stu.Age == 30) ?? students.Where(stu => stu.Age == 35);
            foreach (var stu in student_AgeIsSuitForMarry)
            {
                Console.WriteLine(stu.GetStudentInfo());
            }





            Console.ReadKey();

            // 退出并回收
            Environment.Exit(0);
            GC.Collect(0);
        }
    }
}
