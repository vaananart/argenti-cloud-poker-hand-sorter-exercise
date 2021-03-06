using System.Collections.Generic;
using System.Linq;
using PokerHandDomainModels;
using PokerHandLogicHandlers.Finders;
using Xunit;

namespace PokerHandLogicHandlerTests.Finders
{
	public class ThreeOfAKindFinderTests
	{ 
		//NOTE : Code Coverage : these tests have touched all the lines in the code.
		[Fact]
		public void Given_ThreeOfKind_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("4C"),
				new CardModel("4S"),
				new CardModel("6C"),
				new CardModel("KD")
			};

			var result = ThreeOfAKindFinder.FindThreeOfKind(sampleCards);

			var matchedCardsByFour = result.Where(x => x.Value == '4');

			Assert.Equal("4H", matchedCardsByFour.Where(x => x.ToString() == "4H").FirstOrDefault().ToString());
			Assert.Equal("4C", matchedCardsByFour.Where(x => x.ToString() == "4C").FirstOrDefault().ToString());
			Assert.Equal("4S", matchedCardsByFour.Where(x => x.ToString() == "4S").FirstOrDefault().ToString());

		}

		[Fact]
		public void Given_ThreeOfKind_Does_Not_Exists_Test()
		{
			var sampleCards = new List<CardModel>
			{
				new CardModel("4H"),
				new CardModel("5C"),
				new CardModel("6S"),
				new CardModel("7C"),
				new CardModel("KD")
			};

			var result = ThreeOfAKindFinder.FindThreeOfKind(sampleCards);

			Assert.Null(result);
		}
	}
}
