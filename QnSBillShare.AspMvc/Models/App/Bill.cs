using QnSBillShare.Contracts.Persistence.App;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QnSBillShare.AspMvc.Models.App
{
    public class Bill : ModelObject, Contracts.Persistence.App.IBill
    {
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string Friends { get; set; }

        public void CopyProperties(IBill other)
        {
            base.CopyProperties(other);

            Date = other.Date;
            Title = other.Title;
            Description = other.Description;
            Currency = other.Currency;
            Friends = other.Friends;
        }
    }
}
