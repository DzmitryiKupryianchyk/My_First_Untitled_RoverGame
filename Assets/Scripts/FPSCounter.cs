using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour
{
    public TMP_Text fpsText;
    public TMP_Text msText;
    public float updateInterval;

    private float timeSinceLastUpdate;
    private int frameCount;
    private float deltaTime;

    void Update()
    {
        frameCount++;
        deltaTime += Time.unscaledDeltaTime;

        timeSinceLastUpdate += Time.unscaledDeltaTime;
        if (timeSinceLastUpdate >= updateInterval)
        {
            float fps = frameCount / timeSinceLastUpdate;
            float ms = deltaTime / frameCount * 1000.0f;

            UpdateFPSDisplay(fps, ms);
            timeSinceLastUpdate = 0f;
            frameCount = 0;
            deltaTime = 0f;
        }
    }

    void UpdateFPSDisplay(float fps, float ms)
    {
        //if (fps < 30)
        //    fpsText.color = Color.red;
        //else if (fps < 50)
        //    fpsText.color = Color.yellow;
        //else
        //    fpsText.color = Color.green;

        //fpsText.text = $"FPS: {fps:F1}";
        Color targetColor;
        if (fps < 30)
            targetColor = Color.red;
        else if (fps < 50)
            targetColor = Color.yellow;
        else
            targetColor = Color.green;

        fpsText.color = Color.Lerp(fpsText.color, targetColor, Time.deltaTime * 15);
        msText.color = Color.Lerp(fpsText.color, targetColor, Time.deltaTime * 15);
        fpsText.text = $"FPS: {fps:F1}";
        msText.text = $"CPU: {ms:F1} ms";
    }

    void UpdateMSDisplay(float ms)
    {
        //msText.text = $"CPU: {ms:F1} ms";
    }
}
