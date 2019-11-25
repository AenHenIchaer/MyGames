using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class HayMachineSwitcher : MonoBehaviour, IPointerClickHandler
{
    public GameObject blueHayMachine;
    public GameObject yellowhayMachine;
    public GameObject redHayMachine;
    private int selectedIndex;

public void OnPointerClick(PointerEventData eventData)
    {
        selectedIndex++;
        selectedIndex %= Enum.GetValues(typeof(HayMachineColor)).Length;
        GameSettings.hayMachineColor = (HayMachineColor)selectedIndex;
        switch (GameSettings.hayMachineColor)
        {
            case HayMachineColor.Blue:
                blueHayMachine.SetActive(true);
                yellowhayMachine.SetActive(false);
                redHayMachine.SetActive(false);
                break;
            case HayMachineColor.Yellow:
                blueHayMachine.SetActive(false);
                yellowhayMachine.SetActive(true);
                redHayMachine.SetActive(false);
                break;
            case HayMachineColor.Red:
                blueHayMachine.SetActive(false);
                yellowhayMachine.SetActive(false);
                redHayMachine.SetActive(true);
                break;
          
        }
    }
}
