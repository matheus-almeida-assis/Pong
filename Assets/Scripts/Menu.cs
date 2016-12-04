using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject menuCFG;
    public CFG cfg;
    public GameObject creditos;

    void Awake()
    {
        cfg.CfgInicial();
    }

    // Use this for initialization
    void Start()
    {
        Screen.sleepTimeout = 0;
        Cursor.visible = true;     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Sair();
        }
    }

    public void Comecar()
    {
        SceneManager.LoadScene("Principal");
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Configuracoes()
    {
        menuCFG.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Creditos()
    {
        creditos.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Voltar()
    {
        gameObject.SetActive(true);
        creditos.SetActive(false);
    }
}
