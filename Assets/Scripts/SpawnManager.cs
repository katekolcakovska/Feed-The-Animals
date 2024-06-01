using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); 
        //vo navodnicite ppisuvame imeto na funkcijata koja sakame da se izvrsuva na odreden interval
        //startDelay deka pocnuva na 2rata sekunda od koa ke pocne igrata
        //spawnInterval na koj interval od sekundi se povtoruva funkcijata
    }

    // Update is called once per frame
    void Update()
    {
        /*        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal(); //vaka ja povikuvame funkcijata
        }*/
    }

    void SpawnRandomAnimal() //VOID funkcii ne vrakjaat vrednost, samo go izvrsuvaat kodot
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), 0, 20);
        int animalIndex = Random.Range(0, animalPrefabs.Length); // (0, 2) 0 - minimalnata vrednost do 2 - maksimalnata vrednost, ako ne ja znaeeme dolzinata na nizata (0, animalPrefabs.Length)
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
