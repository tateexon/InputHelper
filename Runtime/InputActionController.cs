using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using static UnityEngine.InputSystem.InputAction;

public class InputActionController : MonoBehaviour
{
    // buttons
    InputButtonHandler buttons;

    // triggers
    InputTriggerHandler triggers;

    // sticks
    InputStickHandler sticks;

    private InputController inputController;
    private void Awake()
    {
        // limit to 1 input action controller
        int numberOfInputControllers = FindObjectsOfType<InputActionController>().Length;
        if (numberOfInputControllers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        inputController = new InputController();
        buttons = new InputButtonHandler();
        triggers = new InputTriggerHandler();
        sticks = new InputStickHandler();
    }
    #region EnableDisable
    private void OnEnable()
    {
        inputController.Enable();
        buttons.Enable(inputController);
    }
    private void OnDisable()
    {
        inputController.Disable();
        buttons.Disable(inputController);
    }
    #endregion EnableDisable

    /// <summary>
    /// Call all the actions
    /// </summary>
    void FixedUpdate()
    {
        buttons.FireButtonEvents();
        triggers.FireTriggers(inputController);
        sticks.FireSticks(inputController);
    }
}
