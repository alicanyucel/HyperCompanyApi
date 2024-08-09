
using Ardalis.SmartEnum;

namespace HyperCompany.Domain.Enums
{
   public sealed class VehicleEnum:SmartEnum<VehicleEnum>
    {
        public static readonly VehicleEnum Red = new("Kirmizi", 1);
        public static readonly VehicleEnum Yellow = new("Sari", 2);
        public static readonly VehicleEnum Blue = new("Mavi", 3);
        public static readonly VehicleEnum White = new("Beyaz", 4);
        public static readonly VehicleEnum Purple = new("Mor", 5);
        public static readonly VehicleEnum Black = new("Siyah", 6);
        public static readonly VehicleEnum Green = new("Yesil", 7);
        public static readonly VehicleEnum Pink = new("Pempe", 8);
        public static readonly VehicleEnum Orange = new("Turuncu", 9);
        public static readonly VehicleEnum Grey = new("Gri", 10);

        public VehicleEnum(string name,int value):base(name,value) 
        { 
        
        }
    }
}
