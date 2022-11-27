using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float speed;

    public GameObject shootPos;
    public GameObject bullet;

    void FixedUpdate () {
        // rotacja do kursora
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotZ -90);


        // ruch
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))*speed*Time.fixedDeltaTime;


        // strzał
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, shootPos.transform.position, shootPos.transform.rotation);
        }

        Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, target, cameraSpeed*Time.fixedDeltaTime);
    }

    public float cameraSpeed;
    private Vector3 target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        target = new Vector3(collision.transform.position.x, collision.transform.position.y, -10);
    }
}
