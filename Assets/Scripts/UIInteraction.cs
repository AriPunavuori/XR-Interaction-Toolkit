using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIInteraction : MonoBehaviour
{
    public TextMeshProUGUI hoverTextfield;
    public TextMeshProUGUI buttonTextfield;
    
    public Image loading;

    private float _hoverStart;
    private const float HoverTime = 1f;
    private const float ResetTime = 1f;

    public void BTN_ChangeText()
    {
        buttonTextfield.text = "Ouch!";
        Invoke(nameof(ResetPressButton), ResetTime);
    }

    public void HOVER_Enter()
    {
        Invoke(nameof(ChangeHoverButtonText), HoverTime);
        _hoverStart = Time.time;
        LoadingIndicator();
    }

    public void HOVER_Exit()
    {
        CancelInvoke(nameof(ChangeHoverButtonText));
        _hoverStart = 0;
    }

    void ChangeHoverButtonText()
    {
        hoverTextfield.text = "Stop Gazing!";
        Invoke(nameof(ResetHoverButton), ResetTime);
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
        loading.fillAmount = Mathf.Lerp(0f, 1f, (Time.time - _hoverStart) / HoverTime); 

        if (Time.time < _hoverStart + HoverTime)        
            Invoke(nameof(LoadingIndicator), .01f);            
        else
            loading.fillAmount = 0f;
    }
}
