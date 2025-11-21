using UnityEngine;
using UnityEngine.SceneManagement; // IMPORTANTE: Necesario para cambiar de escena

public class MenuController : MonoBehaviour
{
    // Función para ir al Nivel 1
    public void CargarNivel1()
    {
        // Asegúrate de que tu escena se llame EXACTAMENTE "Level1"
        SceneManager.LoadScene("Level 1");
    }

    // Función para ir al Nivel 2
    public void CargarNivel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    // Función para Salir del juego
    public void SalirDelJuego()
    {
        Debug.Log("Saliendo del juego..."); // Esto solo se ve en el editor de Unity
        Application.Quit();
    }
}