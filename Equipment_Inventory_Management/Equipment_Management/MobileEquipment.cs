namespace Equipment_Management
{
    class MobileEquipment : Equipment
    {
        public int NumberOfWheels { get; set; }

        public override EquipmentType Type => EquipmentType.Mobile;

        protected override double GetMaintenanceCost(double distance)
        {
            return NumberOfWheels * distance;
        }
    }
}
