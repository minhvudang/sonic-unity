using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerOntrigger : MonoBehaviour {

	//[Header("Gold")]
	//public Text txtScore;
    public GameObject player;
    public GameObject fatherHealth;
   // public GameObject coins;
   // public GameObject bgmusic;

    public AudioSource coinSound;
    public AudioSource monsterSound;
    public AudioSource c4rSound;



    void Update()
    {
    }
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.transform.tag == "Gold")
		{
            Player.coin++;
            //coins.SetActive(true);
            //bgmusic.SetActive(true);
			Destroy(other.gameObject);
            // Debug.Log("coins");


            coinSound.Play();
             
            
		}
      
        if (other.gameObject.transform.tag == "Monster")
        {
          
           // Debug.Log("Monster");         
            Player.heath--;
            monsterSound.Play();
           // Debug.Log(Player.heath);
            // code de xoa trai tim
            if(fatherHealth.transform.GetChildCount()>0)
            {
                Destroy(fatherHealth.transform.GetChild(0).gameObject);
            }

           
        }
        if (other.gameObject.transform.tag == "c4")
        {

            // Debug.Log("Monster");         
            Player.heath--;
            c4rSound.Play();
            // Debug.Log(Player.heath);
            // code de xoa trai tim
            if (fatherHealth.transform.GetChildCount() > 0)
            {
                Destroy(fatherHealth.transform.GetChild(0).gameObject);
            }


        }
    }
}
