using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

    public static void LoadRecord()
    {
        Player.record = PlayerPrefs.GetInt("Record");// load record tung map
    }
}
