using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baralho : MonoBehaviour
{
    public List<GameObject> cartas = new List<GameObject>();
    public List<GameObject> deckPlayer = new List<GameObject>();
    public List<GameObject> deckOponente = new List<GameObject>();
    public Player player;
    public Player oponente;
    public float offsetX;
    public int tempo;
    public GameObject cartaSorteada;
    private Vector3 posCarta;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        oponente = GameObject.FindWithTag("Oponente").GetComponent<Player>();
        DeckInicialOponente();
        DeckInicialPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<GameObject> DeckInicial(int limite, string tipo)
    {
        //List<GameObject> deck = new List<GameObject>();
        /*for(int i = 0; i < limite; i++)
        {
            //posCarta = player.LocalDeck();
            //offset = new Vector3(offsetX,0,0);
            //cartaSorteada = Instantiate(cartas[Random.Range(0, cartas.Count)], posCarta += offset, Quaternion.identity);
            //cartaSorteada = cartas[Random.Range(0, cartas.Count)];
            
            /*if(tipo == "Player")
            {
                DeckInicialPlayer(limite);
            }
            else if(tipo == "Oponente")
            {
                DeckInicialOponente(limite);
            }
        }*/
        
        if(tipo == "Player")
        {
            return deckPlayer;
        }
        else if(tipo == "Oponente")
        {
            return deckOponente;
        }
        
        return null;
    }

    public void DeckInicialPlayer()
    {
        for(int i = 0; i < 5; i++)
        {
            
            
            cartaSorteada = cartas[Random.Range(0, cartas.Count)];
            cartaSorteada.gameObject.tag = "Carta Player";
            deckPlayer.Add(cartaSorteada);
            
        }
    }

    public void DeckInicialOponente()
    {
        for(int i = 0; i < 5; i++)
        {
            
            cartaSorteada = cartas[Random.Range(0, cartas.Count)];
            cartaSorteada.gameObject.tag = "Carta Oponente";
            deckOponente.Add(cartaSorteada);
            
        }
    }
}
