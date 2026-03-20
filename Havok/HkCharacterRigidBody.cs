using VRageMath;

namespace Havok {
    public partial class HkCharacterRigidBody {
        public bool Jump;
        public bool AtLadder;
        public bool Supported;
        public float PosX;
        public float PosY;
        public float Speed;
        public float Elevate;
        public Vector3 Gravity;
        public Vector3 SupportNormal;
        public Vector3 ElevateVector;
        public Vector3 ElevateUpVector;
        public Vector3 AngularVelocity;
        public Vector3 GroundVelocity;
        public Vector3 InterpolatedVelocity;
        public Vector3 Position { get; set;  }
        public Vector3 LinearVelocity { get; set;  }
        public bool ContactPointCallbackEnabled { get; set;  }
        public bool UseSupportInfoQuery { get; set;  }
        public Vector3 Forward { get; set;  }
        public Vector3 Up { get; set;  }
        public float MaxSlope { get; set;  }
        public HkCharacterRigidBody(HkCharacterRigidBodyCinfo characterRigidBodyCinfo, float maxCharacterSpeed, object physicsBody) { /* Initialize Jolt Equivalent Here */ }
        public void SetDefaultShape() => throw new NotImplementedException();
        public void SetShapeForCrouch() => throw new NotImplementedException();
        public HkCharacterStateType GetState() => throw new NotImplementedException();
        public void SetState(HkCharacterStateType state) => throw new NotImplementedException();
        public void EnableFlyingState(bool enable, float maxCharacterSpeed, float maxFlyingSpeed, float maxAcceleration) => throw new NotImplementedException();
        public void EnableLadderState(bool enable, float maxCharacterSpeed, float maxAcceleration) => throw new NotImplementedException();
        public void StepSimulation(float timeInSec) => throw new NotImplementedException();
        public void UpdateSupport(float timeInSec) => throw new NotImplementedException();
        public Matrix GetRigidBodyTransform() => throw new NotImplementedException();
        public void SetRigidBodyTransform(ref Matrix world) => throw new NotImplementedException();
        public void ApplyLinearImpulse(Vector3 impulse) => throw new NotImplementedException();
        public void ApplyAngularImpulse(Vector3 impulse) => throw new NotImplementedException();
        public void SetSupportDistance(float distance) => throw new NotImplementedException();
        public void SetHardSupportDistance(float distance) => throw new NotImplementedException();
        public HkEntity GetRigidBody() => throw new NotImplementedException();
        public HkRigidBody GetHitRigidBody() => throw new NotImplementedException();
        public Vector3 GetAngularVelocity() => throw new NotImplementedException();
        public void SetAngularVelocity(Vector3 value) => throw new NotImplementedException();
        public void SetCollisionFilterInfo(object info) => throw new NotImplementedException();
        public List<HkRigidBody> GetSupportInfo() => throw new NotImplementedException();
        public void ResetSurfaceVelocity() => throw new NotImplementedException();
        public void SetPreviousSupportedState(bool supported) => throw new NotImplementedException();
    }
}
