using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : Singleton<SceneLoader>
{
    // guarantee this will be always a singleton only - can't use the constructor!
    protected SceneLoader() { }

    public void LoadScene()
    {
        SceneManager.LoadScene("Loading");

        StartCoroutine(LoadAfterTimer());
    }

    private IEnumerator LoadAfterTimer()
    {
        // the reason we use a coroutine is simply to avoid a quick "flash" of the 
        // loading screen by introducing an artificial minimum load time :boo:
        yield return new WaitForSeconds(2.0f);

        LoadScene("Game");
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
