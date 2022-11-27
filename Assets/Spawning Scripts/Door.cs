using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


    public bool isColliding = false; //parametr do postawienia ściany
    public GameObject finalDoor;     //ściana do stworzenia
    public Transform parentRoom;     //poko jako rodzic (można usunąć)
    public LayerMask whatIsDoor;     //wartswa do wykrycia kolizji drzwi z innymi drzwiami

    public void Spawn()
    {
        isColliding = Physics2D.IsTouchingLayers(GetComponent<Collider2D>(), whatIsDoor);  //sprawdź czy zachodzi kolizja
        Invoke("DestroyDoor", 1);      //poczekaj przez to że Room.Update musi przejść po wszytkich drzwiach
    }

    public void DestroyDoor ()  //postaw ścianęi zniszcz cały ten obiekt
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
