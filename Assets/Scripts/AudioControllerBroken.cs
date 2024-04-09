using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    [SerializeField] private Slider mainVolumeSlider;
    [SerializeField] private Slider ambientVolumeSlider;
    [SerializeField] private Slider musicVolumeSlider;

    [SerializeField] private AudioMixer audioMixer; // Reference to the Audio Mixer
    [SerializeField] private AudioMixerGroup ambientMixerGroup; // Reference to the Ambient Audio Mixer Group
    [SerializeField] private AudioMixerGroup musicMixerGroup; // Reference to the Music Audio Mixer Group

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
        ambientMixerGroup.audioMixer.SetFloat("Ambient", ConvertToDecibels(value)); // Set the ambient volume level in the Ambient Audio Mixer Group
        SaveVolumes();
    }

    private void OnMusicVolumeChanged(float value)
    {
        musicMixerGroup.audioMixer.SetFloat("Music", ConvertToDecibels(value)); // Set the music volume level in the Music Audio Mixer Group
        SaveVolumes();
    }

    private void ApplyVolumes()
    {
        audioMixer.SetFloat("MainVolume", ConvertToDecibels(mainVolumeSlider.value)); // Set the main volume level in the Audio Mixer
    }

    private void SaveVolumes()
    {
        PlayerPrefs.SetFloat("mainVolume", mainVolumeSlider.value);
        PlayerPrefs.SetFloat("ambientVolume", ambientVolumeSlider.value);
        PlayerPrefs.SetFloat("musicVolume", musicVolumeSlider.value);
    }

    private float ConvertToDecibels(float value)
    {
        return Mathf.Log10(value) * 20f; // Convert linear value to decibels
    }
}
