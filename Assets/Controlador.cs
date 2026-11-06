using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para recarregar a cena

public class controlador : MonoBehaviour
{
    public GameObject painelFim;
    // A função precisa de ser PUBLIC para poder ser chamada por outros scripts
    public void reiniciar()
    {
        // Volta ao menu (cena 0 do Build)
        SceneManager.LoadScene(0);
    }
    public void passou()
    {
        Debug.Log("PASSOU DE NÍVEL");
        painelFim.SetActive(true);
        FindAnyObjectByType<mudarnivel>().carregarproximonivel();
    }
}