// Decompiled with JetBrains decompiler
// Type: ForceClone.ForceClone
// Assembly: ForceClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59B03D51-CB41-4AF2-9FF1-1D6A93A20B76
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\VRChat\Mods\ForceClone.dll

using ForceClone.Hooks;
using MelonLoader;
using UnityEngine;

namespace ForceClone
{
  public class ForceClone : MelonMod
  {
    private AllowAvatarCopying allowAvatarCopyingHook;

    public virtual void OnApplicationStart()
    {
      this.allowAvatarCopyingHook = new AllowAvatarCopying(((MelonBase) this).HarmonyInstance);
      Preferences.Initialize();
      if (!Preferences.autoHook.Value)
        return;
      this.allowAvatarCopyingHook.Initialize();
      MelonLogger.Msg("Force clone has been auto hooked successfuly..");
    }

    public virtual void OnUpdate()
    {
      if (Input.GetKeyDown(Preferences.hookKey.Value))
      {
        if (!this.allowAvatarCopyingHook.isHooked)
        {
          this.allowAvatarCopyingHook.Initialize();
          MelonLogger.Msg("Force clone hooked successfully, you may need to rejoin your current world.");
        }
        else
          MelonLogger.Error("Force clone has already been hooked.");
      }
      if (!Input.GetKeyDown(Preferences.unhookKey.Value))
        return;
      if (this.allowAvatarCopyingHook.isHooked)
      {
        this.allowAvatarCopyingHook.Release();
        MelonLogger.Msg("Force clone unhooked successfully, you may need to rejoin your current world.");
      }
      else
        MelonLogger.Error("Force clone has not been hooked yet.");
    }
  }
}
