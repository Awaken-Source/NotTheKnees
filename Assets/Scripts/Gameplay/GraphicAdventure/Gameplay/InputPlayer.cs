using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputPlayer : MonoBehaviour
{
    private PlayerActionControls input;
    private InputAction movimiento;
    private void Awake()
    {
        input = new PlayerActionControls();
    }

    void Start()
    {
        input.PlayerGraphicAdventure.Enable();
        input.PlayerDemolitionRace.Disable();
       
    }

    private void FixedUpdate()
    {
        GameManager.GM.PlayerMove(movimiento.ReadValue<Vector2>());
    }

    private void OnEnable()
    {
        movimiento = input.PlayerGraphicAdventure.Movement;
        movimiento.Enable();
        input.PlayerGraphicAdventure.Action.performed += OnAction;
        input.PlayerGraphicAdventure.Action.Enable();

        input.PlayerGraphicAdventure.Backpack.performed += OnBackpack;
        input.PlayerGraphicAdventure.Backpack.Enable();

        input.PlayerGraphicAdventure.ShowKeyObjects.performed += OnShowKeyObjects;
        input.PlayerGraphicAdventure.ShowKeyObjects.Enable();

        input.PlayerGraphicAdventure.Menu.performed += OnMenu;
        input.PlayerGraphicAdventure.Menu.Enable();

    }

    void OnAction(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerAction();
    }


    private void OnBackpack(InputAction.CallbackContext obj)
    {
        GameManager.GM.ShowDescriptionOfObtainedObject();
    }

    void OnShowKeyObjects(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerShowKeyObjects();
    }

    void OnMenu(InputAction.CallbackContext obj)
    {
        GameManager.GM.PlayerMenu();
    }

    private void OnDisable()
    {
        movimiento.Disable();
        input.PlayerGraphicAdventure.Action.performed -= OnAction;
        input.PlayerGraphicAdventure.Action.Disable();

        input.PlayerGraphicAdventure.Backpack.performed -= OnBackpack;
        input.PlayerGraphicAdventure.Backpack.Disable();

        input.PlayerGraphicAdventure.ShowKeyObjects.performed -= OnShowKeyObjects;
        input.PlayerGraphicAdventure.ShowKeyObjects.Disable();

        input.PlayerGraphicAdventure.Menu.performed -= OnMenu;
        input.PlayerGraphicAdventure.Menu.Disable();
    }
}