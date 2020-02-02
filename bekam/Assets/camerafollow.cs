using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public float Movespeed;
    bool isgrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        Movespeed = 5f;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * Movespeed;

    }
}
