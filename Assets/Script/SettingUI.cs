using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{
    bool isSettingPanelEnable = false;
    bool isAudioMute = false;
    public GameObject settingPanel;
    public AudioListener audioListener;
    public Image sound, mute;
    public void OpenCloseSettingPanel()
    {
        if(isSettingPanelEnable)
        {
            isSettingPanelEnable = false;
            settingPanel.SetActive(false);
        }
        else
        {
            isSettingPanelEnable = true;
            settingPanel.SetActive(true);
        }
    }

    public void AudioOnOff()
    {
        if (isAudioMute)
        {
            sound.enabled = true;
            mute.enabled = false;
            audioListener.enabled = true;
            isAudioMute = false;
        }
        else
        {
            sound.enabled = false;
            mute.enabled = true;
            audioListener.enabled = false;
            isAudioMute = true;
        }
    }

}
