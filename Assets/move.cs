using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class move : MonoBehaviour
{
    public Rigidbody coiso;

    public TMP_Text textoVidas;
    public TMP_Text textoMoedas;

    public AudioSource audioSource;
    public AudioClip somMoeda;
    public AudioClip somBarreira;

    void Update()
    {
        coiso.AddForce(0, 0, 1);

        if (Keyboard.current.leftArrowKey.isPressed)
        {
            coiso.AddForce(-8, 0, 0);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            coiso.AddForce(8, 0, 0);
        }

         if (transform.position.y < -5f)
        {
            FindAnyObjectByType<controlador>().reiniciar();
        }
    }

    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.CompareTag("Barreiras"))
        {
            textoVidas.text = (int.Parse(textoVidas.text) - 1).ToString();
            audioSource.PlayOneShot(somBarreira);
        }

        if (int.Parse(textoVidas.text) <= 0)
            {
                FindAnyObjectByType<controlador>().reiniciar();
            }
    }

    private void OnTriggerEnter(Collider colisao)
    {
        if (colisao.gameObject.CompareTag("moedas"))
        {
            textoMoedas.text = (int.Parse(textoMoedas.text) + 10).ToString();
            audioSource.PlayOneShot(somMoeda);
            Destroy(colisao.gameObject);
        }
    }
}