using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHP : MonoBehaviour
{

    [SerializeField]
    private GameObject[] Health;

    public AudioSource OOF;
    public int HP = 8;

    void Start()
    {

        for (int i = 0; i <= 8; i++)
        {
            Health[i].gameObject.SetActive(true);
        }

        HP = 8;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == ("EBullet"))
        {
            HP -= 1;
            Destroy(coll.gameObject);

            Health[HP].gameObject.SetActive(false);
        }
        if (coll.gameObject.tag == ("KillClip"))
        {
            HP -= 8;
            Destroy(gameObject);

            Health[HP].gameObject.SetActive(false);
        }
        if (coll.gameObject.tag == ("JohnWick"))
        {
            HP -= 8;
            Destroy(coll.gameObject);
            Health[HP].gameObject.SetActive(false);
        }
        if (HP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}