/**
 * @author Team FourFour8
 * @file Weapon.cs
 * @date 10/2018
 * @brief defines weapon and its uses
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * weapon that shoots bullet objects
**/
public class Weapon : MonoBehaviour {

    public Transform fireStart;
    public GameObject bulletPrep;


    /**
     * update is called once per frame
     * @pre none
     * @post updated frame
     * @return void
     **/
    void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
	}
    /**
     * called on user interaction to shoot
     * @pre none
     * @post bullet is fired
     * @return void
     **/
    void Shoot()
    {
        Instantiate(bulletPrep, fireStart.position, fireStart.rotation);
    }
}
