using HomeworkTwoDelegateAndEvent.E_CommerceSystem;
using HomeworkTwoDelegateAndEvent.FinancialApplication;
using HomeworkTwoDelegateAndEvent.GameDevelopment;

namespace RunCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FinancialApplication
            //Account account = new Account
            //{
            //    Id = 1,
            //    Name = "Ahmet Hakan",
            //    Balance = 10000
            //};
            //var accountService = new AccountService();

            //accountService.FinancialApplicationEvent += AccountService_FinancialApplicationEvent;
            //void AccountService_FinancialApplicationEvent(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //accountService.SetReportSpendingLimit(2000); //Bu tutarın üstünde ödeme yapılırsa bildir.
            //accountService.SetValueBelowThresholdNotification(200); //Hesap bakiyesi Bu tutarın altına düşerse bildir.

            //accountService.DoTheShopping(9901, account);  //Alışveriş yap ödeme tutarı ve hangi hesap
            #endregion
            #region GameDevelopment
            //Enemy enemy = new Enemy
            //{
            //    Id = 1,
            //    Name = "Ahmet Hakan",
            //};
            //var enemyService = new EnemyService();

            //enemyService.WhatIsTheEnemyHealth += EnemyService_WhatIsTheEnemyHealth;
            //void EnemyService_WhatIsTheEnemyHealth(string message)
            //{
            //    Console.WriteLine(message);
            //}
            //enemyService.SetReportEnemyHealth(20);
            //enemyService.TakeDamage(100, enemy);
            #endregion
            #region E-CommerceSystem
            //// Sipariş oluşturma
            //Order order = new Order
            //{
            //    Id = 1,
            //    CustomerName = "John Doe",
            //    OrderDate = DateTime.Now,
            //    Items = new List<string> { "Laptop", "Mouse", "Keyboard" }
            //};

            //// Departmanlar
            //CustomerService customerService = new CustomerService();
            //WarehouseManagement warehouseManagement = new WarehouseManagement();
            //Accounting accounting = new Accounting();

            //// Event Abonelikleri
            //order.OrderCompleted += customerService.OnOrderCompleted;
            //order.OrderCompleted += warehouseManagement.OnOrderCompleted;
            //order.OrderCompleted += accounting.OnOrderCompleted;

            //// Siparişi Tamamlama
            //order.CompleteOrder();
            #endregion
        }

      
    }
}
