using System;

namespace Client.Commands
{
	public class Beep
	{
		public Beep(string name) : base(name) {}
		
		public override string execute (string[] args) {
			
			//5
			
			if (args.Length==0) {
				
				Console.Beep();
				
				return "";
				
			}
			else
				if (args.Length==1) {
				
				int i = 0;
				while (int != Int32.Parse(args.First())) {
					
					Console.Beep();
					++i;
					
				}
				return "";
				
			}
			else
				return "Invalid arguments for beep. Reuires either 0 or 1 arguments.";
			
		}
	}
}