using VRageMath;

namespace Havok {
    public partial class HkFixedConstraintData : HkConstraintData {
        public bool IsValid { get;  }

        public bool OldSolvingMethod
        {
            set
            {
                this.SetSolvingMethod(value ?HkSolvingMethod.MethodOld : HkSolvingMethod.MethodStabilized);
            }
        }

        public HkFixedConstraintData() { /* Initialize Jolt Equivalent Here */ }
        public void SetInBodySpaceInternal(ref Matrix pivotA, ref Matrix pivotB) => throw new NotImplementedException();
        public void SetInWorldSpace(ref Matrix bodyATransform, ref Matrix bodyBTransform, ref Matrix pivot) => throw new NotImplementedException();
        public bool SetInertiaStabilizationFactor(float value) => throw new NotImplementedException();
        public static float GetSolverImpulseInLastStep(HkConstraint constraint, byte constraintAtom) => throw new NotImplementedException();
    }
}
