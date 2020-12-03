using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pillarPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPillar", 2,2);
    }

    // SpawnPipes at 2 second intervals
    void SpawnPillar()
    {
        //Only spawn if game is not over
        if(!GameManager.Instance.gameOver)
            Instantiate(pillarPrefab, new Vector3(pillarPrefab.transform.position.x, pillarPrefab.transform.position.y + Random.Range(-2.5f,2.5f), pillarPrefab.transform.position.z), Quaternion.identity);
    }
}
