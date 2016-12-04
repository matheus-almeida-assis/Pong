using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class MenuCFG : MonoBehaviour
{
    public Text audioText;
    public GameObject menuPrincipal;
    public CFG cfg;
    public Text player;

    void Awake()
    {
        if (cfg.MusicaLigada())
        {            
            audioText.text = "Sound On";
        }
        else
        {
            audioText.text = "Sound Off";
        }
        if (cfg.Players2Ligado())
        {
            player.text = "2 Player";
        }
        else
        {
            player.text = "1 Player";
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Voltar();
        }
    }

    public void Audio()
    {

        if (cfg.MusicaLigada())
        {
            audioText.text = "Audio Off";
            cfg.Musica(false);
        }
        else
        { 
            audioText.text = "Audio On";
            cfg.Musica(true);
        }
    }

    public void Voltar()
    {
        menuPrincipal.SetActive(true);
        gameObject.SetActive(false);
    }

    public void Players2()
    {
        if (cfg.Players2Ligado())
        {
            player.text = "1 Player";
            cfg.Players2(false);
        }
        else
        {
            player.text = "2 Players";
            cfg.Players2(true);
        }
    }

}
