using TMPro;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;

    public TMP_Text healthText;

    private int currentHealth;
    private Animator healthAnim;

    void Start()
    {
        currentHealth = maxHealth;
        healthAnim = healthText.GetComponent<Animator>();
        UpdateHealthBar(false);
    }

    public void UpdateHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void UpdateHealthBar(bool animate = true)
    {
        healthText.text = "HP: " + currentHealth + "/" + maxHealth;
        if (animate)
        {
            healthAnim.Play("HealthBarAnimation");
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
