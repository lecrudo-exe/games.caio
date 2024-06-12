using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;
    [SerializeField]
    private float variacaoY;

    private Vector3 posicaoPassaro;

    private bool pontuei;

    private Uiscript scriptDaUI;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }
private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<Bird>().transform.position;
        this.scriptDaUI = GameObject.FindObjectOfType<Uiscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!this.pontuei && transform.position.x < posicaoPassaro.x)
        {
            Debug.Log("pontuou");
            this.pontuei = true;
            this.scriptDaUI.adicionarPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }
    void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
