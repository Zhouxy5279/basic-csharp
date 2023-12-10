// See https://aka.ms/new-console-template for more information
using CSharpBasic;

MyClass Test = new MyClass();
Test.Hello(args);
String input = Convert.ToString(Console.ReadLine());
Console.WriteLine("读取输入：__{0}__", input);

namespace CSharpBasic
{
    class MyClass
	{
        private const string bb = "abc";

        // 数据类型
        // 值类型 Value types
        string name = bb;
		byte bit = 0;
		char unicode = '\0';
		decimal thousand = 777M;
		float length = 1.7F;
		double density = 1.7D;
		int age = 20;
		long year = 2023;
		// 引用类型
		object ?obj;

        int[] varArray = new int[] { 2, 3, 5, 7 };

        public void Hello(string[] args)
		{
            Console.WriteLine("Hello, World!");
            name = "fuck";
			obj = 2333;
            Console.WriteLine("开始吧{0}", thousand);
            Console.WriteLine("值类型long的存储大小为{0}", sizeof(long));

            /* 多
             * 行
             * 注
             * 释
             */

			if (obj == null)
			{
				
			}
			else if (obj == null)
			{

			}
			else
			{

			}
			switch (obj)
			{
				case null:
					break;
				case 0:
					break;
				case 1:
					break;
			}
			while (true)
			{
				break;
			}
            Console.WriteLine("循环到10");
            for (int i = 0; i < 10; i++)
			{
				Console.Write(i);
                if (i > 2)
				{
					break;
				}
			}
            Console.WriteLine("循环输出varArray");
            foreach (var item in varArray)
			{
                Console.WriteLine(item);
            }
        }

    }
}
