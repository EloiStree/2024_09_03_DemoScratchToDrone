using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyInputForDrone : MonoBehaviour
{

    public MyFirstDrone m_whatToAffect;

    public InputActionReference m_moveLeftRight;
    public InputActionReference m_moveBackForward;
    public InputActionReference m_moveDownUp;
    public InputActionReference m_rotateLeftRight;


    public void OnEnable()
    {

        m_moveLeftRight.action.Enable();
        m_moveBackForward.action.Enable();
        m_moveDownUp.action.Enable();
        m_rotateLeftRight.action.Enable();
        

    }

    public void OnDisable()
    {
        m_moveLeftRight.action.Disable();
        m_moveBackForward.action.Disable();
        m_moveDownUp.action.Disable();
        m_rotateLeftRight.action.Disable();
    }


    private void Update()
    {
        if (m_whatToAffect == null)
        {
            return;
        }

        m_whatToAffect.m_speedPercentLateral = m_moveLeftRight.action.ReadValue<float>();
        m_whatToAffect.m_speedPercentForward = m_moveBackForward.action.ReadValue<float>();
        m_whatToAffect.m_speedPercentVertical = m_moveDownUp.action.ReadValue<float>();
        m_whatToAffect.m_speedAnglePercentHorizontal = m_rotateLeftRight.action.ReadValue<float>();

    }


}
