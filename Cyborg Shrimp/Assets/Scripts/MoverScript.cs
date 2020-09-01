using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float x, y, z;
    public float speed = 3f;
    void Start()
    {
        Debug.Log("Hello World");   
    }

    // Update is called once per frame
    void Update()
    {
        x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        y = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(x, y, z);
    }
}
