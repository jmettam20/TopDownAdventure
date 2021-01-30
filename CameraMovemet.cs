using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovemet : MonoBehaviour{
    public Transform target;//what the camera is following
    public float smoothing; //hows smooth the follow movement is
    public Vector2 maxPosition; //maximum position of camera 
    public Vector2 minPosition;//minimum position of camera 

    // Start is called before the first frame update
    void Start()  {
        
    }

    // Update is called once per frame
    void LateUpdate()  {//follows the target
        if (transform.position != target.position) {
            Vector3 targetPosition = new Vector3(target.position.x,target.position.y,transform.position.z);//create target position 
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);//clamp stops camera moving out of min/max position on x axis
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y);//clamp stops camera moving out of min/max position on y axis


            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing); //moves camera from where it is to were it should be
        }//follow target 
    }
}
