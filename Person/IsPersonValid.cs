using DomainValidation.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Person
{
    public class IsPersonValid : Validator<Person>
    {
        /*    public IsPersonValid()
            {
                Add("NameIsNotNullOrWhiteSpace", new Rule<Person>(new NameIsNotNullOrWhiteSpace(), "Name field is missing"));
                Add("SurnameIsNotNullOrWhiteSpace", new Rule<Person>(new SurnameIsNotNullOrWhiteSpace(), "Surname field is missing"));
                Add("IsPersonInAdulthood", new Rule<Person>(new IsPersonInAdulthood(), "Your age must be at least 18 to sign"));
                Add("DocumentIsNotNullOrWhiteSpace", new Rule<Person>(new DocumentIsNotNullOrWhiteSpace(), "Document field is missing"));
                Add("IsCpfValid", new Rule<Person>(new IsCpfValid(), "Invalid Document (CPF)"));
                Add("IsBornAtValidDate", new Rule<Person>(new IsBornAtValidDate(), "BornAt field is missing"));
            }
         */
            public IsPersonValid()
            {
                Add("NameIsNotNullOrWhiteSpace", new Rule<Person>(new IsNotNull<Person>(x => x.Name), "Name field is missing"));
                Add("SurnameIsNotNullOrWhiteSpace", new Rule<Person>(new IsNotNull<Person>(x => x.Surname), "Surname field is missing"));
//              Add("IsPersonInAdulthood", new Rule<Person>(new IsExpressionValid<Person>(x => x.Age > 17), "Your age must be at least 18 to sign"));
                Add("DocumentIsNotNullOrWhiteSpace", new Rule<Person>(new IsNotNull<Person>(x => x.Document), "Document field is missing"));
                Add("IsCnpValid", new Rule<Person>(new IsExpressionValid<Person>(x => Regex.IsMatch(x.Document, "\\d{11}")), "Invalid Document (CNP)"));
//              Add("IsBornAtValidDate", new Rule<Person>(new IsNotNull<Person>(x => x.BornAt), "BornAt field is missing"));
            }
    }
}
