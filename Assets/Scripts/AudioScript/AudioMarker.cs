using UnityEngine;
using System.Collections;

public class AudioMarker : MonoBehaviour {

    public bool turnThemesMusic = false;
    public GameObject themesMusic;

	// Use this for initialization
	void Awake () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (turnThemesMusic)
        {
            themesMusic.SetActive(true);
        }
        else
            themesMusic.SetActive(false);
    }

    public void EnableSound()
    {
        // themesMusic.SetActive(true);
        turnThemesMusic = true;
      
    }
    public void DisableSound()
    {
        // themesMusic.SetActive(false);
        turnThemesMusic = false;
        //btnSound.GetComponent<Animator>().enabled = true;
       
    }
}
