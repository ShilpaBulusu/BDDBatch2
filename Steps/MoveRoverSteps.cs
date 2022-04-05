using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsRovers.Steps
{
    [Binding]
    class MoveRoverSteps
    {
        private readonly RoverTestContext _roverTestContext;
        public MoveRoverSteps(RoverTestContext roverTestContext)
        {
            _roverTestContext = roverTestContext;
        }
        [Given(@"Rover is at (\d+), (\d+)")]
        public void GivenRoverIsAt(int x, int y)
        {
           Point position = new Point(x, y);
            _roverTestContext.rover = new Rover();
            _roverTestContext.rover.SetPosition(position);
        }

        [Given(@"rover is pointing towards ([NEWS]{1})")]
        public void GivenRoverIsPointingTowardsDirection(string direction)
        {
            _roverTestContext.rover.SetDirection(direction);
        }

        [When(@"rover moves forward")]
        public void WhenRoverMovesForward()
        {
            _roverTestContext.rover.Move();
        }

        [Then(@"rover should be at (\d+), (\d+)")]
        public void ThenRoverShouldBeAt(int x, int y)
        {
            _roverTestContext.rover.GetPosition().Should().Be(new Point(x, y));
        }

        [Then(@"rover should be facing ([NEWS]{1})")]
        public void ThenRoverShouldBeFacing(string direction)
        {
            _roverTestContext.rover.GetDirection().Should().Be(direction);
        }
    }
}
