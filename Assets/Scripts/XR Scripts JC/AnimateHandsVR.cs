using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandsVR : MonoBehaviour
{
    public InputActionProperty triggerActionProperty, gripActionProperty;
    private Animator animatorHands;

    // Start is called before the first frame update
    void Start()
    {
        animatorHands = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float triggerNewValue = triggerActionProperty.action.ReadValue<float>();
        animatorHands.SetFloat("Trigger", triggerNewValue);

        float gripNewValue = gripActionProperty.action.ReadValue<float>();
        animatorHands.SetFloat("Grip", gripNewValue);
    }
}
