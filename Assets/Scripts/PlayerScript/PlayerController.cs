using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public bool statusJump;	//Refernce status jump of player
	public int numberJump = 0;

    [Header("jump sound")]
    public AudioSource jumpSound;
 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		inputController();
        /*
        if (statusJump)
        {
            gameObject.GetComponent<Animator>().SetTrigger("Jump");
            
        }
        else
        {
            gameObject.GetComponent<Animator>().SetTrigger("Run");

        }
        */
        
	}

	//Refence input controller
	private void inputController()
	{
		if(Input.GetMouseButtonDown(0))
		{
			if(numberJump < 1)
			{
				statusJump = true;
				setJump(statusJump);
                gameObject.GetComponent<Animator>().SetTrigger("Jump");
               // Debug.Log("dkm sao lai nhay?");
            }
            else
            {
                if (0 < numberJump &&numberJump<2)
                {
                    statusJump = true;
                    setJump(statusJump);
                    gameObject.GetComponent<Animator>().SetTrigger("Jump2");
                 //   Debug.Log("dkm sao lai nhay lan 2?");
                }
                else
                {
                    statusJump = false;
                }
            }
		}
	}

	//Refence funtion jump
	private void setJump(bool status)
	{
		if(status)
		{
			//Debug.Log("Jump");
			gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, Player.speedJump);
            //gameObject.transform.Translate(new Vector3(0, Player.speedJump, 0)*Time.deltaTime);
            numberJump++;
         //   Debug.Log("Jump: "+numberJump);
            // am thanh nhay o day
            jumpSound.Play();

		}
	}

	void OnCollisionEnter2D(Collision2D target)
	{
		if(target.gameObject.transform.tag == "Land")
		{
			numberJump = 0;
            statusJump = false;
            gameObject.GetComponent<Animator>().SetTrigger("Run");
           // Debug.Log("dm da cham dat roi ma: " + statusJump);
        }
	}
}
