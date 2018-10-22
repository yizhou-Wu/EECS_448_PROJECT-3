using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 20f;
    public Rigidbody2D temp;
    public int damage = 50;
    private int frame = 0;
    private bool isShot;
	// Use this for initialization
	void Start () {
        temp.velocity = transform.right * speed;
        isShot = true;
	}

    void Update()
    {
        if (frame < 45)
        {
            Debug.Log("Frame: " + frame);
            frame++;
        }
        else
        {
            frame = 0;
            isShot = false;
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Enimies_Status enemy = collision.GetComponent<Enimies_Status>();
        if(enemy != null)
        {
            enemy.TakeDmg(damage);
        }
        Destroy(gameObject);

    }
}
