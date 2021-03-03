using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDie : MonoBehaviour
{
    public int HP;
    public AudioSource dies;

    void Start()
    {
        HP = 3;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == ("Bullet"))
        {
            HP -= 1;
            Destroy(coll.gameObject);
        }
        if (HP <= 0)
        {
            dies.Play();
            Destroy(gameObject);
        }
    }
}

