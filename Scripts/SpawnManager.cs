using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclesList;
    private float[] spawnPoints = { 5.3f, 7.55f, 10.3f };
    private int randomObstacle, randomSpawn;
    private float startDelay = 1f, repeatRate = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //Invoca el primero y luego otro cada 2 sec
        InvokeRepeating("spawnObstacles", startDelay, repeatRate);
    }

    void spawnObstacles()
    {
        //Elije un obstaculo y una Posición donde spawear al azar
        randomObstacle = Random.Range(0, obstaclesList.Length);
        randomSpawn = Random.Range(0, spawnPoints.Length);

        //Crea una copia del prefab y lo invoca
        Instantiate(obstaclesList[randomObstacle], new Vector3(spawnPoints[randomSpawn], 0f, 18.5f), obstaclesList[randomObstacle].transform.rotation);
    }
}
