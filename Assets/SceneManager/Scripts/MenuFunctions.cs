using UnityEngine;

public class MenuFunctions : MonoBehaviour
{
    public void Play()
    {
        // Synchronous version
        //SceneLoader.Instance.LoadScene();

        SceneLoaderAsync.Instance.LoadScene();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
