using UnityEngine;
using UnityEngine.UI;

public class AmbientSoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource ambientAudioSource;
    [SerializeField] private Slider volumeSlider;

    private float mainVolume = 1.0f; // Store main volume separately

    void Start()
    {
        if (!PlayerPrefs.HasKey("ambVolume"))
        {
            PlayerPrefs.SetFloat("ambVolume", 1);
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
        mainVolume = AudioListener.volume;
        AudioListener.volume = mainVolume;

        // Calculate the ambient volume relative to main volume
        float ambientVolume = volumeSlider.value * mainVolume;
        ambientAudioSource.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("ambVolume");
        // Apply the volume immediately when loading
        mainVolume = AudioListener.volume;
        AudioListener.volume = mainVolume;
        ambientAudioSource.volume = volumeSlider.value * mainVolume;
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("ambVolume", volumeSlider.value);
    }
}
