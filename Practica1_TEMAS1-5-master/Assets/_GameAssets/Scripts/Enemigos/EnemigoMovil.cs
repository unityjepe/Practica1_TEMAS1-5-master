using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovil : Enemigo {
    [Header("Enemigo Movil")]
    [SerializeField] protected int speed=1;  
    [SerializeField] protected int inicioRotacion = 1;
    [SerializeField] protected int TiempoRotacion = 2;
    void Start()
    {
        InvokeRepeating("RotarAleatoriamente", 1, 2);
    }

    protected void Avanzar() {
        if (estaVivo)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        
    }

    protected void RotarAleatoriamente() {
        float rotacion = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0, rotacion, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        RotarAleatoriamente();
        if (collision.gameObject.name == "Player")
        {

            collision.gameObject.GetComponent<Player>().RecibirDanyo(danyo);
            estaVivo = false;
            ParticleSystem ps = Instantiate(psExplosion, transform.position, Quaternion.identity);
            ps.Play();
            //GetComponent<Renderer>().enabled=false;
            
            Destruir();
            //Invoke("Destruir", 10);
            //Destroy(this.gameObject);

        }
    }

}
