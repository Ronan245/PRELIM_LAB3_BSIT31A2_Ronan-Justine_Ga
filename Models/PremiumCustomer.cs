namespace PRELIM_LAB3_BSIT31A2_Ronan_Justine_Ga.Models
{
    public class PremiumCustomer : Customer
    {
        public int LoyaltyPoints { get; set; }

        public override string Describe()
        {
            return $"Premium Customer: {Name}, Email: {Email}, Loyalty Points: {LoyaltyPoints}";
        }
    }
}