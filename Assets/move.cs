using System;
using UnityEngine;
using UnityEngine.InputSystem;
 

public class move : MonoBehaviour
{
    public Rigidbody coiso;
   
    // Update is called once per frame
    void Update()
    {
        coiso.AddForce(0, 0, 2);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            coiso.AddForce(-4, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            coiso.AddForce(4, 0, 0);
        }
        
    }
    private void OnCollisionEnter(Collision colisao)
     {
        if(colisao.gameObject.tag =="Barreiras")
        {
            Debug.Log("bateu");
        }
     }
    private void OnTriggerEnter(Collision colisao)
     {
        if(colisao.gameObject.tag =="moedas")
        {
            Debug.Log("passou");
        }
     }
}