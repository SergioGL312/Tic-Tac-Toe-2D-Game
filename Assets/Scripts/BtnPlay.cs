using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnPlay : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Scene2");
    }
}
