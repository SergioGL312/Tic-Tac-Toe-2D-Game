using TMPro;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    public static int cont = 0;
    int contadotInterno = 0;
    public Sprite circulo;
    public Sprite tache;
    int jugador = 0;
    public TMP_Text txtGanador;

    public GameObject
        g1,
        g2,
        g3,
        g4,
        g5,
        g6,
        g7,
        g8,
        Panel;

    public static int x1 = 0,
        x2 = 0,
        x3 = 0,
        x4 = 0,
        x5 = 0,
        x6 = 0,
        x7 = 0,
        x8 = 0,
        x9 = 0;

    // Start is called before the first frame update
    void Start()
    {
        contadotInterno = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (cont % 2 == 0 && contadotInterno == 0)
        {
            // Circulo
            this.gameObject.GetComponent<SpriteRenderer>().sprite = circulo;
            Debug.Log("P1: " + this.gameObject.GetComponent<SpriteRenderer>().name);
            jugador = 1;
            cont++;
        }
        else if (cont % 2 != 0 && contadotInterno == 0)
        {
            // Tache
            this.gameObject.GetComponent<SpriteRenderer>().sprite = tache;
            Debug.Log("P2: " + this.gameObject.GetComponent<SpriteRenderer>().name);
            jugador = 2;
            cont++;

        }
        contadotInterno++;

        Jugadores(this.gameObject.GetComponent<SpriteRenderer>().name);
        Gano(); 
    }

    private void Jugadores(string nombreObject)
    {
        if (nombreObject == "1") { x1 = jugador; }
        if (nombreObject == "2") { x2 = jugador; }
        if (nombreObject == "3") { x3 = jugador; }
        if (nombreObject == "4") { x4 = jugador; }
        if (nombreObject == "5") { x5 = jugador; }
        if (nombreObject == "6") { x6 = jugador; }
        if (nombreObject == "7") { x7 = jugador; }
        if (nombreObject == "8") { x8 = jugador; }
        if (nombreObject == "9") { x9 = jugador; }
    }

    private void Gano()
    {
        // Jugador 1
        if (x1 == 1 && x2 == 1 && x3 == 1) { Debug.Log("Gano 1.1"); g1.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x4 == 1 && x5 == 1 && x6 == 1) { Debug.Log("Gano 1.2"); g2.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x7 == 1 && x8 == 1 && x9 == 1) { Debug.Log("Gano 1.3"); g3.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x1 == 1 && x4 == 1 && x7 == 1) { Debug.Log("Gano 1.4"); g4.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x2 == 1 && x5 == 1 && x8 == 1) { Debug.Log("Gano 1.5"); g5.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x3 == 1 && x6 == 1 && x9 == 1) { Debug.Log("Gano 1.6"); g6.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x3 == 1 && x5 == 1 && x7 == 1) { Debug.Log("Gano 1.7"); g7.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }
        if (x1 == 1 && x5 == 1 && x9 == 1) { Debug.Log("Gano 1.8"); g8.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 1"; }

        // Jugador 2
        if (x1 == 2 && x2 == 2 && x3 == 2) { Debug.Log("Gano 2.1"); g1.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x4 == 2 && x5 == 2 && x6 == 2) { Debug.Log("Gano 2.2"); g2.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x7 == 2 && x8 == 2 && x9 == 2) { Debug.Log("Gano 2.3"); g3.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x1 == 2 && x4 == 2 && x7 == 2) { Debug.Log("Gano 2.4"); g4.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x2 == 2 && x5 == 2 && x8 == 2) { Debug.Log("Gano 2.5"); g5.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x3 == 2 && x6 == 2 && x9 == 2) { Debug.Log("Gano 2.6"); g6.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x3 == 2 && x5 == 2 && x7 == 2) { Debug.Log("Gano 2.7"); g7.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
        if (x1 == 2 && x5 == 2 && x9 == 2) { Debug.Log("Gano 2.8"); g8.SetActive(true); Panel.SetActive(true); txtGanador.text = "Gano el jugador 2"; }
    }

    public void ResetGame()
    {
        // Reiniciar el tablero
        x1 = x2 = x3 = x4 = x5 = x6 = x7 = x8 = x9 = 0;

        // Ocultar las marcas de ganador
        g1.SetActive(false);
        g2.SetActive(false);
        g3.SetActive(false);
        g4.SetActive(false);
        g5.SetActive(false);
        g6.SetActive(false);
        g7.SetActive(false);
        g8.SetActive(false);

        cont = 0;

        // Reiniciar el texto del marcador
        //txt.text = "Turno del Jugador 1";
    }

}
