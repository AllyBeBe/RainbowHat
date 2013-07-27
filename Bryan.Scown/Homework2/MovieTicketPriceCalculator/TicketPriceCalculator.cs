using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MovieTicketPriceCalculator;


namespace TicketPriceCalculator
{
	public enum TicketTypes
	{
		AdultTicket,
		ChildTicket,
		SeniorTicket,
		//GroupTicket,
		//MatineeTicket,
	}

	class TicketPriceCalculator
	{
		private int _numTickets;
		private TicketTypes _ticketTypes;
		private int _numAdultTickets;
		private int _numChildTickets;
		private int _numSeniorTickets;
		
		public decimal TransactionTotal()
		{
			decimal adultTicketCost = TicketCost(TicketTypes.AdultTicket);
			decimal childTicketCost = TicketCost(TicketTypes.ChildTicket);
			decimal seniorTicketCost = TicketCost(TicketTypes.SeniorTicket);
			decimal totalAdultCost = _numAdultTickets*adultTicketCost;
			decimal totalChildCost = _numChildTickets*childTicketCost;
			decimal totalSeniorCost = _numSeniorTickets*seniorTicketCost;
			decimal totalTransactionCost = totalAdultCost + totalSeniorCost + totalChildCost;

			return totalTransactionCost;
		}

		private decimal TicketCost(TicketTypes ticketType)
		{
			decimal cost = 11;
			
			if (ticketType == TicketTypes.ChildTicket)
			{
				cost = 5.5m;
			}
			if (ticketType == TicketTypes.SeniorTicket)
			{
				cost = 8;
			}
			if (IsGroupPriceApplicable() && IsMatineePrice() == false && cost > 7)
			{
				cost = 7;
			}
			if (IsMatineePrice())
			{
				return cost - 2;
			}
			return cost; //assume adult ticket
		}

		public void NumTicketsNeeded(int numTickets, TicketTypes ticketTypes)
		{
			_numTickets = numTickets;
			_ticketTypes = ticketTypes;

			if (ticketTypes == TicketTypes.ChildTicket)
			{
				_numChildTickets = numTickets;
			}
			if (ticketTypes == TicketTypes.SeniorTicket)
			{
				_numSeniorTickets = numTickets;
			}
			if (ticketTypes == TicketTypes.AdultTicket)
			{
				_numAdultTickets = numTickets;
			}

		}

		public int NumberOfTickets()
		{
			return _numAdultTickets + _numChildTickets + _numSeniorTickets;
		}

		public bool IsGroupPriceApplicable()
		{
			return NumberOfTickets() > 5;
		}

		public bool IsMatineePrice()
		{
			var now = Time.Now;

			//var matineeTime = Time.FreezeAt(DateTime.Now);
			DateTime matineeTime = Convert.ToDateTime("2:00 PM");

			return now < matineeTime;
		}
		
	}
}
