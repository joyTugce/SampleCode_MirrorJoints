using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JointsModelBothHands: MonoBehaviour
{
    // this script stores joint position and rotation values for both hands


    public delegate void UpdatePose();
    public static event UpdatePose onPoseUpdate;

    private Vector3 _wristPos;
    private Quaternion _wristRot,
    _indexDistalJoint, _indexKnuckle, _indexMiddleJoint, 
    _middleDistalJoint, _middleKnuckle, _middleMiddleJoint, 
    _pinkyDistalJoint, _pinkyKnuckle, _pinkyMiddleJoint,
    _ringDistalJoint, _ringKnuckle, _ringMiddleJoint,
    _thumbDistalJoint, _thumbMetacarpalJoint, _thumbProximalJoint; 


    public Quaternion _IndexDistalJoint
    {
        get
        {
            return _indexDistalJoint;
        }

        set
        {
            if (_indexDistalJoint != value)
            {
                _indexDistalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _IndexKnuckle
    {
        get
        {
            return _indexKnuckle;
        }

        set
        {
            if (_indexKnuckle != value)
            {
                _indexKnuckle = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _IndexMiddleJoint
    {
        get
        {
            return _indexMiddleJoint;
        }

        set
        {
            if (_indexMiddleJoint != value)
            {
                _indexMiddleJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _MiddleDistalJoint
    {
        get
        {
            return _middleDistalJoint;
        }

        set
        {
            if (_middleDistalJoint != value)
            {
                _middleDistalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _MiddleKnuckle
    {
        get
        {
            return _middleKnuckle;
        }

        set
        {
            if (_middleKnuckle != value)
            {
                _middleKnuckle = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _MiddleMiddleJoint
    {
        get
        {
            return _middleMiddleJoint;
        }

        set
        {
            if (_middleMiddleJoint != value)
            {
                _middleMiddleJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _PinkyDistalJoint
    {
        get
        {
            return _pinkyDistalJoint;
        }

        set
        {
            if (_pinkyDistalJoint != value)
            {
                _pinkyDistalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _PinkyKnuckle
    {
        get
        {
            return _pinkyKnuckle;
        }

        set
        {
            if (_pinkyKnuckle != value)
            {
                _pinkyKnuckle = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _PinkyMiddleJoint
    {
        get
        {
            return _pinkyMiddleJoint;
        }

        set
        {
            if (_pinkyMiddleJoint != value)
            {
                _pinkyMiddleJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _RingDistalJoint
    {
        get
        {
            return _ringDistalJoint;
        }

        set
        {
            if (_ringDistalJoint != value)
            {
                _ringDistalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _RingKnuckle
    {
        get
        {
            return _ringKnuckle;
        }

        set
        {
            if (_ringKnuckle != value)
            {
                _ringKnuckle = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _RingMiddleJoint
    {
        get
        {
            return _ringMiddleJoint;
        }

        set
        {
            if (_ringMiddleJoint != value)
            {
                _ringMiddleJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _ThumbDistalJoint
    {
        get
        {
            return _thumbDistalJoint;
        }

        set
        {
            if (_thumbDistalJoint != value)
            {
                _thumbDistalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _ThumbMetacarpalJoint
    {
        get
        {
            return _thumbMetacarpalJoint;
        }

        set
        {
            if (_thumbMetacarpalJoint != value)
            {
                _thumbMetacarpalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _ThumbProximalJoint
    {
        get
        {
            return _thumbProximalJoint;
        }

        set
        {
            if (_thumbProximalJoint != value)
            {
                _thumbProximalJoint = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Quaternion _WristRot
    {
        get
        {
            return _wristRot;
        }

        set
        {
            if (_wristRot != value)
            {
                _wristRot = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }

    public Vector3 _WristPos
    {
        get
        {
            return _wristPos;
        }

        set
        {
            if (_wristPos != value)
            {
                _wristPos = value;

                if (onPoseUpdate != null)
                {
                    onPoseUpdate();
                }
            }

        }
    }


    void Awake()
    {
        _IndexDistalJoint = new Quaternion(0, 0, 0, 0);
        _IndexKnuckle = new Quaternion(0, 0, 0, 0);
        _IndexMiddleJoint = new Quaternion(0, 0, 0, 0);

        _MiddleDistalJoint = new Quaternion(0, 0, 0, 0);
        _MiddleKnuckle = new Quaternion(0, 0, 0, 0);
        _MiddleMiddleJoint = new Quaternion(0, 0, 0, 0);


        _PinkyDistalJoint = new Quaternion(0, 0, 0, 0);
        _PinkyKnuckle = new Quaternion(0, 0, 0, 0);
        _PinkyMiddleJoint = new Quaternion(0, 0, 0, 0);

        _RingDistalJoint = new Quaternion(0, 0, 0, 0);
        _RingKnuckle = new Quaternion(0, 0, 0, 0);
        _RingMiddleJoint = new Quaternion(0, 0, 0, 0);

        _ThumbDistalJoint = new Quaternion(0, 0, 0, 0);
        _ThumbMetacarpalJoint = new Quaternion(0, 0, 0, 0);
        _ThumbProximalJoint = new Quaternion(0, 0, 0, 0);

        _WristRot = new Quaternion(0, 0, 0, 0);
        _WristPos = new Vector3(0, 0, 0);
     
    }

}
