using UnityEngine;

public class InputStickHandler
{
    // axis actions
    public delegate void AxisAction(Vector2 output);

    public static event AxisAction leftStick;
    public static event AxisAction rightStick;

    public void FireSticks(InputController inputController)
    {
        AxisStickHandler(true, leftStick, inputController);
        AxisStickHandler(false, rightStick, inputController);
    }

    private void AxisStickHandler(bool isLeftStick, AxisAction action, InputController inputController)
    {
        if (action == null)
        {
            return;
        }

        // if left stick get the movement, else get the rotation
        if (isLeftStick)
        {
            AxisValidate(inputController.BasicGamePad.Move.ReadValue<Vector2>(), action);
        }
        else
        {
           AxisValidate(inputController.BasicGamePad.Rotate.ReadValue<Vector2>(), action);
        }
    }

    // Validate an axis is not a tiny movement and if not so, fire the action
    private void AxisValidate(Vector2 movement, AxisAction action)
    {
        // get rid of tiny movement locks on controller that causes bugs
        if (Mathf.Abs(movement.x) < .1f)
        {
            movement.x = 0f;
        }
        if (Mathf.Abs(movement.y) < .1f)
        {
            movement.y = 0f;
        }

        action(movement);
    }
}
