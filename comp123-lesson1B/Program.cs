using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*Author: dhruti patel
*Date:may 13,2016
*date modified: may13,2016
*student id: 300857555
*description: this program demonstartes github and version control
*best practices.
*version :0.2 - added the getusername method
*/





namespace comp123_lesson1B
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
        *This method reads the username from the console
        *@method GetUserName
        *@return {string} UserName
        */

        public static string GetUserName()
        {
            //initialize variables
            string UserName = "";
            Console.Write("Enter UserName: ");
           UserName = Console.ReadLine();
            Console.WriteLine("/n============================");
            Console.WriteLine("you entered: " + UserName );

            return UserName;
        }

    }
}
