using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class controlador_menu : MonoBehaviour
{
    private UIDocument document;
    private Button bot�o;

    private void Awake()
    {
        document = GetComponent<UIDocument>();
        bot�o = document.rootVisualElement.Q<Button>("devolva");
        bot�o.RegisterCallback<ClickEvent>(onPlay);
    }
    void onPlay(ClickEvent evt)
    {
        SceneManager.LoadScene("main");
    }
}

