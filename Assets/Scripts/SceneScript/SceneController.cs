using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {

   
    public void LoadScene(string _nextScene)
    {
        Application.LoadLevel(_nextScene);
        Player.coin = 0;
    }
    /*public void reLoadSence(string nextScene)
    {
        Player.speedMeterBg = Player.speedMove * (y2.transform.position.x - y1.transform.position.x) / (x2.transform.position.x - x1.transform.position.x);
        Time.timeScale = 0;
        Player.heath = 3;
        player.GetComponent<BoxCollider2D>().enabled = (true);
        player.GetComponent<MovePlayer>().enabled = (true);// tat chuyen dong luon
        // Animation quay quay roi xuong
        // checkPlayerDiedByScreen();
        //player.GetComponent<Animator>().SetTrigger("Dead");
        //player.GetComponent<Animator>().SetTrigger("");
        Application.LoadLevel(nextScene);

    } */
    public void replay(string _currentSence)
    {
       
        Application.LoadLevel(_currentSence);
        Player.coin = 0;
    }
}
