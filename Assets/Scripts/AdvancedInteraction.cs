using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Transform))]
public class AdvancedInteraction : MonoBehaviour
{
    private XRGrabInteractable _interactable;
    private Transform _attachTransform;

    private void Start()
    {
        _interactable = GetComponent<XRGrabInteractable>();
        AssignXREvents();
    }

    private void AssignXREvents()
    {
        _interactable.selectEntered.AddListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (_attachTransform == null)
        {
            _attachTransform = new GameObject().transform;
            _interactable.attachTransform = _attachTransform;
        }

        _attachTransform.parent = null;
        _attachTransform.position = _interactable.firstInteractorSelecting.transform.position;
        _attachTransform.rotation = _interactable.firstInteractorSelecting.transform.rotation;
        _attachTransform.parent = transform;
    }
}
