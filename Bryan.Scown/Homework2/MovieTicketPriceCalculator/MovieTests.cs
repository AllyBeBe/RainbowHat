using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MovieTicketPriceCalculator;

namespace TicketPriceCalculator
{
    /* TDD workflow:  Red -> Green -> Refactor
     * 
     * Movie rules:
     *   1) always use the cheapest price possible for a ticket
     *   
     * Prices:
     *  regular adult          $11
     *  child < 13             $5.5
     *  senior > 65            $8
     *  group > 5              $7
     *  matinee < 2pm Mon-Thur -$2
     *  3d                     +$3
     *  long movie > 2hr        +$1.5
     *  has student id         -$3
    */

	[TestFixture]
	public class MovieTests
	{
		[Test]
		public void Regular_adult_costs_11_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");
			
			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(1, TicketTypes.AdultTicket);

				Assert.AreEqual(11, register.TransactionTotal());	
			}
		}

		[Test]
		public void Children_cost_5_dollars_fifty_cents()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");
			
			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(1, TicketTypes.ChildTicket);

				Assert.AreEqual(5.5m, register.TransactionTotal());	
			}
		}

		[Test]
		public void Seniors_cost_8_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(1, TicketTypes.SeniorTicket);

				Assert.AreEqual(8, register.TransactionTotal());
			}
		}

		[Test]
		public void One_senior_and_one_child_ticket_costs_13_5()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();
				register.NumTicketsNeeded(1, TicketTypes.SeniorTicket);
				register.NumTicketsNeeded(1, TicketTypes.ChildTicket);
				Assert.AreEqual(13.5m, register.TransactionTotal());
			}
		}

		[Test]
		public void Two_seniors_and_one_adult_cost_27_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(2, TicketTypes.SeniorTicket);
				register.NumTicketsNeeded(1, TicketTypes.AdultTicket);
				Assert.AreEqual(27, register.TransactionTotal());	
			}
		}

		[Test]
		public void Three_adults_and_two_kids_cost_44_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(3, TicketTypes.AdultTicket);
				register.NumTicketsNeeded(2, TicketTypes.ChildTicket);

				Assert.AreEqual(44, register.TransactionTotal());		
			}
		}

		[Test]
		public void Two_adults_and_two_seniors_two_kids_cost_49_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(2, TicketTypes.AdultTicket);
				register.NumTicketsNeeded(2, TicketTypes.SeniorTicket);
				register.NumTicketsNeeded(2, TicketTypes.ChildTicket);

				Assert.AreEqual(39, register.TransactionTotal());	
			}
		}

		[Test]
		public void Three_adults_three_seniors_two_children_cost_53_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(3, TicketTypes.AdultTicket);
				register.NumTicketsNeeded(3, TicketTypes.SeniorTicket);
				register.NumTicketsNeeded(2, TicketTypes.ChildTicket);

				Assert.AreEqual(53, register.TransactionTotal());		
			}
		}

		[Test]
		public void Three_adults_and_three_seniors_cost_42_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(3, TicketTypes.AdultTicket);
				register.NumTicketsNeeded(3, TicketTypes.SeniorTicket);

				Assert.AreEqual(42, register.TransactionTotal());		
			}
		}

		[Test]
		public void Six_adults_cost_42_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(6, TicketTypes.AdultTicket);

				Assert.AreEqual(42, register.TransactionTotal());	
			}
		}

		[Test]
		public void Six_seniors_cost_42_dollars()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(6, TicketTypes.SeniorTicket);

				Assert.AreEqual(42, register.TransactionTotal());	
			}
		}

		[Test]
		public void Three_adult_Three_Seniors_Two_child_matinee_tickets_cost_dollars()
		{
			DateTime matineeTime = Convert.ToDateTime("1:00 PM");

			using (Time.FreezeAt(matineeTime))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(3, TicketTypes.AdultTicket);
				register.NumTicketsNeeded(3, TicketTypes.SeniorTicket);
				register.NumTicketsNeeded(2, TicketTypes.ChildTicket);

				Assert.AreEqual(52, register.TransactionTotal());	
			}
			
		}

		[Test]
		public void How_Many_Tickets_Needed()
		{
			var register = new TicketPriceCalculator();

			register.NumTicketsNeeded(3, TicketTypes.AdultTicket);

			Assert.AreEqual(3, register.NumberOfTickets());
		}

		[Test]
		public void Is_Group_Price_Applicable()
		{
			DateTime nonMatinee = Convert.ToDateTime("3:00 PM");

			using (Time.FreezeAt(nonMatinee))
			{
				var register = new TicketPriceCalculator();

				register.NumTicketsNeeded(6, TicketTypes.AdultTicket);

				Assert.AreEqual(true, register.IsGroupPriceApplicable());		
			}
		}
	}
}
