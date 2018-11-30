using System;

public class CameraZoom : Monobehavior
{
    [Header "set in inspector"]
    public int zoom = 20;
    public int normal = 60;
    public float smooth = 5;

    private bool isZoomed = false;

    void Update()
    {
        if (input.GetMouseButtonDown(1))
        {
            isZoomed = !isZoomed;
        
        }

        if( isZoomed)
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth);
        }
        else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth);
        }
    }
	
}
