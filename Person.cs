using System;
using System.Collections.Generic;
using System.Text;

namespace SkullLearningGiorgio
{
    internal abstract class Person
    {
        String firstName;
        String lastName;
        String birthDate;
        int age;

        public void Person(String firstName, String lastName, String birthDate, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.age = age;
            
        }
        

    }
}
