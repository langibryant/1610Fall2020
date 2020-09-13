using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        score++;
        print("Score: " + score);
    }
}
