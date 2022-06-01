using System.Collections.Generic;
using UnityEngine;

public class LinearSearch : MonoBehaviour
{
    private List<Person> people;

    [SerializeField]
    private int peopleCount;

    public async void Search(string name)
    {
        InitList();
        await Benchmark.DoBenchmark(() => Search(people, name));
    }

    private static Person Search(List<Person> people, string name)
    {
        for (int i = 0; i < people.Count; i++)
        {
            if (people[i].Name.Equals(name))
            {
                return people[i];
            }
        }
        return null;
    }

    private void Awake()
    {
        people = new List<Person>(peopleCount);
    }

    private void InitList()
    {
        people.Clear();
        for (int i = 0; i < peopleCount; i++)
        {
            people.Add(Person.RandomPerson());
        }
        Person person = Person.RandomPerson();
        person.Name = "Bob";
        //InsertAtRandomPosition(person);
        InsertAtEnd(person);
    }

    private void InsertAtEnd(Person person)
    {
        people.Add(person);
    }

    private void InsertAtRandomPosition(Person person)
    {
        people.Insert(UnityEngine.Random.Range(0, peopleCount), person);
    }
}