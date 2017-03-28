using UnityEngine;
using System.Collections;

public class MonsterMove : MonoBehaviour {

    public Transform x1, x2;
    private Vector3 currentPosition;
    private Quaternion currentRotation;
    private Player monster= new Player();// tao doi tuong moi cho monster
    public GameObject monsterDie;
    public AudioSource monsterDestroySound;
    // Use this for initialization
    void Start () {
        monster.SpeedMonster = Player.speedMonster;
	}
	
	// Update is called once per frame
	void Update () {
        currentPosition = gameObject.transform.position;
        currentRotation = gameObject.transform.rotation;
        //Debug.Log(currentRotation.z);
        if (currentPosition.x < x1.position.x)
        {
           // Player.speedMonster = Player.speedMonster * (-1);
            monster.SpeedMonster = monster.SpeedMonster * (-1);
            currentRotation.y = 180;
            //   Debug.Log(currentRotation.y);
            gameObject.transform.rotation = new Quaternion(0, 90.0f, 0, 0);
           // Debug.Log(gameObject.transform.rotation);
        }
        if (currentPosition.x > x2.position.x)
        {
            //Player.speedMonster = Player.speedMonster * (-1);
            monster.SpeedMonster = monster.SpeedMonster * (-1);
            currentRotation.y =0;// quay dau nguoc lai
                                 //  Debug.Log(currentRotation.y);
            gameObject.transform.rotation = new Quaternion(0,0,0,0);
           // Debug.Log(gameObject.transform.rotation);
        }
           
        gameObject.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(monster.SpeedMonster, 0);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.transform.tag == "Player")
        {
            monsterDie.GetComponent<Animator>().SetTrigger("monsterDie");
            monsterDie.GetComponent<BoxCollider2D>().enabled = (false);
           // monsterDestroySound.Play(1000);
        }
    }
}
