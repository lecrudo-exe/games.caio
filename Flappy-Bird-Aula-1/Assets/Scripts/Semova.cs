using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMover : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2f;

    private void Update()
    {
        // Move o objeto para a esquerda
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

       
        if (transform.position.x < -20f) 
        {
            Destroy(gameObject);
        }
    }
}