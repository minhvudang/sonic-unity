using UnityEngine;
using System.Collections;

public class RecordMarker : MonoBehaviour {
    public Sprite[] sp;
    private string scores;
    private SpriteRenderer r;

    public int index;

    private int currentRecord;
    // Use this for initialization
    void Start()
    {
        r = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        LoadInformation.LoadRecord();
       
        if (Player.coin > Player.record)
        {
            Player.record = Player.coin;
            SaveInformation.SaveRecordScore(Player.record);

        }
        
        scores = Player.record.ToString();// lay diem so ve xau string

        if (index < scores.Length)
        {
            for (int i = 0; i < scores.Length; i++)// so sanh de lay anh hien thi so diem tuong ung
            {
                foreach (Sprite s in sp)
                {
                    if (s.name == scores[scores.Length - 1 - index].ToString())
                    {
                        r.sprite = s;
                    }
                }
            }
        }




    }
}
