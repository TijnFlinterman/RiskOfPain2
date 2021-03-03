using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnHealth : MonoBehaviour
{
    public int Health;
    public AudioSource dies;

    void Start()
    {
        Health = 10;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == ("Bullet"))
        {
            Health -= 1;
            Destroy(coll.gameObject);
        }
        if (Health <= 0)
        {
            dies.Play();
            Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == ("Player"))
        {
            Destroy(coll.gameObject);
        }
    }
}
