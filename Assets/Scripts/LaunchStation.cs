using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaunchStation : MonoBehaviour, IResponsible
{
    public ScreenEffects screen;
    public float launchDelay;
    public GameObject player;
    public GameObject finishCutScene;
    public SpaceShuttleBehavior shuttle;
    public ParticleSystem[] particles;
    [SerializeField] MeshRenderer rocket;
    public AudioSource audioSource;
    public AudioSource alarm;
    public void Respond(bool state)
    {
        if (TaskControlManager.Instance.IsReadyToLaunch())
        {
            Launch();
        }
        else return;
    }

    void Start()
    {
        finishCutScene.SetActive(false);
    }
    void Launch()
    {
        audioSource.Play();
        Invoke(nameof(StartPartickle), 1f);
        StartCoroutine(FinalCountDown(launchDelay));
        finishCutScene.SetActive(true);
        player.SetActive(false);
    }
    void DimScreen()
    {
        screen.SlowHide();
    }
    void EndGame()
    {
        SceneManager.LoadScene("FinishMenu");
    }
    IEnumerator FinalCountDown(float delay)
    {
        yield return new WaitForSeconds(delay);
        shuttle.TakeOff();
        Invoke(nameof(DimScreen), 33f);

        Invoke(nameof(EndGame), 36f);
    }
    void StartPartickle() 
    {
        foreach (var particle in particles)
        {
            particle.Play();
        }
    }

}
