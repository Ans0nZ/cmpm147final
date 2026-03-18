using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingAudioController : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI percentText;
    public GameObject mutedBadge;
    public Image barFill;

    [Header("Mute Labels (Localization)")]
    public GameObject labelMute;
    public GameObject labelUnmute;

    [Header("Buttons")]
    public Button btnMinus;
    public Button btnPlus;
    public Button btnMute;

    [Header("Step")]
    public int stepPercent = 5;

    private float lastNonZero = 0.1f;

    void Start()
    {
        if (btnMinus) btnMinus.onClick.AddListener(Decrease);
        if (btnPlus)  btnPlus.onClick.AddListener(Increase);
        if (btnMute)  btnMute.onClick.AddListener(ToggleMute);

        float v = GetVol();
        if (v > 0.0001f) lastNonZero = v;

        RefreshUI();
    }

    void Decrease()
    {
        float v = Mathf.Clamp01(GetVol() - stepPercent / 100f);
        SetVol(v);
        if (v > 0.0001f) lastNonZero = v;
        RefreshUI();
    }

    void Increase()
    {
        float v = Mathf.Clamp01(GetVol() + stepPercent / 100f);
        SetVol(v);
        if (v > 0.0001f) lastNonZero = v;
        RefreshUI();
    }

    void ToggleMute()
    {
        bool muted = IsMuted();

        if (!muted)
        {
            float v = GetVol();
            if (v > 0.0001f) lastNonZero = v;

            SetVol(0f);
        }
        else
        {
            float restore = Mathf.Clamp01(lastNonZero <= 0.0001f ? 0.1f : lastNonZero);
            SetVol(restore);
        }

        RefreshUI();
    }

    float GetVol()
    {
        return Mathf.Clamp01(AudioListener.volume);
    }

    void SetVol(float v01)
    {
        // AudioListener.volume is a global master volume, so it affects
        // all active AudioSources instead of only the BGM manager.
        AudioListener.volume = Mathf.Clamp01(v01);
    }

    bool IsMuted()
    {
        return GetVol() <= 0.0001f;
    }

    void RefreshUI()
    {
        float v = GetVol();
        int pct = Mathf.RoundToInt(v * 100f);

        if (percentText) percentText.text = pct + "%";

        bool muted = IsMuted();
        if (mutedBadge) mutedBadge.SetActive(muted);

        if (labelMute) labelMute.SetActive(!muted);
        if (labelUnmute) labelUnmute.SetActive(muted);

        if (barFill) barFill.fillAmount = v;
    }
}