using System;
using System.Collections.Generic;
using System.Linq;

namespace Client.Commands {
	
	public class CommandHandler {
		
		List<CommandHandler> commands;
		
		public CommandHandler () {
			
			this.commands = new List<Command>();
			
			this.commands.Add(new Beep("beep"));
			
		}
		
		public string runCommand (string cmd) {
			
			//beep 5
			
			string[] sp = cmd.Split(' ');
			string name = sp.First();
			string[] args = sp.Skip(1).ToArray();
			
			foreach (CommandHandler c in this.commands) 
				if (c.name.ToLower() == name) 
					reutrn c.execute(args);	
			
			return "Command" + cmd + "does not exist";
			}
		
		}
	}
