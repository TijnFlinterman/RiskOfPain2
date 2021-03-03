using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JohnThicc : MonoBehaviour
{
    public float timer;
    public bool ON;
    public GameObject Bullet;
    public float FireRate = 45;
    public float Aiming;
    public float Left1;
    public float Right1;
    public bool CanFire;
    public int Wait;
    public bool IsShot;
    public bool alreadyPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = FireRate;
        ON = true;
        CanFire = false;
        IsShot = false;
    }

    private void Update()
    {
        if (IsShot == true)
        {
            Wait--;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (Wait <= 0)
        {
            CanFire = true;
        }
        if (CanFire == true)
        {
            if (ON == true)
            {
                timer--;
            }
            if (timer <= 0)
            {
                ON = false;
                Instantiate(Bullet, transform.position, transform.rotation);
                timer = FireRate;
                Aiming = Random.Range(Left1, Right1);
            }
            if (timer == FireRate)
            {
                ON = true;
            }
            Vector3 to = new Vector3(0, 0, Aiming);
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Aiming);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
             Destroy(gameObject);
            Destroy(this);
        }
    }
}
