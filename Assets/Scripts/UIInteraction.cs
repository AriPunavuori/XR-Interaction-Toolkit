using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIInteraction : MonoBehaviour
{
    public TextMeshProUGUI hoverTextfield;
    public TextMeshProUGUI buttonTextfield;
    
    public Image loading;

    float hoverStart;
    float hoverTime = 1f;
    float resetTime = 1f;

    public void BTN_ChangeText()
    {
        buttonTextfield.text = "Ouch!";
        Invoke("ResetPressButton", resetTime);
    }

    public void HOVER_Enter()
    {
        Invoke("ChangeHoverButtonText", hoverTime);
        hoverStart = Time.time;
        LoadingIndicator();
    }

    public void HOVER_Exit()
    {
        CancelInvoke("ChangeHoverButtonText");
        hoverStart = 0;
    }

    void ChangeHoverButtonText()
    {
        hoverTextfield.text = "Stop Gazing!";
        Invoke("ResetHoverButton", resetTime);
    }

    void ResetPressButton()
    {
        buttonTextfield.text = "Press Me!";        
    }

    void ResetHoverButton()
    {
        hoverTextfield.text = "Looky At Me!";
    }

    void LoadingIndicator()
    {        
        loading.fillAmount = Mathf.Lerp(0f, 1f, (Time.time - hoverStart) / hoverTime); 

        if (Time.time < hoverStart + hoverTime)        
            Invoke("LoadingIndicator", .01f);            
        else
            loading.fillAmount = 0f;
    }
}
