using UnityEngine;

public class LinearSearch : MonoBehaviour
{
    [SerializeField]
    private Person[] people;

    public async void Search(string name)
    {
        await Benchmark.DoBenchmark(() => Search(people, name));
    }

    private Person Search(Person[] people, string name)
    {
        for (int i = 0; i < people.Length; i++)
        {
            if (people[i].Name.Equals(name))
            {
                return people[i];
            }
        }
        return null;
    }
}