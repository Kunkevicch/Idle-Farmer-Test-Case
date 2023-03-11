using UnityEngine;

namespace FarmerIdle.Misc
{
    public static class Settings 
    {
        #region ANIMATOR PARAMETERS
        public static readonly int isIdle = Animator.StringToHash("isIdle");
        public static readonly int isMove = Animator.StringToHash("isMove");
        #endregion ANIMATOR PARAMETERS
    }
}
