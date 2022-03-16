using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AndvancedInteraction : MonoBehaviour
{
    XRGrabInteractable interactable;
    Transform attachTransform;

    private void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        AssignXREvents();
    }

    void AssignXREvents()
    {
        interactable.selectEntered.AddListener(OnSelectEntered);
    }

    void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (attachTransform == null)
        {
            attachTransform = new GameObject().transform;
            interactable.attachTransform = attachTransform;
        }

        attachTransform.parent = null;
        attachTransform.position = interactable.firstInteractorSelecting.transform.position;
        attachTransform.rotation = interactable.firstInteractorSelecting.transform.rotation;
        attachTransform.parent = transform;
    }
}
