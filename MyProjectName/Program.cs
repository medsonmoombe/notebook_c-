using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Runtime.Serialization;

namespace MyProjectName
{
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook notebook = new NoteBook();

            string input = "";
            string commandPrompt = "Please enter " + notebook.show + "," + notebook._new + "," + notebook.delete;
            System.Console.WriteLine(NoteBook.Intromessage);
            System.Console.WriteLine(commandPrompt);
            string exitProgramme = "exit";


            do
            {
              input = Console.ReadLine();

              string[] command = input.Split();
             try{
              notebook[command[0]]((command.Length > 1) ? command[1] : "");
             } catch(KeyNotFoundException) {
                // to avoid printing the exception message when we enter exit
                if(input != exitProgramme) {
                System.Console.WriteLine(commandPrompt);
                }
             }
            }while(input != exitProgramme);

            Console.WriteLine(NoteBook.ClosingMessage);
            
        }
    }
}
