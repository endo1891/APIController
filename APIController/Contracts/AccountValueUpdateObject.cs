using System;

namespace APIController.Contracts
{
    public class AccountValueUpdateObject
    {
        public int AmountToAdd { get; set; }
        public string Currency { get; set; }
        public string Lastname { get; set; }
    }
}