using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
	internal class CUser
	{
		private string email;
		private string password;

		

		public string Email { get => email; set => email = value; }
		public string Password { get => password; set => password = value; }
	}
}
