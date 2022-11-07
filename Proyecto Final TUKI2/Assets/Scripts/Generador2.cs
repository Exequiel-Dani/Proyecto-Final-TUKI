using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador2 : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy2;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;
    private float speedG = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime , repeatTime);  // usamos el InvokeRepeating para que ejecute el metodo "GenerateEnemy" en un tiempo inicial y con un tiempo de repeticion a eleccion
        Invoke("StopGenerateEnemy",15); // para poder parar las invocaciones usamos un Invoke que llamara a un metodo luego de 15s que contiene un cancelInvoke el cual parará al metodo GenerateEnemy 
    }                                   // llamamos al metodo StopGenerateEnemy luego de 15s ya que nuestro generador invoca cada 3s y la consigna nos pide que solo invoque 5 por lo tanto 3x5 = 15

     void Update()
    {
        moveGenerator();                // creamos un metodo para mover nuestro generador en el update ya que queremos que se ejecute constantemente
    }

    public void StopGenerateEnemy()          // creamos un metodo el cual contiene un cancelInvoke que es justamente lo contrario al Invoke por lo que detiene todas las invocaciones al momento
    {
        CancelInvoke("GenerateEnemy");
    }
    public void GenerateEnemy()              // creamos un metodo con un Instantiate que instancia un gameobject que ya declaramos antes en la posicion y rotacion del gameobject al que le asignemos el script
    {
        Instantiate(enemy2, transform.position, transform.rotation);
    }
    public void moveGenerator()  
    {
        transform.Translate(0, 0, speedG * Time.deltaTime);   // usamos un translate para mover nuestro generador en este caso en el eje z y lo normalizamos en funcion del tiempo
        if (transform.position.z > 7 || transform.position.z < -7) // usamos un condicional if para que si nuestro generador supera las cordenadas indicadas invierta la velocidad 
        { speedG *= -1; }
        
    }
}
