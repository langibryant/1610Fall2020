using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 3f;
    public Vector3 moveDirection;
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            moveDirection.x = moveSpeed * Time.deltaTime;
        }
        else
        {
            moveDirection.x = -moveSpeed * Time.deltaTime;
        }
        transform.Translate(moveDirection);

    }
}
