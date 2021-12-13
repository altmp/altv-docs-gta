using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponPageCreator
{
    public class TranslatedLabel
    {
        public uint Hash { get; set; }
        public string English { get; set; }
        public string German { get; set; }
        public string French { get; set; }
        public string Italian { get; set; }
        public string Russian { get; set; }
        public string Polish { get; set; }
        public string Name { get; set; }
        public string TraditionalChinese { get; set; }
        public string SimplifiedChinese { get; set; }
        public string Spanish { get; set; }
    }

    public class TranslatedDescription
    {
        public uint Hash { get; set; }
        public string English { get; set; }
        public string German { get; set; }
        public string French { get; set; }
        public string Italian { get; set; }
        public string Russian { get; set; }
        public string Polish { get; set; }
        public string Name { get; set; }
        public string TraditionalChinese { get; set; }
        public string SimplifiedChinese { get; set; }
        public string Spanish { get; set; }
    }

    public class Tint
    {
        public int Index { get; set; }
        public TranslatedLabel TranslatedLabel { get; set; }
    }

    public class Variant
    {
        public int Index { get; set; }
        public string Name { get; set; }
    }

    public class Component
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public TranslatedLabel TranslatedLabel { get; set; }
        public TranslatedDescription TranslatedDescription { get; set; }
        public uint Hash { get; set; }
        public int IntHash { get; set; }
        public string AttachBone { get; set; }
        public string Type { get; set; }
        public List<Variant> Variants { get; set; }
        public string DlcName { get; set; }
    }

    public class Livery
    {
        public string Name { get; set; }
        public uint Hash { get; set; }
        public int IntHash { get; set; }
        public TranslatedLabel TranslatedLabel { get; set; }
        public string DlcName { get; set; }
    }

    class Weapon
    {
        public string Name { get; set; }
        public TranslatedLabel TranslatedLabel { get; set; }
        public uint Hash { get; set; }
        public int IntHash { get; set; }
        public string DlcName { get; set; }
        public string Category { get; set; }
        public TranslatedDescription TranslatedDescription { get; set; }
        public List<Tint> Tints { get; set; }
        public bool IsVehicleWeapon { get; set; }
        public List<string> Flags { get; set; }
        public List<Component> Components { get; set; }
        public List<Livery> Liveries { get; set; }
    }
}