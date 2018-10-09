using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BalaBasica : MonoBehaviour
{
    [SerializeField] GameObject prefobjBala;
    //public Button yourButton; 

    void Start()
    {
        //Button btn = yourButton.GetComponent<Button>();
        // btn.onClick.AddListener();





    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Disparo");
            GameObject NuevaBala = Instantiate(prefobjBala, transform.position, transform.rotation);
            NuevaBala.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);

        }
    }
}
