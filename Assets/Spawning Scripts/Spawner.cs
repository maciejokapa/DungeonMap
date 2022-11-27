using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] room;   //talica wszytskich pokoi

    public bool spawn=true;    //spawnować czy nie
	
	void Update () {
        
        if (spawn)
        {
            //if (Random.value > 0.0f)              // możliwa losowość
                int i= Random.Range(0, room.Length-1);
                Instantiate(room[i], transform.position, Quaternion.identity);  //spawnuj przypadkowy pokój z tablicy
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)   //wykrywanie kolizji z innym spawnerem lub z gotowym juz pokojem
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
