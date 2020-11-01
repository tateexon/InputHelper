using UnityEngine;

public class InputTriggerHandler
{
    // trigger actions
    public delegate void TriggerAction(float output);

    public static event TriggerAction leftTrigger;
    public static event TriggerAction rightTrigger;

    public void FireTriggers(InputController inputController)
    {
        TriggerHandler(true, leftTrigger, inputController);
        TriggerHandler(false, rightTrigger, inputController);
    }

    // handle the left and right triggers
    private void TriggerHandler(bool isLeftTrigger, TriggerAction action, InputController inputController)
    {
        if (action == null)
        {
            return;
        }

        float axis;

        if (isLeftTrigger)
        {
            axis = inputController.BasicGamePad.LeftTrigger.ReadValue<float>();
        }
        else
        {
            axis = inputController.BasicGamePad.RightTrigger.ReadValue<float>();
        }

        // remove accidental bumps of the triggers
        if (Mathf.Abs(axis) < .1f)
        {
            axis = 0f;
        }

        action(axis);
    }
}
