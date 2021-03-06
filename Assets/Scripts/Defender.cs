using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int fertCost = 50;

    public void AddStars(int amount)
    {
        FindObjectOfType<FertDisplay>().AddFertilizer(amount);
    }

    public int GetFertCost()
    {
        return fertCost;
    }
}
