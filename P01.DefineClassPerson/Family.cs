using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DefiningClasses;

public class Family
{
    private List<Person> people = new List<Person>();
    public List<Person> People
    {
        get
        {
            return this.people;
        }
        set
        {
            this.people = value;
        }
    }
    public void AddMember(Person member)
    {
        this.People.Add(member);
    }
    public Person GetOldestMember()
    {
        int maxAge = people.Max(p => p.Age);
        Person oldestPerson = people.FirstOrDefault(p => p.Age == maxAge);
        return oldestPerson;
    }

}

