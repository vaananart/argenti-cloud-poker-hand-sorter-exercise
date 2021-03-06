using System.Collections.Generic;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class PairFinderTests
	{
		//NOTE: Code Coverage : this tests covers all the lines in the code.
		[Fact]
		public void Given_Pair_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("6S"),
				new CardModel("7S"),
				new CardModel("KD")
			};

			var result = PairFinder.FindAPair(sampleCards);

			foreach (var element in result)
			{
				Assert.Equal('4', element.Value);
			}
		}

		[Fact]
		public void Given_Pair_Doesnt_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("5C"),
				new CardModel("6S"),
				new CardModel("7S"),
				new CardModel("KD")
			};

			var result = PairFinder.FindAPair(sampleCards);

			Assert.Null(result);
		}
	}
}
