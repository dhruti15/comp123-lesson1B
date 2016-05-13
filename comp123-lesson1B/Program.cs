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
*version :0.4 - extracted outputstringtoconsole from getusername method
*/





namespace comp123_lesson1B
{
    /**
    *This is a driver class for our program
    *@class program
    *
    */
    class Program
    {
        /**
        *Main method for class program
        *@param {string[]} args
        *@cunstructor Main
        **/
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
            UserName = GetStringFromConsole();
            Console.WriteLine("\n============================\n");
            Console.WriteLine("you entered: " + UserName + "\n");

            return UserName;
        }
        /**
        *This method writes a string to the console. parameters allow the user to choose to add a new Line chracter
        *
        *@method outputstringtoonsole
        *@param {string} outputstring
        @param {bool} hasnewline
        *@return {string} outputstring
        */



        private static string GetStringFromConsole()
        {
            string UserName;
            outputstringtoconsole("'enter username: ", false);
            UserName = Console.ReadLine();
            return UserName;
        }

        private static string outputstringtoconsole(string outputstring, bool hasNewLine)
        {
            if(hasNewLine)
            {
                Console.WriteLine(outputstring);
            }
            else
            {

                Console.Write(outputstring);
            }

            return outputstring;
        }
    }
}
