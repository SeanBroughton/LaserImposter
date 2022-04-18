using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI scoreText;
    Scorekeeper scorekeeper;

    void Awake()
    {
        scorekeeper = FindObjectOfType<Scorekeeper>();
    }

    void Start()
    {
        scoreText.text ="You've Gained:\n " + scorekeeper.GetScore();
    }

}
