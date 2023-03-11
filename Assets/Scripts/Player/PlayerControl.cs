using UnityEngine.InputSystem;
using UnityEngine;

namespace FarmerIdle.Player
{
    /// <summary>
    /// InputHandler class for listening player input
    /// </summary>
    #region Attributes
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Rigidbody))]
    //[RequireComponent(typeof(Player))]
    #endregion
    public class PlayerControl : MonoBehaviour
    {
        private Rigidbody rb;
        private Player player;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            player = GetComponent<Player>();
        }
    }

}