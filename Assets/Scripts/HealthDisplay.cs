using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] float health = 100;
    Text healthText;

    void Start()
    {
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
            FindObjectOfType<LevelLoader>().LoadYouLose();
        }
    }
}
