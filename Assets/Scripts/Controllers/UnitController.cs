using UnityEngine;

namespace aberrantGaming.Breakout
{
    public class UnitController : UnitMotor
    {
        private void OnDrawGizmosSelected()
        {
            Gizmos.DrawRay(this.transform.position, this.transform.forward);
        }
    }
}
