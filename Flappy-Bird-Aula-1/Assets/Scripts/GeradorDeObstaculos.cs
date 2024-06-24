using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour
{
    [SerializeField]
    private GameObject modeloObstaculo;

    [SerializeField]
    private GameObject modeloPowerUp;

    [SerializeField]
    private float tempoParaGerar = 3;
    private float cronometro;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {
            if (modeloObstaculo != null)
            {
                GameObject.Instantiate(this.modeloObstaculo, this.transform.position, Quaternion.identity);
                Debug.Log("Gerando Obstáculo");

                float chance = Random.value;
                Debug.Log("Chance: " + chance);
                if (chance < 0.5f) 
                {
                    Debug.Log("Gerando Power-Up");
                    Vector3 powerUpPosition = new Vector3(this.transform.position.x, Random.Range(-1f, 2f), this.transform.position.z);
                    GameObject.Instantiate(this.modeloPowerUp, powerUpPosition, Quaternion.identity);
                }
                this.cronometro = this.tempoParaGerar;
            }
            else
            {
                Debug.LogError("modeloObstaculo não está atribuído no inspetor.");
            }
        }
    }
}
