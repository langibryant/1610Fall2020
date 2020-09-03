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
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, z);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }

    public void down()
    {
        transform.Translate(0, -speed, 0);
    }
}
