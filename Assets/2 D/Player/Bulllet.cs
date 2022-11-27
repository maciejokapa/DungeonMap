using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulllet : MonoBehaviour {

    public float speed;

	void Start () {
        Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference = difference.normalized;
        Debug.Log(difference);
        GetComponent<Rigidbody2D>().velocity = difference * speed;
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

        }
    }
}
