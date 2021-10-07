using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Principal : MonoBehaviour
{
    Pilas pilas;
    Baraja baraja;
    // Start is called before the first frame update
    void Start()
    {
        pilas = new Pilas();
        Nodo a = new Nodo(10, "corazones");
        Nodo b = new Nodo(8, "treboles");
        Nodo c = new Nodo(5, "dimantes");
        //Carta carta = a;
        // Debug.Log(carta.numero + " " + carta.tipoCarta);
        Debug.Log(a.numero + " " + a.tipoCarta);
        Debug.Log(b.numero + " " + b.tipoCarta);
        Debug.Log(c.numero + " " + c.tipoCarta);

        pilas.AgregarNodo(a);
        pilas.AgregarNodo(b);
        pilas.AgregarNodo(c);

        while(pilas.cabeza != null)
        {
            Nodo aux = pilas.Pop();
            Debug.Log(aux.numero.ToString() + " " + aux.tipoCarta);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
