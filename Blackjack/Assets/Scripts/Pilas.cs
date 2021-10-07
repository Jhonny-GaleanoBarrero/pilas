[System.Serializable]

public class Pilas
{
    public Nodo cabeza;
    public Nodo cola;

    public Pilas()
    {
        cabeza = null;
    }

    public void AgregarNodo(int numero, string tipoCarta)
    {
        Nodo n = new Nodo(numero, tipoCarta);

        if (cabeza == null)
        {
            cabeza = n;
            cola = n;
        }
        else
        {
            n.anterior = cabeza;
            cabeza.siguiente = n;
            cabeza = n;
        }
    }

    public void AgregarNodo(Nodo n)
    {
        if (cabeza == null)
        {
            cabeza = n;
            cola = n;
        }
        else
        {
            n.anterior = cabeza;
            cabeza.siguiente = n;
            cabeza = n;
        }
    }
    public string DesplegarPila()
    {

        string p = "";
        string c = "";

        if (cabeza == null)
        {
            return "[vacia]";
        }

        Nodo n = cabeza;

        do
        {
            p += "" + n.numero;
            c += "" + n.tipoCarta;
            n = n.siguiente;
        } while (n != null);

        return p + c;
    } 

    public Nodo Pop()
    {
        if (cabeza == null)
        {
            return null;
        }
        else if(cabeza == cola)
        {
            cola = null;
            Nodo auxi = cabeza;
            cabeza = null;
            return auxi;
        }
        Nodo aux = cabeza;
        cabeza = cabeza.anterior;
        cabeza.siguiente = null;
        return aux;
    }
}

[System.Serializable]

public class Nodo:Carta
{
    public Nodo siguiente;
    public Nodo anterior;

    public Nodo(int _numero, string _tipoCarta) : base(_numero, _tipoCarta)
    {
        siguiente = null;
        anterior = null;
    }
}