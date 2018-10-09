using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorEnemigos : EnemigoMovil
{
    int numEnemigos = 0;
    [SerializeField] private const int numEnemigosMax=5;
    [SerializeField] GameObject prefabEnemigo;
	// Use this for initialization
	void Start ()
    {
        GenerarEnemy();
        InvokeRepeating("GenerarEnemy", 3, 3);
    }

    private void GenerarEnemy()
    {
        GameObject newEnemigo = Instantiate(prefabEnemigo, transform.position, Quaternion.identity);
        numEnemigos++;
        if (numEnemigos == numEnemigosMax)
        {
            CancelInvoke();
        }
    }

    // Update is called once per frame
    void Update () {
       /* if (numEnemigos < numEnemigosMax)
        {

        }*/
    }
}
