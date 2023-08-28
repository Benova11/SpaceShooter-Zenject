using UnityEngine;

namespace Scrips.VisualLayer.Gameplay.PlayerInput
{
    public class PlayerKeyboardInput : IPlayerInput
    {
        #region Consts

        private const string ROTATION_AXIS_NAME = "Horizontal";
        private const string ACCELARATION_AXIS_NAME = "Vertical";


        #endregion

        #region Properties

        public float RotationFactor => Input.GetAxis(ROTATION_AXIS_NAME);

        public float AccelerationFactor => Input.GetAxis(ACCELARATION_AXIS_NAME);

        #endregion
    }
}