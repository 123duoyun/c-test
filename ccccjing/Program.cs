
using System;
class Program
{
    private int age;
    public int Age
    {
        get
        {
            Console.WriteLine("输入正确！\n字段age={0}", age);
            return age;
        }
        set
        {
            if (value > 0 && value < 130)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("输入数据不合理！");
            }
        }
    }
    static void Main(string[] args)
    {
        Program x = new Program();
        Console.WriteLine("请输入年龄：");
        x.Age = Convert.ToInt32(Console.ReadLine());
        int age = x.Age;
    }
}