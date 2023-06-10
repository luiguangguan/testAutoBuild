using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace testAutoBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonConvert.SerializeObject(new { a = 1 });
            Console.WriteLine("hello world!");
        }
    }
}
