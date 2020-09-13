using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    private void OnTriggerEnter(Collider other)
    {
        health++;
        print("Health: " + health);
    }
}
