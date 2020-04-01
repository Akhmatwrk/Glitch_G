using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;
    [SerializeField] GameObject winLable;
    [SerializeField] GameObject loseLable;
    [SerializeField] float timeToWate = 4f;


    void Start()
    {
        winLable.SetActive(false);
        loseLable.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerDestroid()
    {
        numberOfAttackers--;

        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWinCondition());
        }
    }

    public void LevelTimerFinished()
    {
        StopSpawners();
        levelTimerFinished = true;
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnersArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnersArray)
        {
            spawner.StopSpawning();
        }
    }

    IEnumerator HandleWinCondition()
    {
        winLable.SetActive(true);
        yield return new WaitForSeconds(timeToWate);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }

    public void GameLost()
    {
        StopSpawners();
        loseLable.SetActive(true);
        Time.timeScale = 0;
    }
}
