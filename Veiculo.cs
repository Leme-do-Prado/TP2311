public Veiculo {
    string nomeMotorista { get; set; };
    int faturaMotorista = 0 { get; set; };
    string placaVeiculo { get; set; };
    int numLotacao { get; set; };
    Queue<Visitante> passageiros;
    Queue<Visitante> historicoPassageiros;
    Queue<Viagem> viagens;

    
}
