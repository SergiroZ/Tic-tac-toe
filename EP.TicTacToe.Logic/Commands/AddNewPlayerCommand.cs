using CSharpFunctionalExtensions;
using EP.TicTacToe.Logic.Models;
using MediatR;

namespace EP.TicTacToe.Logic.Commands
{
    public class AddNewPlayerCommand : IRequest<Result<Player>>
    {
        public int Id { get; set; }
        public int GameId { get; set; }
    }
}