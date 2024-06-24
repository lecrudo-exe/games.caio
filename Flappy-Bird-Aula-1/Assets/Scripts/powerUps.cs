using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerUpType { SpeedBoost, Intangibility }
    public PowerUpType powerUpType;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Bird bird = collision.GetComponent<Bird>();
            if (bird != null)
            {
                switch (powerUpType)
                {
                    case PowerUpType.SpeedBoost:
                        Debug.Log("PowerUp SpeedBoost Coletado");
                        bird.ActivateSpeedBoost();
                        break;
                    case PowerUpType.Intangibility:
                        Debug.Log("PowerUp Intangibility Coletado");
                        bird.ActivateIntangibility();
                        break;
                }
                Destroy(gameObject);
            }
        }
    }
}
