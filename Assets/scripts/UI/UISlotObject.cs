﻿using UnityEngine;

public class UISlotObject
{
     public readonly string Slot;
     public readonly GameObject SlotContents;

     public UISlotObject(string slot, GameObject slotContents)
     {
          Slot = slot;
          SlotContents = slotContents;
     }

     public override string ToString()
     {
          return string.Format("UISlotObject {0}: {1}", Slot, SlotContents);
     }
}