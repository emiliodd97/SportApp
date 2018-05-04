using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Mapa : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadScene("Map");
    }
}