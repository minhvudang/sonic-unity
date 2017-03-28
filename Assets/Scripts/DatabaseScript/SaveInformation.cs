using UnityEngine;
using System.Collections;

public class SaveInformation : MonoBehaviour {

    public static void SaveRecordScore(int record)// phuong thuc luu tru diem so trong unity
    {
        PlayerPrefs.SetInt("Record", record);
    }
}
