using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace MarsRovers.Steps
{
    [Binding]
    public class TurnRoverSteps
    {
        private readonly RoverTestContext _roverTestContext;

        public TurnRoverSteps(RoverTestContext roverTestContext)
        {
            _roverTestContext = roverTestContext;
        }
        [Given(@"Rover is at 1,2")]
        public void GivenRoverIsAt()
        {
            Point position = new Point(1, 2);
            _roverTestContext.rover = new Rover();
            _roverTestContext.rover.SetPosition(position);
        }


        /*[Given(@"rover is pointing towards ([NEWS]{1})")]
        public void GivenRoverIsPointingTowardsDirection(string direction)
        {
            _roverTestContext.rover.SetDirection(direction);
        }*/

        [When(@"rover turns ([LR]{1})")]
        public void WhenRoverTurns(string orientation)
        {
            _roverTestContext.rover.Turns(orientation);
        }

        /*[Then(@"rover should be facing ([NEWS]{1})")]
        public void ThenRoverShouldBeFacing(string direction)
        {
            _roverTestContext.rover.GetDirection().Should().Be(direction);
        }*/
    }
}