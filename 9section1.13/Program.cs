using System;
using _9section1._13;

namespace _9section1._13
{
	class Program
	{
		static void Main(string[] args)
		{
			runApp();
			Console.ReadLine();
		}

		public static void runApp()
		{

			Teacher teacher = new Teacher();
			teacher.Name = "amaljith";
			teacher.Address = "india";
			teacher.DateOfJoining = DateTime.Today;

			Student student = new Student();
			student.Name = "sai";
			student.Address = "india";
			student.DateOfJoining = DateTime.Today;

			OfficeStaff staff = new OfficeStaff();
			staff.Name = "raju";
			staff.Address = "india";
			staff.DateOfJoining = DateTime.Today;


			Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
			Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
			Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
		}
	}
}
