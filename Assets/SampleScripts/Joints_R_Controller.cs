using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joints_R_Controller : MonoBehaviour
{
    // this script updates the data model by accessing position and rotation data of right hand joints

    public JointsModelBothHands myDataModel;

    private void Update()
    {
        UpdateRightHandJointsData();
    }

    public void UpdateRightHandJointsData()
    {
        var handJointService = CoreServices.GetInputSystemDataProvider<IMixedRealityHandJointService>();

        if (handJointService != null)
        {
            myDataModel._IndexDistalJoint = handJointService.RequestJointTransform(TrackedHandJoint.IndexDistalJoint, Handedness.Right).rotation;
            myDataModel._IndexKnuckle = handJointService.RequestJointTransform(TrackedHandJoint.IndexKnuckle, Handedness.Right).rotation;
            myDataModel._IndexMiddleJoint = handJointService.RequestJointTransform(TrackedHandJoint.IndexMiddleJoint, Handedness.Right).rotation;

            myDataModel._MiddleDistalJoint = handJointService.RequestJointTransform(TrackedHandJoint.MiddleDistalJoint, Handedness.Right).rotation;
            myDataModel._MiddleKnuckle = handJointService.RequestJointTransform(TrackedHandJoint.MiddleKnuckle, Handedness.Right).rotation;
            myDataModel._MiddleMiddleJoint = handJointService.RequestJointTransform(TrackedHandJoint.MiddleMiddleJoint, Handedness.Right).rotation;


            myDataModel._PinkyDistalJoint = handJointService.RequestJointTransform(TrackedHandJoint.PinkyDistalJoint, Handedness.Right).rotation;
            myDataModel._PinkyKnuckle = handJointService.RequestJointTransform(TrackedHandJoint.PinkyKnuckle, Handedness.Right).rotation;
            myDataModel._PinkyMiddleJoint = handJointService.RequestJointTransform(TrackedHandJoint.PinkyMiddleJoint, Handedness.Right).rotation;

            myDataModel._RingDistalJoint = handJointService.RequestJointTransform(TrackedHandJoint.RingDistalJoint, Handedness.Right).rotation;
            myDataModel._RingKnuckle = handJointService.RequestJointTransform(TrackedHandJoint.RingKnuckle, Handedness.Right).rotation;
            myDataModel._RingMiddleJoint = handJointService.RequestJointTransform(TrackedHandJoint.RingMiddleJoint, Handedness.Right).rotation;

            myDataModel._ThumbDistalJoint = handJointService.RequestJointTransform(TrackedHandJoint.ThumbDistalJoint, Handedness.Right).rotation;
            myDataModel._ThumbMetacarpalJoint = handJointService.RequestJointTransform(TrackedHandJoint.ThumbMetacarpalJoint, Handedness.Right).rotation;
            myDataModel._ThumbProximalJoint = handJointService.RequestJointTransform(TrackedHandJoint.ThumbProximalJoint, Handedness.Right).rotation;

            myDataModel._WristRot = handJointService.RequestJointTransform(TrackedHandJoint.Wrist, Handedness.Right).rotation;
            myDataModel._WristPos = handJointService.RequestJointTransform(TrackedHandJoint.Wrist, Handedness.Right).position;

        }

    }
}
