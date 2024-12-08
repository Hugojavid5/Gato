using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sierra : MonoBehaviour
{
    // Velocidad de rotación de la sierra (se puede ajustar desde el inspector)
    [SerializeField] float rotationSpeed = -11.0f;

    // Start se llama antes del primer frame de la escena
    void Start()
    {
        // Actualmente no realiza ninguna acción en este método
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Actualmente no realiza ninguna acción en este método
    }

    // FixedUpdate se llama en intervalos fijos y se utiliza para las físicas
    private void FixedUpdate()
    {
        // Rota la sierra en el eje Z a la velocidad especificada
        transform.Rotate(0, 0, rotationSpeed);
    }

    // Detecta colisiones con otros objetos que tienen un Collider2D
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si la sierra colisiona con un objeto etiquetado como "Player"
        if (collision.gameObject.tag == "Player")
        {
            // Destruye el objeto del jugador
            Destroy(collision.gameObject); 
            
            // Llama al método GameOver() desde el GameManager para terminar el juego
            GameManager.Instance.GameOver(); 
        }

        // Si la sierra colisiona con un objeto etiquetado como "suelo"
        if (collision.gameObject.tag == "suelo")
        {
            // Destruye la sierra
            Destroy(gameObject);
            
            // Incrementa la puntuación en 1 usando el GameManager
            GameManager.Instance.IncrementaPuntuacion(1);
        }
    }
}
