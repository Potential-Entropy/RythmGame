using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum NoteHit
{
    Perfect, Good, Miss
}

public class PlayerEnemy : MonoBehaviour
{
    [SerializeField] public const float playerMaxHP = 100;
    [SerializeField] public const float enemyMaxHP = 500;
    private float playerHP;
    private float enemyHP;
    private int combo;
    [SerializeField] private const float baseDamage = 10;

    [SerializeField] private TextMeshProUGUI comboDisplay;
    [SerializeField] private TextMeshProUGUI hitDisplay;

    [SerializeField] private TextMeshProUGUI playerHealthBar;
    [SerializeField] private TextMeshProUGUI enemyHealthBar;

    void Start()
    {
        playerHP = playerMaxHP;
        enemyHP = enemyMaxHP;
        combo = 0;
    }

    public void EvaluateHit(NoteHit hit)
    {
        Debug.Log(hit.ToString());
        switch (hit)
        {
            case NoteHit.Perfect: 
                combo++; 
                DamageEnemy(); 
                break;
            case NoteHit.Good: 
                combo++; 
                break; 
            case NoteHit.Miss: 
                combo = 0;
                DamagePlayer(); 
                break;
        }
        comboDisplay.text = combo.ToString();
        hitDisplay.text = hit.ToString();

    }

    void DamagePlayer()
    {
        playerHP -= baseDamage;
        playerHealthBar.text = playerHP.ToString();
        if(playerHP <= 0)
            Lose();
    }

    void DamageEnemy()
    {
        enemyHP -= baseDamage * (1 + combo * 0.01f);
        enemyHealthBar.text = enemyHP.ToString();
        if (enemyHP <= 0)
            Win();
    }

    void Win()
    {
        SceneManager.LoadScene(2);
    }

    void Lose()
    {
        SceneManager.LoadScene(3);
    }
}
