using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject clearUI;
    public GameObject gameOverUI;

    private void Start() {
        clearUI.SetActive(false);
        gameOverUI.SetActive(false);
    }

    private void Update() {
        int counter_block = GameObject.FindGameObjectsWithTag("Block").Length;
        int counter_player = GameObject.FindGameObjectsWithTag("Player").Length;

        if (counter_block == 0) {
            clearUI.SetActive(true);
        }

        if (counter_player == 0 && counter_block != 0) {
            gameOverUI.SetActive(true);
        }
    }
}
