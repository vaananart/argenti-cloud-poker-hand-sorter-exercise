using System.Collections.Generic;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class FlushFinderTests
	{
		//NOTE: Code Coverage : this tests touch ll the lines in the code.
		[Fact]
		public void Given_Flush_Doesnt_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = FlushFinder.IsFlush(sampleCards);

			Assert.False(result);
		}

		[Fact]
		public void Given_Flush_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4H"),
				new CardModel("4H"),
				new CardModel("6H"),
				new CardModel("KH")
			};

			var result = FlushFinder.IsFlush(sampleCards);

			Assert.True(result);
		}
	}
}
