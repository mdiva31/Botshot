using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    public int n;
    public int wait;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }
    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(wait);
        for (int i = 0; i < n; i++){
            Instantiate(balloons[i], spawnPoints[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
