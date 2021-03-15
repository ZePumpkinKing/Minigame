using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private GameObject text;
    public static Score scoreScript;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = this;
        score = 0;
        text = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<UnityEngine.UI.Text>().text = "\n\nKills: " + score;
    }
}
