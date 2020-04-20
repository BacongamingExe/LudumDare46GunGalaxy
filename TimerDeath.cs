using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerDeath : MonoBehaviour
{
    public GameObject DeathCubes;
    public GameObject Player;
    public GameObject Score;
    public GameObject DeathUI;
    public GameObject JumpButton;
    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerSecond;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSecond = 1f;
        DeathCubes.SetActive(false);
        Player.SetActive(true);
        DeathUI.SetActive(false);
        Score.SetActive(true);
        JumpButton.SetActive(true);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Lazer")
        {
            GameOver();
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + " Seconds Alive";
        scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    }
    void GameOver()
    {
        Destroy(Player);
        Destroy(JumpButton);
        DeathCubes.SetActive(true);
        DeathUI.SetActive(true);
        Score.SetActive(false);
        Time.timeScale += time;

    }
}
