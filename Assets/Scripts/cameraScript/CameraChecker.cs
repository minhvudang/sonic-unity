using UnityEngine;
using System.Collections;

public class CameraChecker : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        EnboundScreen();
	
	}
    private void EnboundScreen()
    {
        Vector3 currentPosition=gameObject.transform.position;// kiem tra vi tri player

        Camera mCamera = Camera.main;

        float xMin, xMax,yMax,yMin;
        xMin = mCamera.transform.position.x-(mCamera.GetComponent<Camera>().orthographicSize*mCamera.GetComponent<Camera>().aspect);// tinh duoc x va y cua camera
        xMax = mCamera.transform.position.x + (mCamera.GetComponent<Camera>().orthographicSize*mCamera.GetComponent<Camera>().aspect);
        yMax = mCamera.GetComponent<Camera>().orthographicSize;
        yMin = -yMax;
       // Debug.Log(xMin);
       // Debug.Log(xMax);
        if(currentPosition.x<xMin||currentPosition.y<yMin)
        {
           // Debug.Log("dead");
            Player.setDead(gameObject);

            mCamera.GetComponent<Camera>().GetComponent<MovePlayer>().enabled=false;// bo di component trong camera
            //Time.timeScale = 0;
        }
        
    }
}
