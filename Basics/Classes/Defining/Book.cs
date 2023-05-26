using System;

namespace Defining
{
    // classes have a name, unique within the namespace
    public class Book
    {
        // TODO: classes have member variables, or "fields" to hold data
        string _name;
        string _author;
        int _pagecount;

        // TODO: classes have one or more constructors
        public Book(string name,string author,int pagecount)
        {
            this._name = name;
            this._author = author;
            this._pagecount = pagecount;    
        }


        // TODO: methods are used to operate on the class and data

        public string GetDescription()
        {
            return $"{_name} by {_author}";
        }
    }
}
