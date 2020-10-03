using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float basePlayerHealth = 3;
    float playerHealth;
    Text healthText;

    void Start()
    {
        playerHealth = basePlayerHealth - PlayerPrefsController.GetDifficulty();
        healthText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("Is: " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        healthText.text = playerHealth.ToString();
    }

    public void DecreaseHealth()
    {
        playerHealth--;
        UpdateDisplay();

        if (playerHealth <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition(); 
        }

    }

}
