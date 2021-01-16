using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public PlayerLocomotion playerLocomotion;
    public PlayerCombat playerCombat;

    [HideInInspector]public PlayerInput pi;

    private void Awake()
    {
        pi = GetComponent<PlayerInput>();
        pi.onActionTriggered += Input_OnActionTrigger;
    }

    public void AssignInput(PlayerInput newPlayerInput)
    {
        pi.onActionTriggered -= Input_OnActionTrigger;
        pi = newPlayerInput;
        pi.onActionTriggered += Input_OnActionTrigger;
    }
    
    private void Input_OnActionTrigger(InputAction.CallbackContext obj)
    {
        switch (obj.action.name)
        {
            //Locmotion actions
            case "Jump":
                playerLocomotion.Jump(obj);
                break;
            case "Crouch":
                playerLocomotion.Crouch(obj);
                break;
            case "Move":
                playerLocomotion.Move(obj);
                break;
            //Combat actions
            case "Shoot":
                playerCombat.Shoot(obj);
                break;
            case "Melee":
                playerCombat.SimpleMelee(obj);
                break;
            case "gamepadAim":
                playerCombat.GamepadMoveCrosshair(obj);
                break;
            case "mouseAim":
                playerCombat.MouseMoveCrosshair(obj);
                break;
        }
    }

} 
