using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class PauseButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //public GameObject pause;
    // Start is called before the first frame update
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Time.timeScale = 0;
    }

    //Detect if clicks are no longer registering
    public void OnPointerUp(PointerEventData pointerEventData)
    {

    }

    

    private void PauseGame()
    {
        Time.timeScale = 0;
        //pause.SetActive(true);
    }

    

    
}
