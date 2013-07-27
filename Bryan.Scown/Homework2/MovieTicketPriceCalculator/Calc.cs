using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicketPriceCalculator
{
	public partial class Calc : Form
	{
		private TicketPriceCalculator register;
		private int _numberOfAdultTickets;
		private int _numberOfChildTickets;
		private int _numberOfSeniorTickets;
		

		public Calc()
		{
			InitializeComponent();

			register = new TicketPriceCalculator();

		}

		private void BtnAdult_Click(object sender, EventArgs e)
		{
			_numberOfAdultTickets++;

			register.NumTicketsNeeded(_numberOfAdultTickets, TicketTypes.AdultTicket);

			UpdateTotal();
			GroupDiscount();
		}

		private void BtnChild_Click(object sender, EventArgs e)
		{
			_numberOfChildTickets++;

			register.NumTicketsNeeded(_numberOfChildTickets, TicketTypes.ChildTicket);

			UpdateTotal();
			GroupDiscount();
		}

		private void BtnSenior_Click(object sender, EventArgs e)
		{
			_numberOfSeniorTickets++;

			register.NumTicketsNeeded(_numberOfSeniorTickets, TicketTypes.SeniorTicket);

			UpdateTotal();
			GroupDiscount();
		}

		public string UpdateTotal()
		{
			decimal total = register.TransactionTotal();

			return TxtSelection.Text = total.ToString();

		}

		private string GroupDiscount()
		{
			string discountMessage = "Group Discount Applied ($7 per ticket)";
			string matineeMessage = "Matinee pricing ($2 off)";
			
			if (register.IsGroupPriceApplicable() && register.IsMatineePrice() == false)
			{
				return LblGroupDiscount.Text = discountMessage;	
			}
			if (register.IsGroupPriceApplicable() == false && register.IsMatineePrice())
			{
				return LblGroupDiscount.Text = matineeMessage;	
			}
			return null;
		}
		
		private void ResetCalculator()
		{
			register = new TicketPriceCalculator();

			_numberOfAdultTickets = 0;
			_numberOfChildTickets = 0;
			_numberOfSeniorTickets = 0;
			LblGroupDiscount.Text = null;
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			ResetCalculator();
			UpdateTotal();
		}

	}
}
