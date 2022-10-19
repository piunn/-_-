using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chargement : MonoBehaviour {
    public string Level;

    public void nextScene() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Level);
    }


    public void Leave() {
        Application.Quit();
    }
}
