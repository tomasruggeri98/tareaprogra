using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnController : MonoBehaviour
{
    public GameObject prefabToSpawn; // El prefab que quieres instanciar
    public float minSpawnInterval = 2.0f; // Intervalo mínimo de tiempo entre spawns
    public float maxSpawnInterval = 5.0f; // Intervalo máximo de tiempo entre spawns

    private void Start()
    {
        // Comienza la corutina de spawn
        StartCoroutine(SpawnObjectsWithRandomInterval());
    }

    // Corutina para el spawn de objetos con intervalos aleatorios
    private IEnumerator SpawnObjectsWithRandomInterval()
    {
        while (true) // Esto crea un loop infinito
        {
            // Calcula un tiempo de espera aleatorio dentro del rango
            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);

            yield return new WaitForSeconds(spawnInterval); // Espera el intervalo aleatorio

            // Instancia el prefab en la posición del SpawnManager
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}


