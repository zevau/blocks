using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObliqueCameraProjection : MonoBehaviour {

    public float xOblique = 0.01f;
    public float yOblique = -0.01f;
    void Start()
    {
        SetObliqueness(xOblique, yOblique);

    }
    void SetObliqueness (float horizObl, float vertObl)
    {
        Matrix4x4 matrix = Camera.main.projectionMatrix;
        matrix[0, 2] = horizObl;
        matrix[1, 2] = vertObl;
        Camera.main.projectionMatrix = matrix;
    }
}
