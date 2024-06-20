using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 3;
    private float velocidadeNormal;
    private float velocidadeBoost = 6; // Velocidade dobrada
    private float boostDuration = 5f; // Duração do power-up em segundos

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

    public void ActivateSpeedBoost()
    {
        velocidade = velocidadeBoost; // Aumenta a velocidade
        Invoke("ResetSpeed", boostDuration); // Agenda a chamada para resetar a velocidade
    }

    private void ResetSpeed()
    {
        velocidade = velocidadeNormal;
    }
}
