using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject EBulletPrefab;
    public AudioSource Eshot;
    public int delay = 80;

    void FixedUpdate()
    {
        delay -= 1;
        int ran = Random.Range(1, 100);

        if (ran == 1)
        {

            Instantiate(EBulletPrefab, transform.position, transform.rotation);
            Eshot.Play();
        }
        if (delay == 0)
        {
            Instantiate(EBulletPrefab, transform.position, transform.rotation);
            Eshot.Play();
            delay = 80;
        }
    }
}
