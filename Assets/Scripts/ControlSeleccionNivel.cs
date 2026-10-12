
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSeleccionNivel : MonoBehaviour
{

    public void VolverAlMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AbrirNivel1()
    {
        SceneManager.LoadScene("Juego");
    }

    public void AbrirNivel2()
    {
        SceneManager.LoadScene("Juego");
    }
}
