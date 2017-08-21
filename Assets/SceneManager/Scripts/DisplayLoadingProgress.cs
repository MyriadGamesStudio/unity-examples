using UnityEngine;
using UnityEngine.UI;

public class DisplayLoadingProgress : MonoBehaviour
{

    private Text LoadingText;

	void Start ()
	{
	    LoadingText = GetComponent<Text>();

        // we've added this script to the wrong UI component if it has no <Text>
	    if (LoadingText == null)
	        Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update ()
	{
	    LoadingText.text = SceneLoaderAsync.Instance.LoadingProgress.ToString("F0") + "%";
	}
}
