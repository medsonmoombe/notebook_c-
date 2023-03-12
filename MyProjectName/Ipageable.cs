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
    //create struct for holding page data
    public struct PageData
    {
        public string title;
        public string author;
    }
    
    public interface Ipageable
    {
        PageData Mydata { get; set;}
         // How we are going to input our items
         Ipageable Input();

        // How we are going to output
        void Output();
    }
}