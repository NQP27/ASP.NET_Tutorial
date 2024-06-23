using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
    public static Game ToEntity(this CreateGameDto dtoGame)
    {
        return new Game()
        {
            Name = dtoGame.Name,
            GenreId = dtoGame.GenreId,
            Price = dtoGame.Price,
            ReleaseDate = dtoGame.ReleaseDate
        };
    }

    public static GameSummaryDto ToGameSummaryDto(this Game entityGame)
    {
        return new GameSummaryDto(
            entityGame.Id,
            entityGame.Name,
            entityGame.Genre!.Name,
            entityGame.Price,
            entityGame.ReleaseDate
        );
    }
    public static GameDetailsDto ToGameDetailsDto(this Game entityGame)
    {
        return new GameDetailsDto(
            entityGame.Id,
            entityGame.Name,
            entityGame.GenreId,
            entityGame.Price,
            entityGame.ReleaseDate
        );
    }


    public static Game ToEntity(this UpdateGameDto dtoGame, int id)
    {
        return new Game()
        {
            Id = id,
            Name = dtoGame.Name,
            GenreId = dtoGame.GenreId,
            Price = dtoGame.Price,
            ReleaseDate = dtoGame.ReleaseDate
        };
    }
}
