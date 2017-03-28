using UnityEngine;
using System.Collections;

public class LeverReward : MonoBehaviour {

    public Sprite[] sp;   
  
    private SpriteRenderer r;

    private int amountGold;
	// Use this for initialization
	void Start () {
       
        amountGold = Player.gold;
      //  Debug.Log(amountGold);
        if(Player.coin==amountGold&&Player.heath==3)
        {
            setRenderImage("s");
        }
        else if (Player.coin == amountGold || Player.heath == 3)
                  {
                   setRenderImage("a");
                  }
              else if (Player.heath == 2&& (Player.coin>amountGold/2))
                     {
                          setRenderImage("b");
                     }
                    else if(Player.heath==2)
                         {
                            setRenderImage("c");
                         }
                            else
                                {setRenderImage("d");  }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    private void setRenderImage(string name)
    {
        r = GetComponent<SpriteRenderer>();
        foreach(Sprite s in sp)
        {
            if(s.name==name)
            {
                r.sprite = s;
            }
        }
    }
}
