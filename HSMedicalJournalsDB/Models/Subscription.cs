using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HSMedicalJournalsDB.Models
{
    public class Subscription
    {
        public Subscription()
        {
            SubscriptionDate = DateTime.Now;
            ExpirationDate = SubscriptionDate.AddYears(1);
        }
        public int Id { get; set; }
        public User User { get; set; }
        public Journal Journal { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}