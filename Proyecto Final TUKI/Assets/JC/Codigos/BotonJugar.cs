using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Inicio de juego  */
public class BotonJugar : MonoBehaviour
{
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);

    }
}
