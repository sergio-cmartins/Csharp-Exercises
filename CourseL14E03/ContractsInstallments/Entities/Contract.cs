﻿using System;
using System.Collections.Generic;

namespace ContractsInstallments.Entities
{
    class Contract
    {
        public int Number { get; private set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            Installments.Remove(installment);
        }
    }
}