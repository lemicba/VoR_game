using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EC
{
    public class PlayerInventory : MonoBehaviour
    {
        WeaponSlotManager weaponSlotsManager;

        public WeaponItem rightWeapon;
        public WeaponItem leftWeapon;

        public List<WeaponItem> weaponsInventory;

        private void Awake()
        {
            weaponSlotsManager = GetComponentInChildren<WeaponSlotManager>();
        }

        private void Start()
        {
            weaponSlotsManager.LoadWeaponOnSlot(rightWeapon, false);
            weaponSlotsManager.LoadWeaponOnSlot(leftWeapon, true);
        }
    }
}
