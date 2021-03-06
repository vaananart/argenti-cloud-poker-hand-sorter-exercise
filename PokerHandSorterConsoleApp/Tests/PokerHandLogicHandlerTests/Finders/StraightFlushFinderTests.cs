using System.Collections.Generic;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class StraightFlushFinderTests
	{
		//NOTE: Code Coverage : these tests have touched all the lines in code.
		[Fact]
		public void Given_StraightFlush_Doesnt_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = StraightFlushFinder.IsStraightFlush(sampleCards);

			Assert.False(result);
		}


		[Fact]
		public void Given_StraightFlush_Doesnt_Exists_Due_Difference_inSuite_In_The_Middle_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("TH"),
				new CardModel("AH"),
				new CardModel("QH"),
				new CardModel("JC"),
				new CardModel("KH")
			};

			var result = StraightFlushFinder.IsStraightFlush(sampleCards);

			Assert.False(result);
		}
		[Fact]
		public void Given_StraightFlush_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("5H"),
				new CardModel("6H"),
				new CardModel("7H"),
				new CardModel("8H")
			};

			var result = StraightFlushFinder.IsStraightFlush(sampleCards);

			Assert.True(result);
		}
	}
}
