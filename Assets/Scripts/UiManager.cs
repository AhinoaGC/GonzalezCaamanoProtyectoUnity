using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject panelOpciones;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (panelOpciones.activeSelf == false)
            {
                Time.timeScale = 0;
                panelOpciones.SetActive(true);
            }
            else if(panelOpciones.activeSelf == true)
            {
                Time.timeScale = 1;
                panelOpciones.SetActive(false);
            }
            
        }
    }
    public void PanelOpciones()
    {
        Time.timeScale = 0;
        panelOpciones.SetActive(true);
    }

    public void Volver()
    {
        Time.timeScale = 1;
        panelOpciones.SetActive(false);
    }

    public void IrMenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void SalirJuego()
    {
        Application.Quit();
    }
}
