using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{

    float xSpeed = 5f;
    float ySpeed = 9f;

    float xAcceleration = 1f;
    float yAcceleration = 3f;

    float xVector;
    float yVector;

    public float xCalc;
    public float yCalc;

    public string leftKey;
    public string rightKey;

    public TextMeshProUGUI namePlate;
    public Vector3 offset = new Vector3(0, 0.1f, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 roll = Camera.main.WorldToScreenPoint(transform.position + offset);
        roll.z = 0f;
        namePlate.transform.position = roll;


        if (Input.GetKey(leftKey) == true && Input.GetKey(rightKey) == true)
        {

            if (yCalc < 1)
            {
                yCalc += yAcceleration * Time.deltaTime;
            }

            else if (yCalc > 1)
            {
                yCalc = 1;
            }



            if (Mathf.Abs(xCalc) <= 0.01f)
            {
                xCalc = 0;
            }

            else if (xCalc > 0)
            {
                xCalc -= xAcceleration * Time.deltaTime;
            }

            else if (xCalc < 0)
            {
                xCalc += xAcceleration * Time.deltaTime;
            }
            
        }

        else if (Input.GetKey(leftKey) == true && Input.GetKey(rightKey) == false)
        {
            yCalc = 0;
            xCalc = -1;
        }

        else if (Input.GetKey(leftKey) == false && Input.GetKey(rightKey) == true)
        {
            yCalc = 0;
            xCalc = 1;

        }

        else if (Input.GetKey(leftKey) == false && Input.GetKey(rightKey) == false)
        {
            yCalc = 0;
            xCalc = 0;
        }

        float xDirection = xCalc;

        xVector = xDirection * xSpeed * Time.deltaTime;

        float yDirection = yCalc;

        yVector = yDirection * ySpeed * Time.deltaTime;
        transform.Translate(xVector, yVector, 0);
    }
}
