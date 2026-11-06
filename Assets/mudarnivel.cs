using UnityEngine;
using UnityEngine.SceneManagement;

public class mudarnivel : MonoBehaviour
{
    public void carregarproximonivel()
    {
        int proxima = SceneManager.GetActiveScene().buildIndex + 1;

        // Se não houver mais níveis, volta ao menu
        if (proxima >= SceneManager.sceneCountInBuildSettings)
        {
            proxima = 0;
        }

        SceneManager.LoadScene(proxima);
    }
}