using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInicialTeste : MonoBehaviour {

    public Texture TexturaFundo,TexturaCreditos;
    private bool EstaNoMenuPrincipal,EstaNosCreditos;
    public GUIStyle EstiloDosBotoesPrincipais;
    public Font Fonte;
    public int tamanhodaLetra = 4;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {
        EstaNoMenuPrincipal = true;
        Cursor.visible = true;

    }

   

    void OnGUI()
    {
        GUI.skin.font = Fonte;
        EstiloDosBotoesPrincipais.fontSize = Screen.height/100 * tamanhodaLetra;
        
        //===Parte Principal do Menu==//
        if (EstaNoMenuPrincipal == true)
        {
            GUI.skin.button = EstiloDosBotoesPrincipais;
            GUI.DrawTexture(new Rect(Screen.width/2 - Screen.width/2,Screen.height / 2 - Screen.height/2,Screen.width, Screen.height), TexturaFundo);
            if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 16, Screen.height / 2 - Screen.height / 5.5f, Screen.width / 8, Screen.height / 14), "Jogar")){
                Application.LoadLevel("Jogo");
            }
            if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 16, Screen.height / 2 - Screen.height /16, Screen.width / 8, Screen.height / 14),"Creditos"))
            {
                EstaNoMenuPrincipal = false;
                EstaNosCreditos = true;               
            }
            if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 16, Screen.height / 2 + Screen.height / 16, Screen.width / 8, Screen.height / 14), "Sair"))
            {             
                Application.Quit ();
            }
        }
        //===Nos Creditos===//
        if(EstaNosCreditos == true)
        {            
            GUI.skin.button = EstiloDosBotoesPrincipais;
            GUI.DrawTexture(new Rect(Screen.width / 2 - Screen.width / 2, Screen.height / 2 - Screen.height / 2, Screen.width, Screen.height), TexturaCreditos);
            if (GUI.Button(new Rect(Screen.width / 2 - Screen.width / 2.2f, Screen.height / 2 + Screen.height / 2.5f, Screen.width / 8, Screen.height / 14), "Voltar"))
            {
                EstaNoMenuPrincipal = true;
                EstaNosCreditos = false;
            }
        }
    }
}
