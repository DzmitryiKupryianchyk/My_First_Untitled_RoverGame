using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchStation : MonoBehaviour, IResponsible
{
    bool readyToLaunch;
    public float launchDelay;
    public GameObject player;
    public GameObject finishCutScene;
    public SpaceShuttleBehavior shuttle;
    public ParticleSystem[] particles;
    //public ParticleSystem smokeParticles1;
    //public ParticleSystem smokeParticles2;
    [SerializeField] MeshRenderer rocket;
    public void Respond(bool state)
    {
        if (TaskControlManager.Instance.IsReadyToLaunch())
        {
            LoadToShuttle();
        }
        else return;
    }

    // Start is called before the first frame update
    void Start()
    {
        finishCutScene.SetActive(false);
        //readyToLaunch = false;
        //shuttle = GetComponent<SpaceShuttleBehavior>();
    }
    void LoadToShuttle()
    {
        //readyToLaunch = true;
        Launch();

    }
    void Launch()
    {
        //smokeParticles1.Play();
        //smokeParticles2.Play();
        //rocket.transform.parent = null;
        //shuttle.TakeOff();
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
