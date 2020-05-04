using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class PersonService
    {
        public PersonService()
        {

        }

        /*  public Person Add(Person person)
            {
                if (string.IsNullOrWhiteSpace(person.Name))
                {
                    throw new Exception("Name field is missing");
                }

                if (string.IsNullOrWhiteSpace(person.Surname))
                {
                    throw new Exception("Surname field is missing");
                }

                if (person.Age < 18)
                {
                    throw new Exception("Your age must be at least 18 to sign");
                }

                if (string.IsNullOrWhiteSpace(person.Document) || person.Document.Length != 11 || !int.TryParse(person.Document, out int i))
                {
                    throw new Exception("Invalid Document (CPF)");
                }

                if (person.BornAt == DateTime.MinValue)
                {
                    throw new Exception("BornAt field is missing");
                }

                //Add to database
                return person;
            }
        */
        public Person Add(Person person)
        {
            var validation = new IsPersonValid().Validate(person);

            if (!validation.IsValid)
                throw new Exception(validation.Message);

            //Add to database
            return person;
        }
    }


}

