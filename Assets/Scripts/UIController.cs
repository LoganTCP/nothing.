using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public CanvasScaler titleCanvasScaler;
    public CanvasScaler pauseCanvasScaler;
    public CanvasScaler settingsCanvasScaler;
    public CanvasScaler audioCanvasScaler;
    public CanvasScaler displayCanvasScaler;

    public void ScaleUI853 ()
    {
        titleCanvasScaler.referenceResolution = new Vector2(853, 480);
        pauseCanvasScaler.referenceResolution = new Vector2(853, 480);
        settingsCanvasScaler.referenceResolution = new Vector2(853, 480);
        audioCanvasScaler.referenceResolution = new Vector2(853, 480);
        displayCanvasScaler.referenceResolution = new Vector2(853, 480);
    }

    public void ScaleUI720 ()
    {
        titleCanvasScaler.referenceResolution = new Vector2(1280, 720);
        pauseCanvasScaler.referenceResolution = new Vector2(1280, 720);
        settingsCanvasScaler.referenceResolution = new Vector2(1280, 720);
        audioCanvasScaler.referenceResolution = new Vector2(1280, 720);
        displayCanvasScaler.referenceResolution = new Vector2(1280, 720);
    }

    public void ScaleUI1080 ()
    {
        titleCanvasScaler.referenceResolution = new Vector2(1920, 1080);
        pauseCanvasScaler.referenceResolution = new Vector2(1920, 1080);
        settingsCanvasScaler.referenceResolution = new Vector2(1920, 1080);
        audioCanvasScaler.referenceResolution = new Vector2(1920, 1080);
        displayCanvasScaler.referenceResolution = new Vector2(1920, 1080);
    }

    public void ScaleUI1440 ()
    {
        titleCanvasScaler.referenceResolution = new Vector2(2560, 1440);
        pauseCanvasScaler.referenceResolution = new Vector2(2560, 1440);
        settingsCanvasScaler.referenceResolution = new Vector2(2560, 1440);
        audioCanvasScaler.referenceResolution = new Vector2(2560, 1440);
        displayCanvasScaler.referenceResolution = new Vector2(2560, 1440);
    }
}
