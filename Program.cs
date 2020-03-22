using System;

namespace dotnettrypost
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < args.Length; i++)
                if (args[i] == "--region")
                {
                    if (args[i + 1] == "HelloWorld")
                        HelloWorld();
                    else if (args[i + 1] == "ByeBye")
                        ByeBye();
                }
        }

        private static void HelloWorld()
        {
            #region HelloWorld
            Console.WriteLine("Hello World!");
            #endregion
        }

        private static void ByeBye()
        {
            #region ByeBye
            Console.WriteLine("ByeBye!");
            #endregion
        }
    }
}
