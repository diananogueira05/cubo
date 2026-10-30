using UnityEngine;

public class FimDoNivel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Nível terminado!");
        }
    }
}
