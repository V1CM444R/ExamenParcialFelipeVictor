using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ExamenVictor : MonoBehaviour
{
    private int seleccionIA;
    [SerializeField] private TMP_Text IATexto;
    [SerializeField] private TMP_Text PlayerTexto;
    private int inputUsuario;

    // Start is called before the first frame update

    void Start()
    {
        seleccionIA = Random.Range(1, 5);
        IATexto.text = "Sin votos!";
    }

    // Update is called once per frame

    void Update()
    {

    }

    public void AsignarSeleccion(int seleccion)
    {
        inputUsuario = seleccion;
        if (inputUsuario == 1)
        {
            PlayerTexto.text = "Votaste a favor!";
        }
        else if (inputUsuario == 2)
        {
            PlayerTexto.text = "Votaste en contra!";
        }
        else if (inputUsuario == 3)
        {
            PlayerTexto.text = "Finalizaste votos!";
        }
        else if (inputUsuario == 4)
        {
            PlayerTexto.text = "Reiniciaste votos!";
        }




    }
}
