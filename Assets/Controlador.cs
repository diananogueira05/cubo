using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para recarregar a cena

public class controlador : MonoBehaviour
{
    // A função precisa de ser PUBLIC para poder ser chamada por outros scripts
    public void reiniciar()
    {
        // Recarrega a cena ativa no momento
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}