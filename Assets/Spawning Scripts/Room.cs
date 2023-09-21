using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    public static int count;          
    public int maxNumOfRooms = 1000;  

    public void Start()
    {
        count++;  
    }

    public void Update()
    {
        if (count >= maxNumOfRooms)
        {
            foreach(Transform child in transform)  
            {
                if (child.CompareTag("Spawner1"))
                {
                    Destroy(child.gameObject);
                }
                
            }

            foreach (Transform child in transform)  
            {
                if (child.CompareTag("Door"))
                {
                    child.gameObject.GetComponent<Door>().Spawn();
                }

            }

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rooms"))
        {
            //Destroy(gameObject);
        }
    }

}
