using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorSierras : MonoBehaviour
{    
    [SerializeField]
    public GameObject obstaculo;
       [SerializeField] 
       public GameObject coche;
    public float velocidadCreacion;
    private float minimoX = -2f;
    private float maximoX = 2f;
    // Start is called before the first frame update
     void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // spawnea entre el max y el min de x
    void Spawn()
    {
        float randomX = Random.Range(minimoX, maximoX);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(obstaculo, spawnPos, Quaternion.identity);
    } 
     // spawnea entre el max y el min de x
    void SpawnCoche()
    {
        float randomX = Random.Range(minimoX, maximoX);
        Vector2 spawnPos = new Vector2(randomX, transform.position.y);
        Instantiate(coche, spawnPos, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("Spawn", 1f, velocidadCreacion);
        InvokeRepeating("SpawnCoche", 1f, velocidadCreacion);
    }
     public void StopSpawning()
    {
        CancelInvoke("Spawn");
          CancelInvoke("SpawnCoche");
    }
}