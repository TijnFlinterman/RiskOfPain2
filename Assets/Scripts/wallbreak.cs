using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallbreak : MonoBehaviour
{
    public AudioSource Speak;

    void Update()
    {
        if(GameObject.FindWithTag("ThickBoi").GetComponent<JohnThicc>().IsShot == true)
        {
            Speak.Play();
            Debug.Log("Audio");
            Destroy(gameObject);
        }
    }
}
