using System;

namespace CoreInDocker
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($" Hello Human, I am running on : {Environment.OSVersion}");
      Console.WriteLine($" in the machine : {Environment.MachineName}");
      Console.WriteLine($" ,and my current folder is : {Environment.CurrentDirectory} !");
    }
  }
}
