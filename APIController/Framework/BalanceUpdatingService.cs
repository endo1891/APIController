using APIController.Contracts;
using APIController.Framework.Helpers;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace APIController.Framework
{
    public class BalanceUpdatingService
    {
        public void UpdateDetails(AccountValueUpdateObject value)
        {
            var sql = $@"
             UPDATE Employees 
             set lastname= @Value
             WHERE employeeid=1
             ;"
            .Execute(new { Value = value.Lastname});

            if (sql < 0)
                throw new Exception($"Result returned {sql}");
        }

        /*public void UpdateBalance(string id, AccountValueUpdateObject value)
        {
            //sanity check
            if (value.CodeTitrePrefix.Length > "LQ0000000000".Length)
                throw new ArgumentException("Invalid email passed");

            //put into form id/currency
            if (!string.IsNullOrWhiteSpace(value.Currency))
                id = id + "/" + value.Currency;

            var cptNo = id + "%";
            var codeTitre = value.CodeTitrePrefix + "%";

            var sql = $@"
            UPDATE PORETFEUILLE
            SET Qte = @Value
            WHERE Cpt_no LIKE @CptNo
            AND Code_Titre LIKE @CodeTitre;"
            .Execute(new { Value = value.AmountToAdd, CptNo = cptNo, CodeTitre = codeTitre});

            if (sql < 0)
                throw new Exception($"Result returned {sql}");   
        }*/
    }
}