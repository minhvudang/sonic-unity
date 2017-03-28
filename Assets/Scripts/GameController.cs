using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	[Header("Player")]
	public float speedMove;
	public float speedJump;
	//public Text score;
    public GameObject player;
    public GameObject panelGameover;
    public int health;
    public GameObject fatherHealth;

    [Header("Monster")]
    public float speedMonster;
    [Header("tergetWingame")]
    public Transform x1,x2;
    public GameObject panelWinGame;
    public GameObject fire;
    public GameObject scoreWin;

    [Header("meterBg")]
    public float speedMeterBg;
    public Transform y1, y2;

    [Header("groupGold")]
    public GameObject groupGold;

    [Header("dead sound")]
    public AudioSource deadSound;

    public bool checkwin=false;


    public string name_level;
    // Use this for initialization
    void Awake() {// se chay truoc start() muc dich de monstermove goi speedmonster ra khac 0
		Player.speedJump = speedJump;
		Player.speedMove = speedMove;
       
        Player.heath = health;
        Player.speedMonster = speedMonster;
        Player.gold = groupGold.transform.childCount;
       
	}
    void Start()
    {
        Player.speedMeterBg = Player.speedMove * (y2.transform.position.x - y1.transform.position.x) / (x2.transform.position.x - x1.transform.position.x);
    }
	void Update()
	{
		//Player
		//score.text = Player.coin.ToString ();
        if (!checkwin) { checkPlayerDiedByScreen(); }
        
        checkWinGame();

        if (player != null) { checkPlayerDiedByMonster(); }
	}
    private void checkPlayerDiedByScreen()// khi nao khong con player thi pausegame
    {
        Camera mcamera = Camera.main;
        if (player != null)
        {
            if ((mcamera.transform.position.x - player.transform.position.x) > 4.5f)
            {
              //  Debug.Log(mcamera.transform.position.x - player.transform.position.x);
                deadSound.Play();
                panelGameover.SetActive(true);
                Player.speedMove = 0;// set che do cho panel hien len
                Player.speedMeterBg = 0;
            }
        }
        if (player == null)
        {
            // Player.speedMeterBg = 0;
            // tma thoi chua xu li dc nen chi de pause game thoi
            // Time.timeScale = 0.0f;
            deadSound.Play();
            panelGameover.SetActive(true);
            Player.speedMove = 0;// set che do cho panel hien len
            Player.speedMeterBg = 0;
           // checkwin = true;


            //Player.heath = 0;


            // xoa mot phat het 3 trai tim
            /*
             if (Player.heath == 0)
             {
                 for (int i = 0; i < fatherHealth.transform.GetChildCount(); i++)
                 {

                     Destroy(fatherHealth.transform.GetChild(i).gameObject);


                     // am thanh chet o day
                     deadSound.Play();
                 }
             }
             */

        }
    }
    private void checkPlayerDiedByMonster()
    {

        if (Player.heath == 0)
        {
           /*
            player.GetComponent<BoxCollider2D>().enabled = (false);
            player.GetComponent<MovePlayer>().enabled = (false);// tat chuyen dong luon
            // Animation quay quay roi xuong
            checkPlayerDiedByScreen();
            player.GetComponent<Animator>().SetTrigger("Dead");
            Player.speedMeterBg = 0;
            // am thanh chet o day
            deadSound.Play();
            */
            deadSound.Play();
            player.GetComponent<Animator>().SetTrigger("Dead");
            Debug.Log("die by monster");
            panelGameover.SetActive(true);
            Player.speedMove = 0;// set che do cho panel hien len
            Player.speedMeterBg = 0;

            // Time.timeScale = 0.0f;// pause game

        }
    }
    private void checkWinGame()// check wwin game
    {
        Camera mcamera = Camera.main;
        if(mcamera.transform.position.x>x2.transform.position.x)
        {
            //Debug.Log("Win");
            /*
            mcamera.GetComponent<MovePlayer>().speedCamera = 0;
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
            Invoke("displayPanelWingame", 1.5f);
           */
            //Time.timeScale = 0;
            PlayerPrefs.SetInt(name_level, 1);
            Invoke("displayPanelWingame", 1f);
            checkwin = true;
        }
    }

    // set active ve true
    private void displayPanelWingame()
    {
        panelWinGame.SetActive(true);
        fire.SetActive(true);
        Player.speedMove = 0.01f;
        Player.speedMeterBg = 0;

        //panelGameover.SetActive(false);
        //scoreWin.SetActive(true);
        //Player.speedMeterBg = 0;
    }
    public void reloadTimeScale()
    {
        Time.timeScale = 1.0f;
        Player.speedMove = speedMove;
      
    }
    
}
