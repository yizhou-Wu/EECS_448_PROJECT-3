using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimies_Movement : MonoBehaviour {

    public int Speed;
    public int Direction;
    private bool Efreeze;
	
	// Update is called once per frame
	void Update () {
        if(Efreeze == false)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(Direction, 0));
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(Direction, 0) * Speed;
            if (hit.distance < 0.7f)
            {
                Flip();
            }
        }
        else
        {
            Debug.Log("Freeze");
        }
        
	}

    void Flip()
    {
        if(Direction > 0)
        {
            Direction = -1;
        }
        else
        {
            Direction = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            Efreeze = true;
        }
    }
}
