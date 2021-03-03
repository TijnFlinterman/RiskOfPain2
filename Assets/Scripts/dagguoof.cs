using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dagguoof : MonoBehaviour
{
    public AudioSource dies;
    public bool Dead;
    public bool die;
    private void Update()
    {
        if (Dead == true)
        {
            Debug.Log("Oofed");
            GameObject.FindWithTag("ThickBoi").GetComponent<JohnThicc>().IsShot = true;
            die = true;
        }
        if (die == true)
        {
            dies.Play();
            Destroy(gameObject);
            Debug.Log("DogDied");
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == ("Bullet"))
        {
            Dead = true;
            
        }
    }
}