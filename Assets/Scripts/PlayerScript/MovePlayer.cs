using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	public float speedCamera;

	public bool isCamera;
	public bool isPlayer;
    public bool isMeter;

	// Use this for initialization
	void Update () {
		if (isCamera) 
		{
			gameObject.transform.Translate(new Vector3(speedCamera,0,0));	
		}
		if (isPlayer) 
		{
			gameObject.transform.Translate(new Vector3(Player.speedMove,0,0));
		}
        if(isMeter)
        {
            gameObject.transform.Translate(new Vector3(Player.speedMeterBg, 0, 0));
        }
	}
}
