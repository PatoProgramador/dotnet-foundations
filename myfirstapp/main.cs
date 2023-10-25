using netfoundations.classes;

namespace netfoundations
{
    internal class Principal
    {
        static void Main(string[] args)
        {   
            // types
            Console.WriteLine("-------TYPES--------");
            Program program = new Program();
            program.Types();
            // classes
            Console.WriteLine("-------CLASS--------");
            ClassMain classMain = new ClassMain();
            classMain.ClassExample();
        }
    }
}