using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }

    void DamagePlayer()
    {
        playerHP -= baseDamage;
        if(playerHP <= 0)
            Lose();
    }

    void DamageEnemy()
    {
        enemyHP -= baseDamage * (1 + combo * 0.01f) ;
        if (enemyHP <= 0)
            Win();
    }

    void Win()
    {
        //TODO End game
    }

    void Lose()
    {
        //TODO End game
    }
}
