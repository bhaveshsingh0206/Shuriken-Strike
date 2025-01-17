using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using System;
// using Unity.Services.Analytics;
// using Unity.Services.Core;
// using Unity.Services.Core.Environments;

public class ResetBtn : MonoBehaviour
{
    public static bool quitGame = false;
    private void Start(){
        Debug.Log("quit game start function");
    }
    public void hello(){
        AnalyticsResult ar = Analytics.CustomEvent("level-reset", new Dictionary<string, object> {
            {"Level", (SceneManager.GetActiveScene().buildIndex - 1)}
        });
        Debug.Log(ar);
        Application.LoadLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit(){
        quitGame = true;
        AnalyticsResult ar = Analytics.CustomEvent("level-quit", new Dictionary<string, object> {
            {"Level", (SceneManager.GetActiveScene().buildIndex - 1)}
        });
        Debug.Log(ar);
        SceneManager.LoadScene(0);
    }
}
