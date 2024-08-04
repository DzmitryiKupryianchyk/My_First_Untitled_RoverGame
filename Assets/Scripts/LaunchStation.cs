using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchStation : MonoBehaviour, IResponsible
{
    //bool readyToLaunch;
    public float launchDelay;
    public GameObject player;
    public GameObject finishCutScene;
    public SpaceShuttleBehavior shuttle;
    public ParticleSystem[] particles;
    [SerializeField] MeshRenderer rocket;
    public void Respond(bool state)
    {
        if (TaskControlManager.Instance.IsReadyToLaunch())
        {
            LoadToShuttle();
        }
        else return;
    }

    void Start()
    {
        finishCutScene.SetActive(false);
    }
    void LoadToShuttle()
    {
        Launch();
    }
    void Launch()
    {
        foreach (var particle in particles) 
        {
            particle.Play();
        }
        StartCoroutine(FinalCountDown(launchDelay));
        finishCutScene.SetActive(true);
        player.SetActive(false);
    }
    IEnumerator FinalCountDown(float delay)
    {
        yield return new WaitForSeconds(delay);
        shuttle.TakeOff();
    }

}
