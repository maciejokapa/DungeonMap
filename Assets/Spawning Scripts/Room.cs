using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour {

    public static int count;          //licznik drzwi
    public int maxNumOfRooms = 1000;  //max liczba drzwi

    public void Start()
    {
        count++;  //licz drzwi
    }

    public void Update()
    {
        if (count >= maxNumOfRooms)
        {
            foreach(Transform child in transform)  //niszczenie spawnerów
            {
                if (child.CompareTag("Spawner1"))
                {
                    Destroy(child.gameObject);
                }
                
            }

            foreach (Transform child in transform)  //stawianie drzwi
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
