// Automatically Generated

using System.Diagnostics.CodeAnalysis;
using HKLib.hk2018;

namespace HKLib.Reflection.hk2018;

internal class hkaiIntersectionVolumeData : HavokData<hkaiIntersectionVolume> 
{
    public hkaiIntersectionVolumeData(HavokType type, hkaiIntersectionVolume instance) : base(type, instance) {}

    public override bool TryGetField<TGet>(string fieldName, [MaybeNull] out TGet value)
    {
        value = default;
        switch (fieldName)
        {
            case "m_propertyBag":
            case "propertyBag":
            {
                if (instance.m_propertyBag is not TGet castValue) return false;
                value = castValue;
                return true;
            }
            case "m_volumes":
            case "volumes":
            {
                if (instance.m_volumes is not TGet castValue) return false;
                value = castValue;
                return true;
            }
            default:
            return false;
        }
    }

    public override bool TrySetField<TSet>(string fieldName, TSet value)
    {
        switch (fieldName)
        {
            case "m_propertyBag":
            case "propertyBag":
            {
                if (value is not hkPropertyBag castValue) return false;
                instance.m_propertyBag = castValue;
                return true;
            }
            case "m_volumes":
            case "volumes":
            {
                if (value is not List<hkaiVolume?> castValue) return false;
                instance.m_volumes = castValue;
                return true;
            }
            default:
            return false;
        }
    }

}
