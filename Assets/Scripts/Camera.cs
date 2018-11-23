﻿/**
 * @author Team FourFour8
 * @file Camera.cs
 * @date 10/2018
 * @brief logic for keeping camera focus
 **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * keeps camera in focus of player
**/ 
public class Camera : MonoBehaviour {
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


    /**
    * used for initialization
    * @pre none
    * @post isShot is true and velocity changes
    * @return void
    **/
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}

    /**
     * update is called once per frame
     * @pre none
     * @post updated frame
     * @return void
     **/
    void Update () {
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);

    }
}
