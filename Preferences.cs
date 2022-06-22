// Decompiled with JetBrains decompiler
// Type: ForceClone.Preferences
// Assembly: ForceClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59B03D51-CB41-4AF2-9FF1-1D6A93A20B76
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\VRChat\Mods\ForceClone.dll

using MelonLoader;
using MelonLoader.Preferences;
using UnityEngine;

namespace ForceClone
{
  public static class Preferences
  {
    public static MelonPreferences_Category forceCloneCategory;
    public static MelonPreferences_Entry<bool> autoHook;
    public static MelonPreferences_Entry<KeyCode> hookKey;
    public static MelonPreferences_Entry<KeyCode> unhookKey;

    public static void Initialize()
    {
      ForceClone.Preferences.forceCloneCategory = MelonPreferences.CreateCategory("ForceClone");
      ForceClone.Preferences.autoHook = ForceClone.Preferences.forceCloneCategory.CreateEntry<bool>("AutoHook", true, (string) null, (string) null, false, false, (ValueValidator) null, (string) null);
      ForceClone.Preferences.hookKey = ForceClone.Preferences.forceCloneCategory.CreateEntry<KeyCode>("HookKey", (KeyCode) 290, (string) null, (string) null, false, false, (ValueValidator) null, (string) null);
      ForceClone.Preferences.unhookKey = ForceClone.Preferences.forceCloneCategory.CreateEntry<KeyCode>("UnhookKey", (KeyCode) 291, (string) null, (string) null, false, false, (ValueValidator) null, (string) null);
      MelonPreferences.Save();
    }
  }
}
