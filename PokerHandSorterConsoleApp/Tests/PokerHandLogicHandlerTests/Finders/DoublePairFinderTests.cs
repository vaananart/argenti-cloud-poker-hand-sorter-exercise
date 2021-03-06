using System.Collections.Generic;
using System.Linq;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	//NOTE: Code Coverage : this test touches al lthe lines in code.
	public class DoubleFinderTests
	{
		[Fact]
		public void Given_TwoPair_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("6S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = DoublePairFinder.FindTwoPair(sampleCards);

			var matchedCardsByFour = result.Where(x => x.Value == '4');
			var matchedCardsBySix = result.Where(x => x.Value == '6');

			Assert.Equal("4H", matchedCardsByFour.Where(x => x.ToString() == "4H").FirstOrDefault().ToString());
			Assert.Equal("4C", matchedCardsByFour.Where(x => x.ToString() == "4C").FirstOrDefault().ToString());
			Assert.Equal("6S", matchedCardsBySix.Where(x => x.ToString() == "6S").FirstOrDefault().ToString());
			Assert.Equal("6C", matchedCardsBySix.Where(x => x.ToString() == "6C").FirstOrDefault().ToString());
		}

		[Fact]
		public void Given_TwoPair__Doesnt_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("5C"),
				new CardModel("6S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = DoublePairFinder.FindTwoPair(sampleCards);

			Assert.Null(result);

		}
	}
}
