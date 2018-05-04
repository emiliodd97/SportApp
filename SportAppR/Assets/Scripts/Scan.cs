using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Scan : MonoBehaviour
{

    void Start()
    {
        SceneManager.LoadScene("Scanner");
    }
}