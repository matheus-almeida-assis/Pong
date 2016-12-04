using UnityEngine;
using System.Collections;

public class ControladorJogador : MonoBehaviour
{
    public Pause pause;
    // Use this for initialization
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.gameObject.activeSelf)
        {
            Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(raio.origin, raio.direction * 8, Color.green);
            transform.position = new Vector3(raio.GetPoint(0.0f).x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 12)
        {
            transform.position = new Vector3(12, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -12)
        {
            transform.position = new Vector3(-12, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(2))
        {
            pause.Play();
        }
    }
}
