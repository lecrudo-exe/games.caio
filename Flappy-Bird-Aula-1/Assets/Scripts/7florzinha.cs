using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) // Certifique-se de que o pássaro tem a tag "Player"
        {
            other.GetComponent<Bird>().ActivateSpeedBoost(); // Ativa o boost no script Bird
            Destroy(gameObject); // Destrói o objeto power-up
        }
    }
}
public class PowerUpMovement : MonoBehaviour
{
    public float speed = -2f; // Velocidade negativa para mover-se para a esquerda

    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }
}