using VRageMath;

namespace Havok {
    public partial class HkRopeConstraintData {
        public float Strength { get; set;  }
        public float LinearLimit { get; set;  }
        public HkRopeConstraintData() { /* Initialize Jolt Equivalent Here */ }
        public void SetInBodySpaceInternal(ref Vector3 pivotA, ref Vector3 pivotB) => throw new NotImplementedException();
    }
}
