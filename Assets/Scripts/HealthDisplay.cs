using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    float health;
    Text healthText;

    void Start()
    {
        float diff = PlayerPrefsController.GetDifficulty();
        switch (PlayerPrefsController.GetDifficulty())
        {
            case 0:
                health = 200;
                break;
            case 1:
                health = 100;
                break;
            default:
                health = 50;
                break;
        }

        healthText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }

    public bool HaveEnoughHealth(float damage)
    {
        return health >= damage;
    }

    public void DealDamage(float damage)
    {
        if (health >= damage)
        {
            health -= damage;
            if (health <= 0)
            {
                health = 0;
            }
            UpdateDisplay();
        }
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
