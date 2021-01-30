using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    //variables 
    public Vector2 cameraChange;//how much camera moves
    public Vector3 playerChange; //how much player moves 
    private CameraMovemet cam; //references CameraMovement script label = cam

    // Start is called before the first frame update
    void Start()
    {
       cam = Camera.main.GetComponent<CameraMovemet>();//gets camera movement script 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){//function to trigger on collision 
        if (collision.CompareTag("Player")) {//checking to see if the Player tag collides
            cam.minPosition += cameraChange;//adds and sets cameraChange to minPosition
            cam.maxPosition += cameraChange;//adds and sets cameraChange to maxPosition
            collision.transform.position += playerChange;  //moves player into new level 
        }

    }
}
