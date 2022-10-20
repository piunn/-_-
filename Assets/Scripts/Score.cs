using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreObject;
    public GameObject board;
    private int scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        scoreBoard=board.GetComponent<Board>().scoreNumber;

        ScoreObject = GetComponent<TextMeshProUGUI>();
        ScoreObject.SetText("Score : " + scoreBoard);
    }

    // Update is called once per frame
    void Update()
    {
        scoreBoard=board.GetComponent<Board>().scoreNumber;
        ScoreObject.SetText("Score : " + scoreBoard);
    }
}
