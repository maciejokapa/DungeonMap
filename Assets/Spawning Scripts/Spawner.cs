using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] room;  

    public bool spawn=true;    
	
	void Update () {
        
        if (spawn)
        {
            //if (Random.value > 0.0f)            
                int i= Random.Range(0, room.Length-1);
                Instantiate(room[i], transform.position, Quaternion.identity);  
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)   
    {
        if (collision.gameObject.CompareTag("Rooms"))
        {
            spawn = false;
        }
        else if (collision.gameObject.CompareTag("Spawner1"))
        {
            spawn = false;
        }
    }
}
