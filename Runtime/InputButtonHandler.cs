using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using static UnityEngine.InputSystem.InputAction;

public class InputButtonHandler
{
    // button actions
    public delegate void ButtonAction(bool isDown);

    #region Button Action Variable
    public static event ButtonAction buttonNorth;
    public static event ButtonAction buttonSouth;
    public static event ButtonAction buttonEast;
    public static event ButtonAction buttonWest;

    public static event ButtonAction leftShoulder;
    public static event ButtonAction rightShoulder;

    public static event ButtonAction leftStick;
    public static event ButtonAction rightStick;

    public static event ButtonAction select;
    public static event ButtonAction start;

    public static event ButtonAction dPadLeft;
    public static event ButtonAction dPadRight;
    public static event ButtonAction dPadUp;
    public static event ButtonAction dPadDown;
    #endregion Button Action Variable

    private Dictionary<string, ButtonPressed> buttonMap = new Dictionary<string, ButtonPressed>();

    public InputButtonHandler()
    {
        buttonMap = new Dictionary<string, ButtonPressed>();
        // add all the buttons to the queue object
        if (!buttonMap.ContainsKey(InputEnum.NORTH))
        {
            buttonMap.Add(InputEnum.NORTH, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.SOUTH))
        {
            buttonMap.Add(InputEnum.SOUTH, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.EAST))
        {
            buttonMap.Add(InputEnum.EAST, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.WEST))
        {
            buttonMap.Add(InputEnum.WEST, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.LEFT_SHOULDER))
        {
            buttonMap.Add(InputEnum.LEFT_SHOULDER, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.RIGHT_SHOULDER))
        {
            buttonMap.Add(InputEnum.RIGHT_SHOULDER, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.LEFT_STICK))
        {
            buttonMap.Add(InputEnum.LEFT_STICK, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.RIGHT_STICK))
        {
            buttonMap.Add(InputEnum.RIGHT_STICK, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.START))
        {
            buttonMap.Add(InputEnum.START, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.SELECT))
        {
            buttonMap.Add(InputEnum.SELECT, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.DPAD_LEFT))
        {
            buttonMap.Add(InputEnum.DPAD_LEFT, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.DPAD_RIGHT))
        {
            buttonMap.Add(InputEnum.DPAD_RIGHT, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.DPAD_UP))
        {
            buttonMap.Add(InputEnum.DPAD_UP, new ButtonPressed());
        }
        if (!buttonMap.ContainsKey(InputEnum.DPAD_DOWN))
        {
            buttonMap.Add(InputEnum.DPAD_DOWN, new ButtonPressed());
        }
    }

    #region EnableDisable
    public void Enable(InputController inputController)
    {
        inputController.BasicGamePad.North.performed += NorthHandler;
        inputController.BasicGamePad.South.performed += SouthHandler;
        inputController.BasicGamePad.East.performed += EastHandler;
        inputController.BasicGamePad.West.performed += WestHandler;
        inputController.BasicGamePad.LeftShoulder.performed += LeftShoulderHandler;
        inputController.BasicGamePad.RightShoulder.performed += RightShoulderHandler;
        inputController.BasicGamePad.LeftStickPress.performed += LeftStickHandler;
        inputController.BasicGamePad.RightStickPress.performed += RightStickHandler;
        inputController.BasicGamePad.Start.performed += StartHandler;
        inputController.BasicGamePad.Select.performed += SelectHandler;
        inputController.BasicGamePad.DPadLeft.performed += DPadLeftHandler;
        inputController.BasicGamePad.DPadRight.performed += DPadRightHandler;
        inputController.BasicGamePad.DPadUp.performed += DPadUpHandler;
        inputController.BasicGamePad.DPadDown.performed += DPadDownHandler;
    }

    public void Disable(InputController inputController)
    {
        inputController.BasicGamePad.North.performed -= NorthHandler;
        inputController.BasicGamePad.South.performed -= SouthHandler;
        inputController.BasicGamePad.East.performed -= EastHandler;
        inputController.BasicGamePad.West.performed -= WestHandler;
        inputController.BasicGamePad.LeftShoulder.performed -= LeftShoulderHandler;
        inputController.BasicGamePad.RightShoulder.performed -= RightShoulderHandler;
        inputController.BasicGamePad.LeftStickPress.performed -= LeftStickHandler;
        inputController.BasicGamePad.RightStickPress.performed -= RightStickHandler;
        inputController.BasicGamePad.Start.performed -= StartHandler;
        inputController.BasicGamePad.Select.performed -= SelectHandler;
        inputController.BasicGamePad.DPadLeft.performed -= DPadLeftHandler;
        inputController.BasicGamePad.DPadRight.performed -= DPadRightHandler;
        inputController.BasicGamePad.DPadUp.performed -= DPadUpHandler;
        inputController.BasicGamePad.DPadDown.performed -= DPadDownHandler;
    }
    #endregion EnableDisable

    /// <summary>
    /// Fire all the button events in the order they were pressed/released
    /// Preferably use this method in a FixedUpdate
    /// </summary>
    public void FireButtonEvents()
    {
        // main buttons
        FireEvent(InputEnum.NORTH, buttonNorth);
        FireEvent(InputEnum.SOUTH, buttonSouth);
        FireEvent(InputEnum.EAST, buttonEast);
        FireEvent(InputEnum.WEST, buttonWest);

        // dpad
        FireEvent(InputEnum.DPAD_UP, dPadUp);
        FireEvent(InputEnum.DPAD_DOWN, dPadDown);
        FireEvent(InputEnum.DPAD_RIGHT, dPadRight);
        FireEvent(InputEnum.DPAD_LEFT, dPadLeft);

        // shoulder
        FireEvent(InputEnum.LEFT_SHOULDER, leftShoulder);
        FireEvent(InputEnum.RIGHT_SHOULDER, rightShoulder);

        // stick
        FireEvent(InputEnum.LEFT_STICK, leftStick);
        FireEvent(InputEnum.RIGHT_STICK, rightStick);

        // select/start
        FireEvent(InputEnum.START, start);
        FireEvent(InputEnum.SELECT, select);
    }

    #region Button Handlers
    private void NorthHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.NORTH, ctx);
    }
    private void SouthHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.SOUTH, ctx);
    }
    private void EastHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.EAST, ctx);
    }
    private void WestHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.WEST, ctx);
    }
    private void LeftShoulderHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.LEFT_SHOULDER, ctx);
    }
    private void RightShoulderHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.RIGHT_SHOULDER, ctx);
    }
    private void LeftStickHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.LEFT_STICK, ctx);
    }
    private void RightStickHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.RIGHT_STICK, ctx);
    }
    private void StartHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.START, ctx);
    }
    private void SelectHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.SELECT, ctx);
    }
    private void DPadLeftHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.DPAD_LEFT, ctx);
    }
    private void DPadRightHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.DPAD_RIGHT, ctx);
    }
    private void DPadUpHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.DPAD_UP, ctx);
    }
    private void DPadDownHandler(CallbackContext ctx)
    {
        QueueButtonPress(InputEnum.DPAD_DOWN, ctx);
    }
    #endregion Button Handlers

    /// <summary>
    /// Queue up button presses
    /// </summary>
    /// <param name="input">The name of the button pressed from the InputEnum class</param>
    /// <param name="ctx">The callback context</param>
    private void QueueButtonPress(string input, CallbackContext ctx)
    {
        var buttonControl = ctx.control as ButtonControl;
        ButtonPressed button = buttonMap[input];
        if (buttonControl.wasPressedThisFrame)
        {
            button.isDown = true;
            button.isPressed = true;
        }
        else
        {
            button.isUp = true;
            button.isPressed = true;
        }
    }

    private void FireEvent(string input, ButtonAction action)
    {
        if (action == null)
        {
            return;
        }

        ButtonPressed button = buttonMap[input];
        if (button == null)
        {
            return;
        }

        if (button.isPressed)
        {
            // handle button down
            if (button.isDown)
            {
                action(true);
                button.isDown = false;
            }

            // handle button up
            if (button.isUp)
            {
                action(false);
                button.isUp = false;
            }

            button.isPressed = false;
        }
    }
}

class ButtonPressed
{
    public bool isDown;
    public bool isUp;
    public bool isPressed;
}