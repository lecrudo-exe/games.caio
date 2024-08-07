using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class controlador_menu : MonoBehaviour
{
    private UIDocument document;
    private Button botão;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        botão = document.rootVisualElement.Q<Button>("devolva");
        botão.RegisterCallback<ClickEvent>(onPlay);
    }
    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("main");
    }
}

