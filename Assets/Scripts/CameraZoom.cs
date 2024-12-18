using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEditor;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    float minZoom = 2.5f;
    float maxZoom = 6f;
    float desiredZoom;
    CinemachineVirtualCamera camera;
    float zoomSpeed;
    
    void Start(){
        ShipInput shipInput = FindObjectOfType<ShipInput>();
        if(shipInput != null){
            shipInput.OnSpeedChanged += adjustZoomValues;
        }
        camera = GetComponent<CinemachineVirtualCamera>();
        camera.m_Lens.OrthographicSize = maxZoom;
        desiredZoom = camera.m_Lens.OrthographicSize;
        zoomSpeed = 6f;

    }
    void Update(){
        if(Math.Abs(camera.m_Lens.OrthographicSize - desiredZoom) > .01f){
            applyZoomChange();
        }
    }

    // Start is called before the first frame update

    void adjustZoomValues(float speed, float maxSpeed){
        float t = Mathf.Clamp01(speed / maxSpeed);
        desiredZoom = Mathf.Lerp(minZoom,maxZoom,t);
    }

    void applyZoomChange(){
        camera.m_Lens.OrthographicSize = Mathf.Lerp(camera.m_Lens.OrthographicSize, desiredZoom, zoomSpeed * Time.deltaTime);
    }
}
