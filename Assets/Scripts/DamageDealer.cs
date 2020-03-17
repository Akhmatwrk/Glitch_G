using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] float damage = 100;

    public float GetDamage()
    {
        return damage;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        Health otherHealth = other.gameObject.GetComponent<Health>();
        Attacker attacker = other.gameObject.GetComponent<Attacker>();
        if (!otherHealth) { return; }
        if (!attacker) { return; }
        otherHealth.DealDamage(damage);
    }
}
