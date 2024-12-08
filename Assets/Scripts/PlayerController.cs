using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Referencia al componente Rigidbody2D del objeto del jugador
    Rigidbody2D rbGatete;
    
    // Referencia al componente SpriteRenderer del objeto del jugador
    SpriteRenderer srGatete;
    
    // Velocidad de movimiento del jugador
    private float velocidad = 5f;

    // Método que se llama antes de que el script inicie
    private void Awake()
    {
        // Inicializa la referencia al Rigidbody2D
        rbGatete = GetComponent<Rigidbody2D>();
        
        // Inicializa la referencia al SpriteRenderer
        srGatete = GetComponent<SpriteRenderer>();
    }

    // Método que se llama a intervalos fijos y se usa para física
    private void FixedUpdate()
    {
        // Comprueba si se ha hecho clic con el botón izquierdo del ratón
        if (Input.GetMouseButton(0))
        {
            // Si el clic es en la mitad izquierda de la pantalla
            if (Input.mousePosition.x < Screen.width / 2)
            {
                // Imprime un mensaje en la consola y mueve el jugador hacia la izquierda
                print("De la mitad a la izquierda");
                Debug.Log("Izquierda desde log");
                rbGatete.velocity = Vector2.left * velocidad;
            }
            
            // Si el clic es en la mitad derecha de la pantalla
            if (Input.mousePosition.x > Screen.width / 2)
            {
                // Imprime un mensaje en la consola y mueve el jugador hacia la derecha
                print("De la mitad a la derecha");
                Debug.Log("Derecha desde log");
                rbGatete.velocity = Vector2.right * velocidad;
            }
        }
    }

    // Start se llama antes del primer frame de la escena
    void Start()
    {
        // Por ahora, no se realiza ninguna acción aquí
    }

    // Update se llama una vez por frame
    void Update()
    {
        // Por ahora, no se realiza ninguna acción aquí
    }
}
