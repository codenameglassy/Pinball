using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    [SerializeField] private Transform[] spawnPos;

    [SerializeField] private bool invoke;
    private void Start()
    {
        if (invoke)
        {
            InvokeRepeating("SpawnBalls", 0f, 2f);
            return;
        }
        Instantiate(ball, spawnPos[0].position, Quaternion.identity);

    }
    void SpawnBalls()
    {
        
            int index = Random.Range(0, spawnPos.Length);
            Instantiate(ball, spawnPos[index].position, Quaternion.identity);
  

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Instantiate(ball, spawnPos[0].position, Quaternion.identity);

        }
    }
}
