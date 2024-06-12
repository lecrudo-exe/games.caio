using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Uiscript : MonoBehaviour
{
    private int pontos;
    private Label textoPontuacao;

    public void adicionarPontos(){
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");    
    }
}