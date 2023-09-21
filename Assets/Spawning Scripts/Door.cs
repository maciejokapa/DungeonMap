using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


    public bool isColliding = false; 
    public GameObject finalDoor;     
    public Transform parentRoom;     
    public LayerMask whatIsDoor;    

    public void Spawn()
    {
        isColliding = Physics2D.IsTouchingLayers(GetComponent<Collider2D>(), whatIsDoor);  
        Invoke("DestroyDoor", 1);      
    }

    public void DestroyDoor () 
    {
        if (!isColliding)
        {
            Instantiate(finalDoor, transform.position, transform.rotation, parentRoom);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
