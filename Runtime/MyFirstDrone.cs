using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstDrone : MonoBehaviour
{

    [Range(-1, 1)]
    public float m_speedPercentForward;
    [Range(-1, 1)]
    public float m_speedPercentLateral;
    [Range(-1, 1)]
    public float m_speedPercentVertical;
    [Range(-1, 1)]
    public float m_speedAnglePercentHorizontal;

    [Tooltip("In Meter per seconds Value")]
    public float m_moveDroneSpeedMeterPerSecond = 10;
    [Tooltip("In Angle per seconds value")]
    public float m_rotateDroneSpeedAnglePerSecond = 180;


    [Range(0,360)]
    public float m_horizontalAngle = 0;


    public Transform m_whatToMove;

    void Start()
    {
    }
    void Update()
    {
        m_whatToMove.Translate(
            Vector3.forward * 
            (Time.deltaTime * 
            m_moveDroneSpeedMeterPerSecond *
            m_speedPercentForward), Space.Self);

        m_whatToMove.Translate(Vector3.right * (Time.deltaTime * m_moveDroneSpeedMeterPerSecond * m_speedPercentLateral), Space.Self);
        m_whatToMove.Translate(Vector3.up * (Time.deltaTime * m_moveDroneSpeedMeterPerSecond * m_speedPercentVertical), Space.Self);
      

        m_horizontalAngle+= m_rotateDroneSpeedAnglePerSecond * Time.deltaTime * m_speedAnglePercentHorizontal;

        m_whatToMove.rotation = Quaternion.Euler(0, m_horizontalAngle, 0);


        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //m_speedPercentForward = vertical;
        //m_speedPercentLateral = horizontal;

        //bool isGoingLeft = Input.GetKey(KeyCode.Q);
        //bool isGoingRight = Input.GetKey(KeyCode.D);
        //float horizontal = 0;
        //if (isGoingLeft)
        //{
        //    horizontal += -1;
        //}
        //if (isGoingRight)
        //{
        //    horizontal += 1;
        //}
        //m_speedAnglePercentHorizontal = horizontal;


        //m_whatToMove.Rotate(Vector3.up,
        //    m_rotateDroneSpeedAnglePerSecond
        //    * Time.deltaTime
        //    * m_speedAnglePercentHorizontal, Space.Self);

    }
}
