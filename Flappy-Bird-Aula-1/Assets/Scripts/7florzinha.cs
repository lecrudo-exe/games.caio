using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3f;  // Certifique-se de que h� um ponto e v�rgula aqui
    private float velocidadeNormal;
    private float velocidadeBoost = 6f; // Certifique-se de que h� um ponto e v�rgula aqui
    private float boostDuration = 5f; // Certifique-se de que h� um ponto e v�rgula aqui

    Rigidbody2D fisica;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
        velocidadeNormal = velocidade; // Armazena a velocidade normal
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
        fisica.AddForce(Vector2.up * velocidade, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            ActivateSpeedBoost();
            Destroy(other.gameObject); // Destr�i o objeto do power-up
        }
    }

    private void ActivateSpeedBoost()
    {
        velocidade = velocidadeBoost; // Aumenta a velocidade
        Invoke("ResetSpeed", boostDuration); // Agenda a chamada para resetar a velocidade
    }

    private void ResetSpeed()
    {
        velocidade = velocidadeNormal;
    }
}
