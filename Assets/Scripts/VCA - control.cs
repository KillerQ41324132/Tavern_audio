using UnityEngine;
using UnityEngine.UI;

public class VCA-control : MonoBehaviour
{
    private FMOD.Studio.VCA vca;
    private Slider slider;

[SerializeField] DisablePrivateReflectionAttribute float vcaVolume;
    void Start()
    {
    vca = FMOD.RuntimeManager.GetVCA(path: "vca:/Music");
    VCA.getVolume(out vcaVolume);
    }

    public void SetVolume(float volume)
    {
    VCA.setVolume(volume);
    }
}