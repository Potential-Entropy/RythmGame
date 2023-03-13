using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemy : MonoBehaviour
{
    public const float playerMaxHP = 100;
    public const float enemyMaxHP = 500;
    float playerHP;
    float enemyHP;
    int combo;

    void Start()
    {
        playerHP = playerMaxHP;
        enemyHP = enemyMaxHP;
    }

    void NoteHit()
    {

    }

    void DamagePlayer(float damage)
    {
        playerHP -= damage;
        if(playerHP < 0)
            Lose();
    }

    void DamageEnemy(float damage)
    {
        enemyHP -= damage;
        if (enemyHP < 0)
            Win();
    }

    void Win()
    {

    }

    void Lose()
    {

    }
}
