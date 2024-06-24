using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;
    private float velocidadeNormal;
    private float velocidadeBoost = 6;
    private float boostDuration = 5f;

    private bool isIntangible = false;

    private Rigidbody2D fisica;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
        velocidadeNormal = velocidade;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        fisica.velocity = Vector2.up * velocidade;
    }

    public void ActivateSpeedBoost()
    {
        Debug.Log("Ativando Speed Boost");
        velocidade = velocidadeBoost;
        Invoke("ResetSpeed", boostDuration); 
    }

    private void ResetSpeed()
    {
        Debug.Log("Resetando Velocidade");
        velocidade = velocidadeNormal;
    }

    public void ActivateIntangibility()
    {
        Debug.Log("Ativando Intangibilidade");
        isIntangible = true;
        gameObject.layer = LayerMask.NameToLayer("Intangible");
        Invoke("DeactivateIntangibility", boostDuration);
    }

    private void DeactivateIntangibility()
    {
        Debug.Log("Desativando Intangibilidade");
        isIntangible = false;
        gameObject.layer = LayerMask.NameToLayer("Player"); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isIntangible)
        {
            Debug.Log("Colisão Detectada. Jogo Terminado.");
            Time.timeScale = 0;
        }
    }
}
