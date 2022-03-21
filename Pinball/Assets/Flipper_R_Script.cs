using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_R_Script : MonoBehaviour
{
    public float restPosition;
    public float pressedPosition;
    public float hitStrength = 100000f;
    public float flipperDamper = 100f;

    private HingeJoint hinge;

    private void Awake()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
    }
    private void Start()
    {

    }
    private void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrength;
        spring.damper = flipperDamper;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            spring.targetPosition = pressedPosition;
        }
        else
        {
            spring.targetPosition = restPosition;
        }
        hinge.spring = spring;
        hinge.useLimits = true;
    }
}
