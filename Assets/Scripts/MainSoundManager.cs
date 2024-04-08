using UnityEngine;
using UnityEngine.UI;

public class MainSoundManager : MonoBehaviour
{
    [SerializeField] private Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("mainVolume"))
        {
            PlayerPrefs.SetFloat("mainVolume", 1);
            Load();
        }
        else
        {
            Load();
        }

        // Add listener to the volume slider's On Value Changed event
        volumeSlider.onValueChanged.AddListener(delegate { ChangeVolume(); });
    }

    // Called when the volume slider changes
    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("mainVolume");
        // Apply the volume immediately when loading
        AudioListener.volume = volumeSlider.value;
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("mainVolume", volumeSlider.value);
    }
}
