using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneTransition : MonoBehaviour
{
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadMainScene());
    }
    private IEnumerator LoadMainScene()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainGameScene");
    }
}
