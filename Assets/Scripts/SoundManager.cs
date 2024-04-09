using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider mainVolumeSlider;
    [SerializeField] private Slider ambientVolumeSlider;
    [SerializeField] private Slider musicVolumeSlider;
    [SerializeField] private AudioSource ambientAudioSource;
    [SerializeField] private AudioSource musicAudioSource;

    private void Start()
    {
        LoadVolumes();
        SetupSliderListeners();
    }

    private void LoadVolumes()
    {
        if (PlayerPrefs.HasKey("mainVolume"))
        {
            mainVolumeSlider.value = PlayerPrefs.GetFloat("mainVolume");
        }

        if (PlayerPrefs.HasKey("ambientVolume"))
        {
            ambientVolumeSlider.value = PlayerPrefs.GetFloat("ambientVolume");
        }

        if (PlayerPrefs.HasKey("musicVolume"))
        {
            musicVolumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
        }

        ApplyVolumes();
    }

    private void SetupSliderListeners()
    {
        mainVolumeSlider.onValueChanged.AddListener(OnMainVolumeChanged);
        ambientVolumeSlider.onValueChanged.AddListener(OnAmbientVolumeChanged);
        musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
    }

    private void OnMainVolumeChanged(float value)
    {
        ApplyVolumes();
        SaveVolumes();
    }

    private void OnAmbientVolumeChanged(float value)
    {
        ambientAudioSource.volume = value;
        SaveVolumes();
    }

    private void OnMusicVolumeChanged(float value)
    {
        musicAudioSource.volume = value;
        SaveVolumes();
    }

    private void ApplyVolumes()
    {
        AudioListener.volume = mainVolumeSlider.value;
        ambientAudioSource.volume = ambientVolumeSlider.value;
        musicAudioSource.volume = musicVolumeSlider.value;
    }

    private void SaveVolumes()
    {
        PlayerPrefs.SetFloat("mainVolume", mainVolumeSlider.value);
        PlayerPrefs.SetFloat("ambientVolume", ambientVolumeSlider.value);
        PlayerPrefs.SetFloat("musicVolume", musicVolumeSlider.value);
    }
}
