using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum NoteHit
{
    Perfect, Good, Miss
}

public class PlayerEnemy : MonoBehaviour
{
    public const float playerMaxHP = 300;
    public const float enemyMaxHP = 4000;
    private float playerHP;
    private float enemyHP;
    private int combo;
    [SerializeField] private const float baseDamage = 10;

    [SerializeField] private TextMeshProUGUI comboDisplay;

    [SerializeField] private Slider playerHealthBar;
    [SerializeField] private Slider enemyHealthBar;

    void Start()
    {
        playerHP = playerMaxHP;
        playerHealthBar.maxValue = playerMaxHP;
        playerHealthBar.value = playerMaxHP;
        enemyHP = enemyMaxHP;
        enemyHealthBar.maxValue = enemyMaxHP;
        enemyHealthBar.value = enemyMaxHP;
        combo = 0;
    }

    public void EvaluateHit(NoteHit hit, float xPosition)
    {
        Debug.Log(hit.ToString());
        switch (hit)
        {
            case NoteHit.Perfect:
                combo++;
                DamageEnemy(xPosition);
                break;
            case NoteHit.Good:
                GameManager.Instance.VFXManager.Deflect(new Vector2(xPosition, 0));
                combo++;
                break;
            case NoteHit.Miss:
                combo = 0;
                DamagePlayer();
                break;
        }
        comboDisplay.text = combo.ToString();
        GameManager.Instance.VFXManager.DisplayHit(hit);
    }

    void DamagePlayer()
    {
        playerHP -= baseDamage;
        playerHealthBar.value = playerHP;
        GameManager.Instance.noteSpawner.SetDisharmony(1.0f - playerHP / playerMaxHP);
        if (playerHP <= 0)
            Lose();
    }

    void DamageEnemy(float xPosition)
    {
        enemyHP -= baseDamage * (1 + combo * 0.01f);
        enemyHealthBar.value = enemyHP;
        GameManager.Instance.VFXManager.Reflect(new Vector2(xPosition, 0));
        if (2 * enemyHP <= enemyMaxHP)
            GameManager.Instance.noteSpawner.SetPlaybackSpeed(Mathf.Lerp(1.0f, 1.2f, 1.0f - 2 * enemyHP / enemyMaxHP));
        if (enemyHP <= 0)
            Win();
    }

    void Win()
    {
        StopMusic();
        SceneManager.LoadScene(3);
    }

    void Lose()
    {
        StopMusic();
        SceneManager.LoadScene(4);
    }

    void StopMusic()
    {
        NoteSpawner.songInstance.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        NoteSpawner.songInstance.release();
    }
}
