using UnityEngine;
using System.Collections;

public class ControladorInimigo : MonoBehaviour
{

    public GameObject Bola;
    public Pause pause;
    float velocidade = 9.0f;
    public CFG cfg;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.gameObject.activeSelf)
        {
            if (cfg.Players2Ligado())
            {
                transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal"), transform.position.y, transform.position.z);
            }
            else
            {
                if (Bola.transform.position.x > transform.position.x)
                {
                    transform.position = new Vector3(transform.position.x + velocidade * Time.deltaTime, transform.position.y, transform.position.z);
                }
                if (Bola.transform.position.x < transform.position.x)
                {
                    transform.position = new Vector3(transform.position.x - velocidade * Time.deltaTime, transform.position.y, transform.position.z);
                }
            }
        }
        if (transform.position.x > 12)
        {
            transform.position = new Vector3(12, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -12)
        {
            transform.position = new Vector3(-12, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            pause.Play();
        }
    }
}
