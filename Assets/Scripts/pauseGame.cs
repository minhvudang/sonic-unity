using UnityEngine;
using System.Collections;

public class pauseGame : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;
    [Header("tergetWingame")]
    public Transform x1, x2;
    [Header("meterBg")]
    public float speedMeterBg;
    public Transform y1, y2;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void pause()
    {
        Time.timeScale = 0.0f;
        gameObject.SetActive(false);

        camera.GetComponent<MovePlayer>().speedCamera = 0;
        Player.speedMove = 0;
        Player.speedMeterBg = 0;

    }
    public void resume()
    {
        Time.timeScale = 1.0f;
        gameObject.SetActive(false);
        camera.GetComponent<MovePlayer>().speedCamera = 0.03f;
        Player.speedMove = 0.03f;
        Player.speedMeterBg = Player.speedMove * (y2.transform.position.x - y1.transform.position.x) / (x2.transform.position.x - x1.transform.position.x);

    }
}
