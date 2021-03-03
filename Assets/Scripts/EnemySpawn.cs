using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public int EnemyCount; 
    public GameObject EnemyPrefab;
    public Vector3 ran;

    // Start is called before the first frame update
    void Start()
    {
        for (int EnemyCount = 0; EnemyCount < 10; EnemyCount++)
        {
            ran.x = Random.Range(-8, 3);
            Instantiate(EnemyPrefab, ran, Quaternion.Euler(0, 0, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
