using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomIn : MonoBehaviour
{
    private float zoom;
    private float minZoom = 2.5f;
    private float velocity = 0f;
    private float smoothTime = 0.5f;

    [SerializeField] private Camera cam;

    [SerializeField] private Button zoomInButton;

    public void ZoomInButtonClicked()
    {
        StartCoroutine(ZoomInCoroutine());
    }

    private IEnumerator ZoomInCoroutine()
    {
        float currentZoom = cam.orthographicSize;
        float targetZoom = minZoom;

        while (Mathf.Abs(cam.orthographicSize - targetZoom) > 0.01f)
        {
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, targetZoom, ref velocity, smoothTime);

            yield return null;
        }
    }
}
