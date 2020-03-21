using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] float MinTimeDelay = 1f;
    [SerializeField] float MaxTimeDelay = 5f;

    bool spawn = true;
    int numberOfSpawns = 5;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        int currentSpawn = 0;
        do
        {
            yield return StartCoroutine(SpawnEnemy());
            currentSpawn++;
            if (currentSpawn >= numberOfSpawns)
            {
                spawn = false;
            }
        }
        while (spawn);
    }

    private IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(Random.Range(MinTimeDelay, MaxTimeDelay));
        Attacker newAttacker = Instantiate(
            attackerPrefab,
            transform.position,
            transform.rotation) 
            as Attacker;

        newAttacker.transform.parent = transform;
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
