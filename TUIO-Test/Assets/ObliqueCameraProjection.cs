using System.Collections;
using UnityEngine;

public class ObliqueCameraProjection : MonoBehaviour {

    public Vector2 obliqueShift;

    void Start()
    {
        ApplyObliqueness(obliqueShift.x, obliqueShift.y);

    }
    void ApplyObliqueness (float hShift, float vShift)
    {

        Matrix4x4 matrix = Camera.main.projectionMatrix;
        matrix[0, 2] = hShift * 0.1f;
        matrix[1, 2] = vShift * 0.1f;
        Camera.main.projectionMatrix = matrix;
        //Camera correction moves the camera to neutralize the skewed projection
        Vector3 cameraCorrection = new Vector3(hShift * transform.position.z, vShift * transform.position.z * 1/Camera.main.aspect, 0);
        transform.position += cameraCorrection;
    }
}
