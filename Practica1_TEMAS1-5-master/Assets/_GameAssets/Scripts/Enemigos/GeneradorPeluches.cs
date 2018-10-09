using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPeluches : MonoBehaviour {
    int numEnemigos = 0;
    [SerializeField] private const int numEnemigosMax = 5;
    [SerializeField] GameObject prefabPeluche;

    // Use this for initialization
    void Start () {
        GenerarPeluche();
        InvokeRepeating("GenerarPeluche", 3, 3);
    }
	
	// Update is called once per frame
	void Update () {
        GenerarPeluche();
        InvokeRepeating("GenerarPeluche", 3, 3);
    }
    private void GenerarPeluche()
    {
        GameObject newPeluche = Instantiate(prefabPeluche, transform);
        numEnemigos++;
        if (numEnemigos == numEnemigosMax)
        {
            CancelInvoke();
        }
    }
}
