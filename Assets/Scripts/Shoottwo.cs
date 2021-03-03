using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoottwo : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Bull;

    public GameObject BulletPrefab;
    public bool Fire;
    public AudioSource shot;
    public int ammo;
    public bool empty;

    void Start()
    {
        for (int i = 0; i <= 0; i++)
        {
            Bull[i].gameObject.SetActive(false);
        }
        ammo = 8;
        Fire = false;
    }

    void Update()
    {
        if (ammo != 0)
        {
            if (Fire == false && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Fire = true;
                return;
            }

            if (Fire == true && Input.GetKeyDown(KeyCode.Mouse0) && empty == false)
            {
                Instantiate(BulletPrefab, transform.position, transform.rotation);
                shot.Play();
                ammo -= 1;
                Fire = false;
                Bull[ammo].gameObject.SetActive(false);
                return;
            }
        }

        if (empty == true && Input.GetKeyDown(KeyCode.R))
        {
            ammo = 7;

            for (int i = 0; i <= 6; i++)
            {
                Bull[i].gameObject.SetActive(true);
            }
            Fire = false;
            return;
        }

        if (ammo == 0)
        {
            empty = true;
        }
        else
        {
            empty = false;
        }
        if (empty == false && Input.GetKeyDown(KeyCode.R))
        {
            ammo = 8;
            for (int i = 0; i <= 7; i++)
            {
                Bull[i].gameObject.SetActive(true);
            }
            Fire = false;
        }
    }
}