﻿using RestWithASPNETRoberto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithASPNETRoberto.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private  volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for(int i = 0, i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }
                
        public Person FindByID(long id)
        {
            return new Person
            {
                Id = IncrementAndget(),
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlandia - Minas Gerais - Brasil",
                Gender = "Male"

            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndget(),
                FirstName = "Person Name" + i,
                LastName = "Person lastName" + i,
                Address = "some Address" + i,
                Gender = "Male"

            };
        }

        private long IncrementAndget()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
