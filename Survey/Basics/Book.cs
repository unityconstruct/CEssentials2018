using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.Basics
{
    public class Book
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }


        private string _author;
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }


        private string _topic;
        public string Topic
        {
            get { return _topic; }
            set { Topic = value; }
        }

        private string _id = "12345";
        public string id
        {
            get {return _id;}
         }

        private string _updateTime = "June29,2018";
        public string UpateTime
        {
            set { _updateTime = value; }
        }



        public Book()
        {
            Console.WriteLine("Instantated a new Book");
        }


    }
}
