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
    public class NoteBook
    {
     public const string Intromessage ="Welcome to the Notepad Application programe";
     public const string ClosingMessage ="Thanks for using the Notepad programe";

    // Defining the list for ipages
     List<Ipageable> pages = new List<Ipageable>();

    // Creating the delegate
     public delegate void SimpleFunction(string command);

    // Creating a dictionary 
     private Dictionary<string, SimpleFunction> commandLineArgs = new Dictionary<string, SimpleFunction>();
     // creating the readonly variables
     public readonly string show ="show", _new ="new", delete="delete";


     // Defining the indexer method
     public SimpleFunction this[string command] 
     {
        get { return commandLineArgs[command]; }
     }


     // Defining the constructor and defining all the commands/keys associated with the functions/ values 
      public NoteBook()
      {
         // Defining the commands/keys associated with the functions/values
         commandLineArgs.Add(show, Show);
         commandLineArgs.Add(_new, New);
         commandLineArgs.Add(delete, Delete);
         
      }
      
      //creat a new notebook with the input arguments instead of the default values
      // :this() is calling the first main contructor first
       public NoteBook(params string[] commanLineKeywords) : this()
       {
        for (int i = 0; i < commanLineKeywords.Length; i++)
        {
            // if there is no input, then continue
          if(commanLineKeywords[i] == "")
          {
             continue;
          }

          switch (i)
          {
            //show
             case 0:
             commandLineArgs.Remove(show);
             commandLineArgs.Add(show = commanLineKeywords[i], Show);
             break;

            //new
             case 1:
             commandLineArgs.Remove(_new);
             commandLineArgs.Add(_new = commanLineKeywords[i], New);
             break;

             //delete
             case 2:
             commandLineArgs.Remove(delete);
             commandLineArgs.Add(delete = commanLineKeywords[i], Delete);
             break;
            
          }
        }

       }

      public void New(string command)
      {
         if(command == "") {
            System.Console.WriteLine("New commands");
            System.Console.WriteLine("new list");
            System.Console.WriteLine("new image");
            System.Console.WriteLine("new message");
         }

         switch (command)
         {
            case "list":
              System.Console.WriteLine("Creating new list");
              break;
            case "image":
              System.Console.WriteLine("Creating new image");
              break;
            case "message":
              System.Console.WriteLine("Creating new message");
              break;
         }
      }

      public void Show(string command) 
      {
          System.Console.WriteLine("Show method " + command);
      }  


      public void Delete(string command)
      {
        System.Console.WriteLine("Delete method " + command);
      }

    }
}