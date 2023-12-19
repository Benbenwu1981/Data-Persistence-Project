using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;


public class MenuUI : MonoBehaviour
{
    public TMP_InputField playernameInput;

    public void SetName()
    {
        Debug.Log(playernameInput.text);
    }
    
    public void PressStart()
    {
        SceneManager.LoadScene(1);
    }
}
