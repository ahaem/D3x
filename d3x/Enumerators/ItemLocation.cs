using System;
using System.Collections.Generic;
using System.Text;

namespace D3x.Enumerators
{
    public enum ItemLocation : uint
    {
        Unknown = uint.MaxValue, //  meaning NPC or item on the ground.
        Backpack = 0,
        Head = 1,
        Torso = 2,
        RightHand = 3,
        LeftHand = 4,
        Hands = 5,
        Waist = 6,
        Feet = 7,
        Shoulders = 8,
        Legs = 9,
        Bracers = 10,
        LeftFinger = 11,
        RightFinger = 12,
        Neck = 13,
        Talisman = 14,
        Stash = 15,
        Gold = 16,
        Merchant = 18,
        InSocket = 20,
        PetRightHand = 23,
        PetLeftHand = 24,
        PetSpecial = 25,
        PetLeftFinger = 28,
        PetRightFinger = 27,
        PetNeck = 26
    }
}
