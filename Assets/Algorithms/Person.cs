using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Person
{
    [SerializeField]
    private int age;

    [SerializeField]
    private string name;

    [SerializeField]
    private float someValue;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public float SomeValue
    {
        get { return someValue; }
        set { someValue = value; }
    }

    public static Person RandomPerson()
    {
        Person p = new Person
        {
            name = Guid.NewGuid().ToString(),
            age = UnityEngine.Random.Range(0, 100),
            someValue = UnityEngine.Random.Range(-100f, 100f)
        };
        return p;
    }

    public override bool Equals(object obj)
    {
        return obj is Person person &&
               Name == person.Name;
    }

    public override int GetHashCode()
    {
        int hashCode = -567809490;
        hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
        return hashCode;
    }

    public override string ToString()
    {
        return $"Name={name}, Age={age}, SomeValue={someValue}";
    }
}