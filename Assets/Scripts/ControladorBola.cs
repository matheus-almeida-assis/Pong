using UnityEngine;
using System.Collections;

public class ControladorBola : MonoBehaviour
{
    Rigidbody body;
    public TextMesh placarJogador;
    public TextMesh placarJogadoInimigo;
    int pontosJogadorInimigo = 0;
    int pontosJogador = 0;
    Vector3 velocidade;
    public Pause pause;
    Vector3 velocidadeAtual;
    public AudioClip pong;
    public AudioClip errou;
    // Use this for initialization
    void Start()
    {
        body = GetComponent<Rigidbody>();
        velocidade = new Vector3(10, 0, 10);
        body.velocity = velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        if (body.velocity != Vector3.zero)
        {
            velocidadeAtual = body.velocity;
        }
        if (!pause.gameObject.activeSelf)
        {
            body.velocity = velocidadeAtual;
        }
        else
        {
            body.velocity = Vector3.zero;
        }
        if (transform.position.z > 11)
        {
            GetComponent<AudioSource>().PlayOneShot(errou);
            Start();
            transform.position = Vector3.zero;
            pontosJogadorInimigo++;
            placarJogadoInimigo.text = pontosJogadorInimigo.ToString();
        }
        if (transform.position.z < -11)
        {
            GetComponent<AudioSource>().PlayOneShot(errou);
            transform.position = Vector3.zero;
            Start();
            pontosJogador++;
            placarJogador.text = pontosJogador.ToString();
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Muro")
        {
            body.velocity = new Vector3(-body.velocity.x, 0.0f, body.velocity.z);
            GetComponent<AudioSource>().PlayOneShot(pong);
        }
        if (col.gameObject.name == "Jogador" || col.gameObject.name == "JogadorInimigo")
        {
            body.velocity = new Vector3(body.velocity.x, 0.0f, -body.velocity.z);
            GetComponent<AudioSource>().PlayOneShot(pong);
        }
    }
}
