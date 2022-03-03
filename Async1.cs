using System;
using System.Threading.Tasks;

namespace TaskManagementInDotNet
{
    class Program
    {
	public static void Write(char c)
	{
	    int i = 1000;
	    while(i-- > 0)
	    {
		Console.WriteLine(c); 
	    }
	}
	public static void Display()
	{
	    int i = 100;
	    while(i-- > 0)
	    {
		Console.WriteLine("Hello");
	    }
	}
	public static void write(object o)
	{
	    int i = 1000;
	    while(i-- > 1000)
	    {
		Console.WriteLine(o);
	    }
	}
	public static int TextLength(object o)
	{
	    Console.WriteLine($"\n Task with id: {Task.CurrentId} processing object {o}");
	    return o.ToString().Length;
	}
	static void Main(string[] args)
	{
	   /* Task t = new Task(write, "hello");

	    Task.Factory.StartNew(() => Write('.')); // first way of making a task
						     //Task.Factory.StartNew(() => Display());
	    Task.Factory.StartNew(write, 123);
	    //second way
	    var t = new Task(() => Write('?'));//created only an instance, not yet started
	    t.Start();*/

	    Task.Factory.StartNew(() => TextLength("Vishal"));
	    var lenTask = new Task(() => TextLength("vishaldbhat"));
	    lenTask.Start();
	    string text1 = "testing", text2 = "this";
	    var task1 = new Task<int>(TextLength, text1);
	    task1.Start();
	    Task<int> task2 = Task.Factory.StartNew(TextLength, text2);
	    Console.WriteLine($"Length of {text1} is {task1.Result}");
	    Console.WriteLine($"Length of {text2} is {task2.Result}");
	    var tesk1 = new Task<int>(TextLength, text1);
	    Console.WriteLine("Main Program Done");
	    Console.WriteLine("Hello World!");
	}
    }
}
