using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletTravel : MonoBehaviour
{
    public float bulletSpeed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, bulletSpeed, 0);
    }
}
