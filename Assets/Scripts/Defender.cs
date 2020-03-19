using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int starCost = 10;


    public void AddStars(int amount)
    {
        StarDisplay starDisplay = FindObjectOfType<StarDisplay>();
        starDisplay.AddStars(amount);
    }

    public void SpendStars(int amount)
    {
        StarDisplay starDisplay = FindObjectOfType<StarDisplay>();
        starDisplay.SpendStars(amount);
    }

    public int GetStarCost()
    {
        return starCost;
    }

}

