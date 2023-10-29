using TMPro;
using UnityEngine;

public class FPS: MonoBehaviour
{
    float fps;
    [SerializeField] float updateFrequency = 0.2f;
    float updateTimer;

    [SerializeField] bool isDisplayed = true;

    [SerializeField] TextMeshProUGUI fpsTitle;

    private void Start()
    {
        updateTimer = updateFrequency;
        fpsTitle.enabled = isDisplayed;
    }

    private void Update()
    {
        ToggleFPSDisplay();
        UpdateFPSDisplay();
    }

    private void ToggleFPSDisplay()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (isDisplayed)
            {
                fpsTitle.enabled = false;
                isDisplayed = false;
            }
            else
            {
                fpsTitle.enabled = true;
                isDisplayed = true;
            }
             
        }
    }

    private void UpdateFPSDisplay()
    {
        updateTimer -= Time.deltaTime;
        if(updateTimer <= 0f )
        {
            fps = 1f/Time.unscaledDeltaTime;
            fpsTitle.text = "FPS: " + Mathf.Round(fps);
            updateTimer = updateFrequency;
        }
    }
}
