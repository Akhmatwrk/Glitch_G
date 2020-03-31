using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;

    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadNextScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void LoadLoseScreen()
    {
        SceneManager.LoadScene("Lose Screen");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Start Screen");
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
