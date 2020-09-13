using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    public int ammo;
    private void OnTriggerEnter(Collider other)
    {
        ammo++;
        print("Ammo: " + ammo);
    }
}
