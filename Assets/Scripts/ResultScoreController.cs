using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ResultScoreController : MonoBehaviour
{
    public GameObject scoreText;
    private void Start(){
        scoreText.GetComponent<TextMeshProUGUI>().SetText("YOUR SCORE : " + StateNameController.score);
    }
}
