﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("RKey"))
         {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
       
    }
}
