using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{

    public void LoseHealth(int amount)
    {
        FindObjectOfType<HealthDisplay>().DecreaseHealth(amount);
    }
}
