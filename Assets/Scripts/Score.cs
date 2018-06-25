using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;

    void Update()
    {
        float f = player.position.z;
        if(!float.IsNaN(f))
            scoreText.text = player.position.z.ToString("0");
    }
}
