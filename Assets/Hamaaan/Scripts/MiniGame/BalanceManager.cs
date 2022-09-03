using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceManager : MonoBehaviour
{
    [SerializeField] HingeJoint2D joint;

    [SerializeField] bool isBalanced = false;

    JointAngleLimits2D defaultLimits;

    // Start is called before the first frame update
    void Start()
    {
        joint = joint.GetComponent<HingeJoint2D>();
        defaultLimits = joint.limits;
    }

    // Update is called once per frame
    void Update()
    {
        JointAngleLimits2D BalanceLimits = new JointAngleLimits2D();
        BalanceLimits.max = 0;
        BalanceLimits.min = 0;

        if (isBalanced)
        {
            
            joint.limits = BalanceLimits;
        }
        else
        {
            joint.limits = defaultLimits;
        }
    }
}
