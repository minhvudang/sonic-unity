using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevellistSystem : MonoBehaviour {

    public Sprite kilittexture;
   // public Sprite aciktexture;
    public Image[] Leveller;
    // Use this for initialization
    void Start()
    {
      // PlayerPrefs.DeleteAll ();
        PlayerPrefs.SetInt("1-1", 1);
        if (Leveller.Length > 0)
        {
            if (PlayerPrefs.GetInt("1-1") == 1)
            {
                //  Leveller[0].sprite = aciktexture;
            }
            else
            {
                Leveller[0].sprite = kilittexture;

            }
            if (PlayerPrefs.GetInt("1-2") == 1)
            {
                //Leveller[1].sprite = aciktexture;
            }
            else
            {
                Leveller[1].sprite = kilittexture;

            }
            if (PlayerPrefs.GetInt("1-3") == 1)
            {
                // Leveller[2].sprite = aciktexture;
            }
            else
            {
                Leveller[2].sprite = kilittexture;

            }
            if (PlayerPrefs.GetInt("1-4") == 1)
            {
                // Leveller[3].sprite = aciktexture;
            }
            else
            {
                Leveller[3].sprite = kilittexture;

            }
            if (PlayerPrefs.GetInt("1-5") == 1)
            {
                //Leveller[4].sprite = aciktexture;
            }
            else
            {
                Leveller[4].sprite = kilittexture;

            }
            if (PlayerPrefs.GetInt("1-6") == 1)
            {
                // Leveller[5].sprite = aciktexture;
            }
            else
            {
                Leveller[5].sprite = kilittexture;

            }
            if (PlayerPrefs.GetInt("1-7") == 1)
            {
                // Leveller[6].sprite = aciktexture;
            }
            else
            {
                Leveller[6].sprite = kilittexture;

            }

            if (PlayerPrefs.GetInt("1-8") == 1)
            {
                //Leveller[7].sprite = aciktexture;
            }
            else
            {
                Leveller[7].sprite = kilittexture;

            }
        }
        


    }

    // Update is called once per frame
    public void LevelAc(string levelac)
    {
        if (levelac == "1-1")
        {
            Application.LoadLevel(levelac);
        }
        if (levelac == "1-2")
        {
            if (PlayerPrefs.GetInt("1-2") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
        if (levelac == "1-3")
        {
            if (PlayerPrefs.GetInt("1-3") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
        if (levelac == "1-4")
        {
            if (PlayerPrefs.GetInt("1-4") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
        if (levelac == "1-5")
        {
            if (PlayerPrefs.GetInt("1-5") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
        if (levelac == "1-6")
        {
            if (PlayerPrefs.GetInt("1-6") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
        if (levelac == "1-7")
        {
            if (PlayerPrefs.GetInt("1-7") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
        if (levelac == "1-8")
        {
            if (PlayerPrefs.GetInt("1-8") == 1)
            {
                Application.LoadLevel(levelac);
            }
            else
            {
                Debug.Log("ko biet");
            }
        }
    }
}
