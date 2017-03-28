using UnityEngine;
using System.Collections;

public class SceneMarker : MonoBehaviour {

    public Sprite[] sp;
    private SpriteRenderer r;

    public int index;// tinh map
	// Use this for initialization
	void Start () {
        r = GetComponent<SpriteRenderer>();

        if(index<Application.loadedLevelName.Length)
        {
            foreach(Sprite s in sp)
            {
                if(s.name==Application.loadedLevelName[Application.loadedLevelName.Length-1-index].ToString())
                {
                    r.sprite = s;
                  //  Debug.Log("lol");
                }
            }
        }

	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
