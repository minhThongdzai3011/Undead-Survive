using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerHP = 100f;
    public TextMeshProUGUI playerHpText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       UpdatePlayerHpText();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        playerHP -= damage;
        if (playerHP < 0)
        {
            playerHP = 0;
            Debug.Log("Player is dead!");
        }
        UpdatePlayerHpText();
    }

    private void UpdatePlayerHpText()
    {
        if (playerHpText != null)
        {
            playerHpText.text = "HP: " + playerHP.ToString("F0");
        }
    }
}
