using Microsoft.AspNetCore.Mvc;

using RinhaBackEnd.Crebidos.Modules.Client.DTOs;

namespace RinhaBackEnd.Crebidos.Modules.Client.Presentation;

public class TransactionRoutes
{
    public void Register(WebApplication app)
    {

        app.MapPost("clientes/{id}/transacoes",
            [ProducesResponseType(typeof(AddTransactionOututDto), StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            async (
                [FromRoute] int id,
                [FromBody] AddTransactionInputDto data
                ) =>
            {
                    

            })
            .WithGroupName("clientes")
            .WithName("GET_transasoes")
            .WithOpenApi();
    }
}
