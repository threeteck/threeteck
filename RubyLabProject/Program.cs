using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyLabProject
{
    class Program
    {
		static void Main(string[] args)
        {
			SequenceGenerator sequenceGenerator = new SequenceGenerator();
			int n = int.Parse(Console.ReadLine());
			foreach (var seq in sequenceGenerator.Generate(n))
				Console.WriteLine(seq);
			Console.ReadKey();
        }
    }
}
