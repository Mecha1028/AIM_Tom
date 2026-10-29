using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private Slider healthSlider;
    [SerializeField] private TMP_Text healthText;

    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        healthSlider.minValue = 0;
        healthSlider.maxValue = maxHealth;
        UpdateHealthUI();
    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth - amount, 0, maxHealth);
        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        healthSlider.value = currentHealth;
        healthText.text = $"HEALTH {currentHealth} / {maxHealth}";
    }
}