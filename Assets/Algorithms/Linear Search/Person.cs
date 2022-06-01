using System.Collections.Generic;
using UnityEngine;

public class Person
{
    [SerializeField]
    private int age;

    [SerializeField]
    private string job;

    [SerializeField]
    private string name;

    public int Age => age;

    public string Job => job;

    public string Name => name;

    public override bool Equals(object obj)
    {
        return obj is Person person &&
               age == person.age &&
               job == person.job &&
               name == person.name &&
               Age == person.Age &&
               Job == person.Job &&
               Name == person.Name;
    }

    public override int GetHashCode()
    {
        int hashCode = 474896108;
        hashCode = hashCode * -1521134295 + age.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(job);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
        hashCode = hashCode * -1521134295 + Age.GetHashCode();
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Job);
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        return hashCode;
    }

    public override string ToString()
    {
        return $"Name={name}, Age={age}, Job={job}";
    }
}