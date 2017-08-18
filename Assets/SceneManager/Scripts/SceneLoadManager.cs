using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
    // guarantee this will be always a singleton only - can't use the constructor!
    protected SceneLoader() { }

    #region synchronous methods

    public void DisplayLoadingScene()
    {
        SceneManager.LoadScene("Loading");

        StartCoroutine(LoadAfterTimer());
    }

    private IEnumerator LoadAfterTimer()
    {
        yield return new WaitForSeconds(2.0f);

        LoadScene();
    }

    public void LoadScene(string sceneName = "Game")
    {
        SceneManager.LoadScene(sceneName);
    }

    #endregion
}
