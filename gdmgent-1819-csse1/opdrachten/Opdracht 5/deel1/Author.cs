using System;

namespace Opdracht_5
{
    public class Author
    {
        // private string name;
        // private string email;
        // private char gender;
        public string Name{get;set;}
        public string Email{get;set;}
        public char Gender{get;set;}

        public Author(string name, string email, char gender){
            Name = name;
            Email = email;
            Gender = gender;
        }

         public string auteurToString(){
            return this.Name+" Email: "+this.Email+" Gender: "+this.Gender;
        }
        public string getAuthorName(){
            return this.Name;
        }

    }
}