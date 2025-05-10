using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    /*
     * Please implement a new Property AccountHolderName.
     * Some new rule has been incorporated to calculate interest.
     * */
    public class BankAccount
    {
        private readonly TaxCalculationService _taxCalculationService;

        public BankAccount(TaxCalculationService taxCalculationService)
        {
            _taxCalculationService = taxCalculationService;
        }

        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public string AccountHolderName { get; set; }
       
    }
}
