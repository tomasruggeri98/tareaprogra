using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class InicioJuego : MonoBehaviour
{
    public Text contadorText; 
    public float tiempoInicio = 5.0f; 

    private void Start()
    {
        StartCoroutine(ContadorRegresivo());
    }

    private IEnumerator ContadorRegresivo()
    {
        float tiempoRestante = tiempoInicio;

        while (tiempoRestante > 0)
        {
            contadorText.text = tiempoRestante.ToString("0");
            yield return new WaitForSeconds(1.0f);
            tiempoRestante--;
        }

        contadorText.text = "Comienza el juego!";
        
        yield return new WaitForSeconds(1.0f); 
        contadorText.gameObject.SetActive(false); // oculta el texto del contador
    }
}
