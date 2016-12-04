using UnityEngine;
using System.Collections;
using System;

public class CFG : MonoBehaviour
{
    public bool deletaTudo;

    void Start()
    {
        Musica(MusicaLigada());       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool MusicaLigada()
    {
        return PlayerPrefs.GetInt("volume") == 1;
    }

    public void Musica(bool AValor)
    {
        PlayerPrefs.SetInt("volume", Convert.ToByte(AValor));
        AudioListener.volume = Convert.ToByte(AValor);
    }

    public void CfgInicial()
    {
#if (UNITY_EDITOR)
        if (deletaTudo)
            PlayerPrefs.DeleteAll();
#endif
        if (!PlayerPrefs.HasKey("volume"))
            PlayerPrefs.SetInt("volume", Convert.ToByte(true));
        if (!PlayerPrefs.HasKey("players2"))
            PlayerPrefs.SetInt("players2", Convert.ToByte(false));
    }

    public void Players2(bool AValor)
    {
        PlayerPrefs.SetInt("players2", Convert.ToByte(AValor));
    }

    public bool Players2Ligado()
    {
        return PlayerPrefs.GetInt("players2") == 1;
    }
}
