using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Transform fireStart;
    public GameObject bulletPrep;
	
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        Instantiate(bulletPrep, fireStart.position, fireStart.rotation);
    }
}
