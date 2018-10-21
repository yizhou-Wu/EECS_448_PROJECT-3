using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimies_Status : MonoBehaviour {

    public int health = 100;
    public GameObject deathEffect;

	public void TakeDmg(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }
}
