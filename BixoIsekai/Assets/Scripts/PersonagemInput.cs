using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemInput : MonoBehaviour
{
    public Personagem hominho;

    private void Awake()
    {
        hominho = GetComponent<Personagem>();
    }

    // Update is called once per frame
    void Update()
    {
        //Teste do Personagem recebendo dano
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Ai!");
            hominho.Dano(10);
        }
    }
}
