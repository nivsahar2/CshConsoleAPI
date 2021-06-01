using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CshConsoleAPI
{
	public class AppCommands
	{
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string CMD_EXIT = "exit";
		public const string CMD_ADD = "add";
		public const string CMD_SUB = "sub";
		public const string CMD_MUL = "mul";
		public const string CMD_DIV = "div";

		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}

		public static bool CommandExit(string[] parameters)
		{
			Console.WriteLine(CMD_EXIT);
			Environment.Exit(0);
			return (true);
		}

		public static bool CommandAdd(string[] parameters)
		{
			int sum = 0;
			foreach (string param in parameters)
			{
				sum += Convert.ToInt32(param);
			}
			Console.WriteLine(sum.ToString());
			return (true);
		}

		public static bool CommandSub(string[] parameters)
		{
			int sub = Convert.ToInt32(parameters[0]);

			for (int i = 1; i < parameters.Length; i++)
			{
				sub -= Convert.ToInt32(parameters[i]);
			}
			Console.WriteLine(sub.ToString());
			return (true);
		}

		public static bool CommandMul(string[] parameters)
		{
			int mul = 1;
			foreach (string param in parameters)
			{
				mul *= Convert.ToInt32(param);
			}
			Console.WriteLine(mul.ToString());
			return (true);
		}

		public static bool CommandDiv(string[] parameters)
		{
			double div = Convert.ToInt32(parameters[0]);
				for (int i = 1; i < parameters.Length; i++)
				{
					if (Convert.ToInt32(parameters[i]) != 0)
						div /= Convert.ToDouble(parameters[i]);
				}
				Console.WriteLine(div.ToString());
			return (true);
		}
	}
}
