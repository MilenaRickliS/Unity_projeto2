using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class munuPrincipal : MonoBehaviour
{

[SerializeField] private string gameNameLevel;

[SerializeField] private GameObject MenuInicial;

[SerializeField] private GameObject Opcoes;;

public void Play()
{
    SceneManager.LoadScene("Jogo");
}

public void Options()
{
    MenuInicial.SetActive(false);

    Opcoes.SetActive(true);
}

public void CloseOptions()
{
    Opcoes.SetActive(false);

    MenuInicial.SetActive(true);
}

public void LeaveGame()
{
    Application.Quit();
}
}
