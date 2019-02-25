﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float timer = 0.5f;
    public GameObject wayPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float j = Input.GetAxis("Horizontal");
        float h = Input.GetAxis("Vertical");
        transform.Translate(j * 10 * Time.deltaTime, 0, h * 10 * Time.deltaTime);

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            //The position of the waypoint will update to the player's position
            UpdatePosition();
            timer = 0.5f;
        }
    }

    void UpdatePosition()
    {
        //The wayPoint's position will now be the player's current position.
        wayPoint.transform.position = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "WallZombie1")
            ZombieVariables.zombie1 = true;
        else if(other.gameObject.name == "WallZombie2")
            ZombieVariables.zombie1 = false;
        else if (other.gameObject.name == "WallZombie3")
            ZombieVariables.zombie2 = true;
        else if (other.gameObject.name == "WallZombie4")
            ZombieVariables.zombie2 = true;
        else if (other.gameObject.name == "WallZombie5")
            ZombieVariables.zombie2 = false;
        else if (other.gameObject.name == "WallZombie6")
            ZombieVariables.zombie3 = true;
        else if (other.gameObject.name == "WallZombie7")
            ZombieVariables.zombie3 = false;
        else if (other.gameObject.name == "WallZombie8")
            ZombieVariables.zombie4 = true;
        else if (other.gameObject.name == "WallZombie9")
            ZombieVariables.zombie4 = false;
    }
}
