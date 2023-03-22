namespace Equipment_Management
{
    class ImmobileEquipment : Equipment
    {
        public int Weight { get; set; }

        public override EquipmentType Type => EquipmentType.Immobile;

        protected override double GetMaintenanceCost(double distance)
        {
            return Weight * distance;
        }
    }
}
