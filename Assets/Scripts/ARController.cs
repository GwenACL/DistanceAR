using System;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using static UnityEngine.Screen;

public class ARController : MonoBehaviour
{
    public TextMeshProUGUI distanceText;
    public ARRaycastManager aRRaycastManager;
    private List<ARRaycastHit> arHits = new List<ARRaycastHit>();
    private Vector2 middleOfScreen => new Vector2(width/2, height/2);

    public void OnButtonPress()
    {
        if (aRRaycastManager.Raycast(middleOfScreen, arHits, TrackableType.PlaneWithinPolygon))
        {
            distanceText.text = "Le plan se trouve à :" + arHits[0].distance + "m.";
        }
    }
}