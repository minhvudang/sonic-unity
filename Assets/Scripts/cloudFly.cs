using UnityEngine;
using System.Collections;

public class cloudFly : MonoBehaviour {

    public Transform x1, x2;
    private Vector3 currentPosition;
    private Player clound = new Player();
    // Use this for initialization
    void Start () {
        clound.SpeedMonster = Player.speedMonster*(0.5f);
    }
	
	// Update is called once per frame
	void Update () {
        currentPosition = gameObject.transform.position;
        if (currentPosition.x < x1.position.x)
        {

            clound.SpeedMonster = clound.SpeedMonster * (-1);
        }
        if (currentPosition.x > x2.position.x)
        {

            clound.SpeedMonster = clound.SpeedMonster * (-1);
        }

        gameObject.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(clound.SpeedMonster, 0);
    }
}
