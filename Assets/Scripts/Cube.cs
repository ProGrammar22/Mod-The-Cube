using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float locationX = 2.0f;
    private float locationY = 2.0f;
    private float locationZ = 2.0f;
    private float scale = 2.0f;
    private float rotationAngleX = 10.0f;
    private float rotationAngleY = 10.0f;
    private float rotationAngleZ = 10.0f;
    private float rotationSpeed = 5.0f;
    private float timer = 0.0f;
    private float waitTime = 2.0f;

    private Material material;

    public MeshRenderer Renderer;

    void Start()
    {
        rotaionAngleX = Random.Range(rotaionAngleX, -rotaionAngleX);
        rotationAngleY = Random.Range(rotationAngleY, -rotationAngleY);
        rotationAngleZ = Random.Range(rotationAngleZ, -rotationAngleZ);
        rotationSpeed = Random.Range(rotationSpeed, -rotationSpeed);

        transform.position = new Vector3(locationX, locationY, locationZ);
        transform.localScale = Vector3.one * scale;

        material = Renderer.material;
    }

    void Update()
    {
        timer += Time.deltaTime;
        
        transform.Rotate(rotationAngleX * Time.deltaTime * rotationSpeed, rotationAngleY * Time.deltaTime * rotationSpeed, rotationAngleZ * Time.deltaTime * rotationSpeed);

        if (timer > waitTime)
        {
            material.color = new Color(Random.Range(0, 255.0f) * Time.deltaTime, Random.Range(0, 255.0f) * Time.deltaTime, Random.Range(0, 255.0f) * Time.deltaTime, Random.Range(0, 255.0f * Time.deltaTime));

            timer = timer - waitTime;
        }
    }
}
