using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject SettingsUI,GameOverUI,PauseUI,LevelCompleteUI;

    [SerializeField] Slider brightnessSlider,saturationSlider,contrastSlider;

    Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        GetCamera();
    }


    private void Update()
    {
        if (canvas.worldCamera == null)
        {
            GetCamera();
        }
    }
    public void GetCamera()
    {
        canvas.worldCamera = Camera.main;
    }

    public GameObject GetSettingsUI()
    {
        return SettingsUI;
    }

    public GameObject GetPauseUI(){
        return PauseUI;
    }

    public GameObject GetGameOverUI(){
        return GameOverUI;
    }

    public GameObject GetLevelCompleteUI(){
        return LevelCompleteUI;
    }

    public Slider GetBrightness()
    {
        
        return brightnessSlider;
    }

    public Slider GetContrast()
    {
        return contrastSlider;
    }

    public Slider GetSaturation()
    {
        return saturationSlider;
    }
}
