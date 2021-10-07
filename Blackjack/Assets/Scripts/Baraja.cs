using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baraja : MonoBehaviour
{

    public Carta head;
    public Carta tail;
    public string[] typeCard = new string[4] { "Picas", "Corazones", "Diamantes", "Treboles"};
    public string[] valueCard = new string[13] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    public Carta[] myBaraja = new Carta[52];
    public Carta myCarta;

    public Baraja()
    {
        head = null;
    }

    public static void Orden()
    {
       
    }

    public static void Retorno()
    {
       
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
