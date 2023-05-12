using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefab;
    
    private float SpawnX = 10.0f;
    private float SpawnZ = 20.0f;
    private float startDelay = 2;
    private float spawnIterval = 1.5f;

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnIterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnIterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnIterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Randomly genarated enemy Spawn position
        /*if(Input.GetKeyDown(KeyCode.S))
        {
            SpanRandomAnimal();
        }*/
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-SpawnX, SpawnX), 0, SpawnZ);
        int animalIndex = Random.Range(0, AnimalPrefab.Length);

        Instantiate(AnimalPrefab[animalIndex], spawnPosition, AnimalPrefab[animalIndex].transform.rotation); 
    }

    void SpawnLeftAnimal()
    {
        Vector3 spawnPosition = new Vector3(-20, 0, Random.Range(10, 15));
        int animalIndex = Random.Range(0, AnimalPrefab.Length);
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(AnimalPrefab[animalIndex], spawnPosition, Quaternion.Euler(rotation));
    }

    void SpawnRightAnimal()
    {
        Vector3 spawnPosition = new Vector3(20, 0, Random.Range(10, 15));
        int animalIndex = Random.Range(0, AnimalPrefab.Length);
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(AnimalPrefab[animalIndex], spawnPosition, Quaternion.Euler(rotation));
    }
}
