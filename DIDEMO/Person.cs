﻿namespace DIDEMO
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        { 
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }



    }
}