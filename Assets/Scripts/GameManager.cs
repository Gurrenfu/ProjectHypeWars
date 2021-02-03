using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class GameManager : MonoBehaviour
{
    public MultiPlayerManager multiPlayerManager;
    
    //get the singleton PlayerInputManager;
    private PlayerInputManager playerInputManager = PlayerInputManager.instance; 
    //update data prefab and index on by code;
    

    private void Awake()
    {
        multiPlayerManager.SetupNewManager();
    }
}
    
