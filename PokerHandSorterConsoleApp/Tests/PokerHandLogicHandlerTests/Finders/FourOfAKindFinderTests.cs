using System.Collections.Generic;
using System.Linq;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class FourOfAKindFinderTests
	{
		//NOTE: Code Coverage : this tests touch all the lines in code.
		[Fact]
		public void Given_FourOfAKind_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = FourOfAKindFinder.FindFourOfAKind(sampleCards);

			Assert.False(result.Count() == 4);
		}

		[Fact]
		public void Given_FourOfAKind_Doesnt_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("4C"),
				new CardModel("KD")
			};

			var result = FourOfAKindFinder.FindFourOfAKind(sampleCards);

			Assert.Equal(4, result.Count());
		}
	}
}
