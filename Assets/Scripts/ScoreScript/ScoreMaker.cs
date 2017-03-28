using UnityEngine;
using System.Collections;

public class ScoreMaker : MonoBehaviour {
    public Sprite[] sp;
    private string scores;
    private SpriteRenderer r;

    public int index;
	// Use this for initialization
	void Start () {
        r = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {


        scores = Player.coin.ToString();// lay diem so ve xau string
        if(index<scores.Length)
        {
            
            for (int i =0;i<scores.Length;i++)// so sanh de lay anh hien thi so diem tuong ung
            {
                foreach (Sprite s in sp)
                {
                    if (s.name == scores[scores.Length-1-index].ToString())
                    {
                        r.sprite = s;
                        
                    }
                }
            }
        }
        



	}
}
