// ========================================
// 🎯 TESTE TÉCNICO - INSTRUÇÕES
// ========================================
//
// Você precisa implementar um sistema de jogo de roleta.
//
// PASSOS:
// 1. Criar pastas Models e Services
// 2. Criar as classes necessárias
// 3. Implementar a lógica do jogo
// 4. Substituir este código pelo código do jogo
//
// DICA: Leia o arquivo teste-backend-csharp.md para ver
// todos os detalhes do desafio!
//
// ========================================

// See https://aka.ms/new-console-template for more information
using RouletteGame.Models;
using RouletteGame.Services;

Console.WriteLine("Hello, World!\n");

Console.WriteLine("=== JOGO DE ROLETA - APOSTAS MÚLTIPLAS ===\n");

// Criar várias apostas para a mesma rodada

var bets = new List<Bet>
{
    new Bet { Id = 1, BetType = "even", Amount = 50 },
    new Bet { Id = 2, BetType = "1-12", Amount = 30 },
    new Bet { Id = 3, BetType = "number", SelectedNumber = 17, Amount = 20 }
};

var rouletteService = new RouletteService();

var prizeDraw = await rouletteService.PrizeDraw();

Console.WriteLine("RESULTADO:");

int count = 0;
foreach (var bet in bets)
{
    var result = 0;
    switch (bet.BetType)
    {
        case "0-36":
            result = await rouletteService.FullNumber(bet, prizeDraw);
            break;
        case "1-12":
            result = await rouletteService.OneToTwelve(bet, prizeDraw);
            break;
        case "13-24":
            result = await rouletteService.ThirteenToTwentyFour(bet, prizeDraw);
            break;
        case "25-36":
            result = await rouletteService.TwentyFiveToThirtySix(bet, prizeDraw);
            break;
        case "even":
            result = await rouletteService.IsEven(bet, prizeDraw);
            break;
        case "odd":
            result = await rouletteService.IsOdd(bet, prizeDraw);
            break;
    }

    count += result;

    Console.WriteLine($" User: {bet.Id} => Retorna: R$ {result}");
}

Console.WriteLine($"\nGain: R$ {bets.Sum(x => x.Amount) - count}");
