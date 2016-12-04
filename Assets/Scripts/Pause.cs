using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public Text textoPause;
    public GameObject btnmenu;
    float tempooriginal;
    public float tempo;

    // Use this for initialization
    void Start()
    {
        textoPause.text = "Ready";
        btnmenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (textoPause.text != "Pause")
        {
            tempooriginal += Time.deltaTime;
            if (tempooriginal > tempo)
            {
                tempooriginal = 0;
                if (textoPause.text == "GO!")
                {
                    gameObject.SetActive(false);
                }
                textoPause.text = "GO!";
            }
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Play()
    {
        if (gameObject.activeSelf == true)
        {
            Cursor.visible = false;
            gameObject.SetActive(false);
            btnmenu.SetActive(false);
        }
        else
        {
            Cursor.visible = true;
            gameObject.SetActive(true);
            textoPause.text = "Pause";
            btnmenu.SetActive(true);
        }
    }
}
