using VRageMath;

namespace Havok {
    public partial class HkRagdoll {
        public Action<HkRagdoll> AddedToWorld;
        public RagdollBone m_ragdollTree;
        public float Mass { get;  }
        public List<HkRigidBody> RigidBodies { get;  }
        public bool ConstraintsEnabled { get;  }
        public List<Matrix> RigTransforms { get;  }
        public List<Matrix> LocalTransforms { get;  }
        public List<HkConstraintData> RagdollConstraintsData { get;  }
        public List<HkConstraint> Constraints { get;  }
        public List<HkShape> Shapes { get;  }
        public Matrix WorldMatrix { get;  }
        public Matrix WorldMatrixInverted { get;  }
        public bool IsActive { get; set;  }
        public bool InWorld { get;  }
        public int Layer { get; set;  }
        public bool IsKeyframed { get;  }
        public bool IsSimulationActive { get;  }
        public float MaxLinearVelocity { get;  }
        public float MaxAngularVelocity { get;  }
        public IntPtr PhysicsSystem { get;  }
        public HkRagdoll() { /* Initialize Jolt Equivalent Here */ }
        public int FindRigidBodyIndex(string name) => throw new NotImplementedException();
        public void GenerateRigidBodiesCollisionFilters(int ragdollCollisionLayer, int ragdollSystemGroup, int startSubsystemIdsFrom) => throw new NotImplementedException();
        public void SetWorldMatrix(Matrix world, bool updateOnlyKeyframed, bool updateVelocities) => throw new NotImplementedException();
        public void SetWorldMatrix(Matrix world) => throw new NotImplementedException();
        public void OptimizeInertiasOfConstraintTree() => throw new NotImplementedException();
        public Matrix GetRigidBodyLocalTransform(int rigidBodyIndex) => throw new NotImplementedException();
        public void GetRigidBodyLocalTransform(int rigidBodyIndex, ref Matrix transform) => throw new NotImplementedException();
        public void SetRigidBodyLocalTransform(int rigidBodyIndex, Matrix localTransform) => throw new NotImplementedException();
        public void UpdateWorldMatrixAfterSimulation() => throw new NotImplementedException();
        public void Activate() => throw new NotImplementedException();
        public void Deactivate() => throw new NotImplementedException();
        public void EnableConstraints() => throw new NotImplementedException();
        public void DisableConstraints() => throw new NotImplementedException();
        public void SetToKeyframed() => throw new NotImplementedException();
        public void SetToKeyframed(int rigidBodyIndex) => throw new NotImplementedException();
        public void SetToDynamic() => throw new NotImplementedException();
        public void SetToDynamic(int rigidBodyIndex) => throw new NotImplementedException();
        public bool LoadRagdollFromFile(string fileName) => throw new NotImplementedException();
        public bool LoadRagdollFromBuffer(byte[] buffer) => throw new NotImplementedException();
        public void SwitchRigidBodyToLayer(int rigidBodyIndex, int collisionLayer) => throw new NotImplementedException();
        public bool SetRootBody(string bodyName) => throw new NotImplementedException();
        public void ResetToRigPose() => throw new NotImplementedException();
        public HkRigidBody GetRootRigidBody() => throw new NotImplementedException();
        public void UpdateLocalTransforms() => throw new NotImplementedException();
        public bool IsRigidBodyPalmOrFoot(int rigidBodyIdx) => throw new NotImplementedException();
        public void Dispose() => throw new NotImplementedException();
    }
}
