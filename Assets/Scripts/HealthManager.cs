using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    int health = 100;
    int startHealth;
    public float healingSpeed;
    private float time;
    private Vector3 respawnLocation;
    [SerializeField] GameObject explosionDirtFX;
    [SerializeField] ScreenEffects screenDimmer;
    [SerializeField] Slider healthBar;
    CharacterController characterController;
    

    public CharacterController CharacterController { get { return characterController = characterController ?? GetComponent<CharacterController>(); } }

    private void Start()
    {
        startHealth = health;
        if (RespawnPointsManager.Instance != null && RespawnPointsManager.Instance.GetCurrentRespawnPoint() != null)
        {
            respawnLocation = RespawnPointsManager.Instance.GetCurrentRespawnPoint().position;
        }
        else
        {
            respawnLocation = transform.position;
        }
        healthBar.maxValue = startHealth;
        healthBar.value = health;
    }
    private void Update()
    {
        if (health != startHealth)
        {
            time += Time.deltaTime;
            if (time > healingSpeed)
            {
                Heal();
                time = 0;
            }
        }
    }
    void Heal() 
    {
        health += 1;
        healthBar.value = health;
    }
    public void TakeDamage(int damageRate)
    {
        if (health > 0) health -= damageRate;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
        healthBar.value = health;
    }
    public void Die()
    {
        screenDimmer.BlinkGraphic();
        Instantiate(explosionDirtFX, transform.position, Quaternion.identity).SetActive(true);

        if (RespawnPointsManager.Instance != null && RespawnPointsManager.Instance.GetCurrentRespawnPoint() != null)
        {
            respawnLocation = RespawnPointsManager.Instance.GetCurrentRespawnPoint().position;
        }

        CharacterController.enabled = false;
        transform.position = respawnLocation;
        CharacterController.enabled = true;
        health = startHealth;
        healthBar.value = health;
    }
}
