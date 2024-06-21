using HomeworkTwoDelegateAndEvent.GameDevelopment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTwoDelegateAndEvent.FinancialApplication
{
    public delegate void FinancialApplicationDelegate(string message);
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }

    }
    public interface IAccountService
    {
        void SetReportSpendingLimit(int count);
        void SetValueBelowThresholdNotification(int count);
        void DoTheShopping(int AmountSpent, Account account);
    }
    public class AccountService : IAccountService
    {
        public event FinancialApplicationDelegate? FinancialApplicationEvent;
        private int ReportSpendingLimit = 1000;
        private int ValueBelowThresholdNotification = 100;

        public void SetReportSpendingLimit(int count)
        {
            this.ReportSpendingLimit = count;
        }
        public void SetValueBelowThresholdNotification(int count)
        {
            this.ValueBelowThresholdNotification = count;
        }

        public void DoTheShopping(int AmountSpent, Account account)
        {
            account.Balance -= AmountSpent;
            if(AmountSpent > this.ReportSpendingLimit)
            {
                FinancialApplicationEvent?.Invoke($"UYARI --> {this.ReportSpendingLimit} Tutar Üzerinde Ödeme Yapıldı. Yapılan Ödeme Miktarı {AmountSpent}");
            }
            if (account.Balance < this.ValueBelowThresholdNotification)
            {
                FinancialApplicationEvent?.Invoke($"Hesap Bakiyeniz {this.ValueBelowThresholdNotification} Altına Düştü. Yeni Hesap bakiyeniz {account.Balance}");
            }
        }
    }
}
