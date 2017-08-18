using UnityEngine;

public class MenuFunctions : MonoBehaviour {

    public void Play()
    {
        SceneLoader.Instance.DisplayLoadingScene();
    }

    public void Exit()
    {
        Application.Quit();
    }
}
