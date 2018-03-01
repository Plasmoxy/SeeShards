using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace HelloWorld {
	class Program {

		private BigInteger a = new BigInteger(2);
		private int i = 1;
		private int maxi = 1;
		private Timer timer;

		private void Add(Object o) {
			if (i <= maxi) {
				Console.WriteLine();
				Console.WriteLine(a.ToString() + " ^ " + i.ToString() + " = " + BigInteger.Pow(a, i));
				i++;
				timer.Change(0, 0);
			} else {
				timer.Dispose();
				Console.WriteLine("## DONE ##");
			}
		}

		public Program() {
			Console.WriteLine("Powers of 2 by Plasmoxy, HelloWorld !");
			Console.WriteLine("Press ESC TO EXIT");

			bool err = false;
			do {
				if (err) Console.WriteLine("YOU MUST ENTER A NUMBER!");
				Console.WriteLine("Pls enter max exponent thank (can be bigg) : ");
			} while (
				err = !Int32.TryParse(Console.ReadLine(), out maxi)
			);


			timer = new Timer(Add, null, 0, 0);

			ConsoleKey key;
			while (true) {
				if (Console.KeyAvailable) {
					key = Console.ReadKey(true).Key;
					switch(key) {
						case ConsoleKey.Escape:
							return;
					}
				}
			}
		}

		static void Main(string[] args) {
			Program p = new Program();
		}
	}
}
