using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkTwoDelegateAndEvent.GameDevelopment
{
    public delegate void EnemyHealthDelegate(string message);
    public class Enemy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; } = 100;
    }

    public interface IEnemyService
    {
        void SetReportEnemyHealth(int count);
        void TakeDamage(int damage, Enemy enemy);
    }
    public class EnemyService : IEnemyService
    {
        public event EnemyHealthDelegate? WhatIsTheEnemyHealth;
        private int ReportEnemyHealth = 30;

        public void SetReportEnemyHealth(int count)
        {
            this.ReportEnemyHealth = count;
        }

        public void TakeDamage(int damage, Enemy enemy)
        {
            enemy.Health -= damage;
            if(enemy.Health <= 0)
            {
                WhatIsTheEnemyHealth?.Invoke($"Düşman Öldü {enemy.Health}");
                return;
            }
            if (enemy.Health < ReportEnemyHealth)
            {
                WhatIsTheEnemyHealth?.Invoke($"Düşman Sağlığı {ReportEnemyHealth} Değerinin Altına Düştü. Kalan Can = {enemy.Health}");
            }
        }
    }


}
