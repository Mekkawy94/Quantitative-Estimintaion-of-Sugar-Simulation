using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartExam()
    {
        //SceneManager.UnloadScene(2);
        SceneManager.LoadScene(2);
    }
}
