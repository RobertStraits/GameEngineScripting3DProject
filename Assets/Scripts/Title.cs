﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    public void StartGameButtonClicked()
    {
        SceneManager.LoadScene("DemoScene");
    }
    public void CreditsButtonClicked()
    {
        SceneManager.LoadScene("CreditScene");
    }
}