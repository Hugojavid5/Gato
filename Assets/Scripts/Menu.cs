using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("SampleScene");
    }
     public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Juego cerrado."); //Muestra el mensaje en consola
}

