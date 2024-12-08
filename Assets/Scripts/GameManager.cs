using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    bool gameOver = false;

    [SerializeField] public Text marcador;  // Texto que muestra la puntuación
    [SerializeField] private GameObject gameOverMenu;  // El panel con los botones de Reiniciar y Salir
    [SerializeField] private Button reintentarButton;  // Botón de reiniciar
    [SerializeField] private Button menuButton;  // Botón de volver al menú

    private int puntuacion = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Método que se llama cuando el jugador muere
    public void GameOver()
    {
        gameOver = true;
        
        // Detenemos el generador de objetos (o cualquier objeto generador en tu juego)
        GameObject.Find("GeneradorSierras").GetComponent<GeneradorSierras>().StopSpawning();

        // Mostrar el panel de game over
        gameOverMenu.SetActive(true);

        // Pausar el juego
        Time.timeScale = 0f;

        print("Has muerto");
    }

    // Método para incrementar la puntuación
    public void IncrementaPuntuacion(int puntos)
    {
        if (!gameOver)
        {
            puntuacion += puntos;
            print("Tu puntuación es: " + puntuacion);
            marcador.text = puntuacion.ToString();  // Actualiza el marcador
        }
    }

    // Método para reiniciar el juego
    public void Reintentar()
    {
        Time.timeScale = 1f;  // Reanuda el juego
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  // Recarga la escena actual
    }

    // Método para volver al menú principal
    public void VolverAlMenu()
    {
        Time.timeScale = 1f;  // Reanuda el juego
        SceneManager.LoadScene("Menu");  // Carga la escena del menú (asegúrate de que el nombre sea correcto)
    }

    // Start se llama antes de la primera actualización
    void Start()
    {
        // Desactivar el panel de game over al inicio
        gameOverMenu.SetActive(false);

        // Asignar los eventos de los botones
        reintentarButton.onClick.AddListener(Reintentar);
        menuButton.onClick.AddListener(VolverAlMenu);
    }

    void Update()
    {
        // Aquí podrías poner alguna lógica adicional si fuera necesario
    }
}
