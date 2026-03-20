using VRageMath;

namespace Havok {
    public partial class HkCharacterProxy {
        public bool Jump;
        public float PosX;
        public float PosY;
        public Vector3 Gravity;
        public Vector3 Position { get; set;  }
        public Vector3 LinearVelocity { get; set;  }
        public Vector3 Up { get; set;  }
        public Vector3 Forward { get; set;  }
        public HkCharacterProxy(HkCharacterProxyCinfo characterProxyCinfo) { /* Initialize Jolt Equivalent Here */ }
        public HkCharacterStateType GetState() => throw new NotImplementedException();
        public void SetState(HkCharacterStateType state) => throw new NotImplementedException();
        public void StepSimulation(float timeInSec) => throw new NotImplementedException();
    }
}
