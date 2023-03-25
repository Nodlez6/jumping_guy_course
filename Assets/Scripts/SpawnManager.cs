using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance{ get; private set;}
    public GameObject Enemyprefab;
    public float spawnTimer = 3f;

    void Awake()
    {
        Instance = this;
    }

    //Iniciar la generación
    public void StartSpawn(){
        InvokeRepeating("SpawnEnemy", 0f, spawnTimer); //Metodo para invocar una funcion cada cierto tiempo
    }

    //Encargado de gnenerar al enemigo
    void SpawnEnemy(){
        //una forma de eliminar los enemigos.
        //GameObject enemy = Instantiate(Enemyprefab, transform.position, Quaternion.identity);
        //Object.Destroy(enemy, 10f);
        Instantiate(Enemyprefab, transform.position, Quaternion.identity);
    }

    //Parar la generación
    public void StopSpawn(){
        CancelInvoke();
    }

}
